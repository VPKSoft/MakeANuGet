using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MakeANuGet.DialogForms
{
    /// <summary>
    /// A dialog to display a command output.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormDialogCommandShell : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormDialogCommandShell"/> class.
        /// </summary>
        public FormDialogCommandShell()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the command to execute.
        /// </summary>
        private string Command { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Command"/> path.
        /// </summary>
        private string CommandPath { get; set; }

        /// <summary>
        /// Gets or sets the working directory for the <see cref="Command"/>.
        /// </summary>
        private string WorkingDirectory { get; set; }

        /// <summary>
        /// Gets or sets the command arguments.
        /// </summary>
        private List<CommandArgument> CommandArguments { get; set; }

        /// <summary>
        /// Gets or sets the command return value.
        /// </summary>
        private int CommandResult { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to kill the current process.
        /// </summary>
        private bool KillCurrentProcess { get; set; }


        /// <summary>
        /// Executes the <see cref="Command"/> command and redirects the output to this dialog form instance.
        /// </summary>
        private void ExecuteCommand()
        {
            string RemoveSensitiveInformation(string value)
            {
                if (value != null)
                {
                    foreach (var commandArgument in CommandArguments)
                    {
                        if (commandArgument.ArgumentValue == null)
                        {
                            continue;
                        }

                        value = value.Replace(commandArgument.ArgumentValue, commandArgument.HiddenArgumentValue);
                    }
                }

                return value;
            }

            while (NextCommand)
            {
                try
                {
                    var commandEcho = Path.Combine(CommandPath, Command);

                    var arguments = string.Join(" ", CommandArguments.Select(f => f.ToStringHidden()));

                    if (arguments != string.Empty)
                    {
                        arguments = " " + arguments;
                    }

                    Text = $@"Command output [{Command + arguments}]";

                    commandEcho = "> " + commandEcho + arguments + Environment.NewLine;

                    tbProcessOutput.AppendText(commandEcho);

                    arguments = string.Join(" ", CommandArguments.Select(f => f.ToString()));

                    // create a process..
                    Process process = new Process
                    {
                        StartInfo =
                        {
                            FileName = Command,
                            Arguments = arguments,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            WorkingDirectory = WorkingDirectory,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true
                        }
                    };

                    // subscribe to the process events with anonymous event handlers..
                    process.OutputDataReceived += (sender, e) =>
                    {
                        // append new line endings to the each output string..
                        if (!string.IsNullOrEmpty(e.Data))
                        {
                            // invocation is required (another process)..
                            Invoke(new MethodInvoker(delegate
                            {
                                tbProcessOutput.AppendText(
                                    RemoveSensitiveInformation(e.Data) + Environment.NewLine);
                            }));
                        }
                    };

                    process.ErrorDataReceived += (sender, e) =>
                    {
                        // append new line endings to the each output string..
                        if (!String.IsNullOrEmpty(e.Data))
                        {
                            // invocation is required (another process)..
                            Invoke(new MethodInvoker(delegate
                            {
                                tbProcessOutput.AppendText(
                                    RemoveSensitiveInformation(e.Data) + Environment.NewLine);
                            }));
                        }
                    };

                    // start the process after "hefty" initialization..
                    process.Start();

                    // asynchronously read the standard output of the spawned process. 
                    // This raises OutputDataReceived events for each line of output.
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();

                    // wait for the process to exit while "pumping" the software to be "responsive"..
                    while (!process.HasExited)
                    {
                        Application.DoEvents();
                        Thread.Sleep(100);
                        if (KillCurrentProcess)
                        {
                            KillCurrentProcess = false;
                            process.Kill();
                        }
                    }

                    using (process)
                    {
                        CommandResult = process.ExitCode;
                    }

                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    tbProcessOutput.AppendText($"> Command execution failed with an exception '{ex.Message}'");
                }
                tbProcessOutput.AppendText(Environment.NewLine);
            }
            btClose.Enabled = true;
        }

        /// <summary>
        /// A delegate to request a new command to run after the previous was executed.
        /// </summary>
        /// <param name="workingDirectory">The working directory for the command.</param>
        /// <param name="path">The path where the command should be executed.</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="commandArguments">The command arguments. <see cref="CommandArgument"/></param>
        public delegate void OnRequestNewCommand(ref string workingDirectory, ref string path, ref string command,
            ref CommandArgument[] commandArguments);

        /// <summary>
        /// A delegate called when a new command is requested after the previous was executed.
        /// </summary>
        private OnRequestNewCommand RequestNewCommand { get; set; }

        private bool firstRun = true;

        /// <summary>
        /// Gets a value indicating whether a new command for execution is available.
        /// </summary>
        private bool NextCommand
        {
            get
            {
                if (firstRun)
                {
                    firstRun = false;
                    return true;
                }

                if (RequestNewCommand == null)
                {
                    return false;
                }

                string workingDirectory = string.Empty, path = string.Empty, command = string.Empty;
                CommandArgument[] commandArguments = null;
                RequestNewCommand.Invoke(ref workingDirectory, ref path, ref command, ref commandArguments);

                if (workingDirectory == null)
                {
                    return false;
                }

                WorkingDirectory = workingDirectory;
                CommandPath = path;
                Command = command;
                CommandArguments = new List<CommandArgument>(commandArguments);
                return true;
            }
        }

        /// <summary>
        /// Executes the specified Command Prompt command in a dialog.
        /// </summary>
        /// <param name="owner">Any object that implements IWin32Window that represents the top-level window that will own the modal dialog box.</param>
        /// <param name="workingDirectory">The working directory for the command.</param>
        /// <param name="path">The path where the command should be executed.</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="commandArguments">The command arguments. <see cref="CommandArgument"/></param>
        /// <returns>The return value of the specified command.</returns>
        public static int ExecuteCommand(IWin32Window owner, string workingDirectory, string path, string command, params CommandArgument[] commandArguments)
        {
            var form = new FormDialogCommandShell
            {
                Command = command, 
                CommandArguments = new List<CommandArgument>(commandArguments),
                CommandPath = path,
                WorkingDirectory = workingDirectory,
            };

            form.ShowDialog(owner);
            using (form)
            {
                return form.CommandResult;
            }
        }


        /// <summary>
        /// Executes the specified Command Prompt command in a dialog.
        /// </summary>
        /// <param name="owner">Any object that implements IWin32Window that represents the top-level window that will own the modal dialog box.</param>
        /// <param name="workingDirectory">The working directory for the command.</param>
        /// <param name="path">The path where the command should be executed.</param>
        /// <param name="command">The command to execute.</param>
        /// <param name="requestNewCommand">A delegate to be used to request a new command for execution.</param>
        /// <param name="commandArguments">The command arguments. <see cref="CommandArgument"/></param>
        /// <returns>The return value of the specified command.</returns>
        public static int ExecuteCommand(IWin32Window owner, string workingDirectory, string path, string command,
            OnRequestNewCommand requestNewCommand, params CommandArgument[] commandArguments)
        {
            var form = new FormDialogCommandShell
            {
                Command = command, 
                CommandArguments = new List<CommandArgument>(commandArguments),
                CommandPath = path,
                WorkingDirectory = workingDirectory,
                RequestNewCommand = requestNewCommand,
            };

            form.ShowDialog(owner);
            using (form)
            {
                return form.CommandResult;
            }
        }

        private void FormDialogCommandShell_Shown(object sender, EventArgs e)
        {
            ExecuteCommand();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btKillProcess_Click(object sender, EventArgs e)
        {
            KillCurrentProcess = true;
        }
    }

    /// <summary>
    /// A class representing a single command line argument.
    /// </summary>
    public class CommandArgument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandArgument"/> class.
        /// </summary>
        public CommandArgument()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandArgument"/> class.
        /// </summary>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="quoteValue">if set to <c>true</c> the <see cref="ArgumentValue"/> is quoted.</param>
        public CommandArgument(string argumentValue, bool quoteValue)
        {
            ArgumentValue = argumentValue;
            QuoteValue = quoteValue;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="CommandArgument"/> class.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="argumentValue">The argument value.</param>
        public CommandArgument(string argument, string argumentValue)
        {
            Argument = argument;
            ArgumentValue = argumentValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandArgument"/> class.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="hideFromDisplay">The value indicating whether the argument should not be shown on the screen (hidden).</param>
        public CommandArgument(string argument, string argumentValue, bool hideFromDisplay)
        {
            Argument = argument;
            ArgumentValue = argumentValue;
            HideFromDisplay = hideFromDisplay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandArgument"/> class.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="argumentValueSeparator">The argument name and value separator.</param>
        public CommandArgument(string argument, string argumentValue, string argumentValueSeparator)
        {
            Argument = argument;
            ArgumentValue = argumentValue;
            ArgumentValueSeparator = argumentValueSeparator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandArgument"/> class.
        /// </summary>
        /// <param name="argument">The argument.</param>
        /// <param name="argumentValue">The argument value.</param>
        /// <param name="argumentValueSeparator">The argument name and value separator.</param>
        /// <param name="hideFromDisplay">The value indicating whether the argument should not be shown on the screen (hidden).</param>
        public CommandArgument(string argument, string argumentValue, string argumentValueSeparator, bool hideFromDisplay)
        {
            Argument = argument;
            ArgumentValue = argumentValue;
            ArgumentValueSeparator = argumentValueSeparator;
            HideFromDisplay = hideFromDisplay;
        }

        /// <summary>
        /// Gets or sets the argument.
        /// </summary>
        public string Argument { get; set; }

        /// <summary>
        /// Gets or sets the argument name and value separator. The default is a white space (' ').
        /// </summary>
        public string ArgumentValueSeparator { get; set; } = " ";

        /// <summary>
        /// Gets or sets the value of the command argument.
        /// </summary>
        public string ArgumentValue { get; set; }        
        
        /// <summary>
        /// Gets the <see cref="ArgumentValue"/> either hidden if the <see cref="HideFromDisplay"/> is <c>true</c>; otherwise the  the <see cref="ArgumentValue"/> is returned.
        /// </summary>
        public string HiddenArgumentValue => HideFromDisplay ? new string('•', ArgumentValue.Length) : ArgumentValue;

        /// <summary>
        /// Gets or sets the value whether the argument should not be shown on the screen (hidden).
        /// </summary>
        public bool HideFromDisplay { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="ArgumentValue"/> should be quoted with a double-quotation mark (").
        /// </summary>
        public bool QuoteValue { get; set; } = true;

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            if (string.IsNullOrEmpty(ArgumentValue))
            {
                return Argument;
            }

            return Argument + ArgumentValueSeparator + (QuoteValue ? "\"" : string.Empty) + ArgumentValue + (QuoteValue ? "\"" : string.Empty);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// If the <see cref="HideFromDisplay"/> is <c>true</c> the <see cref="ArgumentValue"/> is represented as same length string containing bullet characters (•).
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public string ToStringHidden()
        {
            var result = ToString();
            if (HideFromDisplay)
            {
                result = result.Replace(ArgumentValue, HiddenArgumentValue);
            }

            return result;
        }
    }
}
