using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Windows.Forms;

namespace InteractiveGUI
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
                
        public static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
               WindowsPrincipal principal = new WindowsPrincipal(identity);
               return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private void CreateInstruction()
        {
            // instruction
            lblInstruction.Text = "1. Select testing_tool.py file (download from GCJ interactive problem).";
            lblInstruction.Text += Environment.NewLine;
            lblInstruction.Text += "2. Select your solution file. It must have .cpp/.CPP extension.";
            lblInstruction.Text += Environment.NewLine;
            lblInstruction.Text += "3. Choose your test set.";
            lblInstruction.Text += Environment.NewLine;
            lblInstruction.Text += "4. Click \"Judge\" button and wait for a while.";
            lblInstruction.Text += Environment.NewLine;
            lblInstruction.Text += "5. If everything went well, you'll see the verdict 😉";
        }

        private void AddCPPToPath()
        {
            // make PATH
            string envName = "Path";
            string pathVar = Environment.GetEnvironmentVariable(envName);
            string cCompilerFolder = "MinGW\\bin";
            if (pathVar.IndexOf(cCompilerFolder) == -1)
            {
                var value = "your path goes here";
                if (pathVar[pathVar.Length - 1] != ';')
                {
                    value = pathVar + ";" + Path.Combine(Directory.GetCurrentDirectory(), @"MinGW\bin");
                }
                else
                {
                    value = pathVar + Path.Combine(Directory.GetCurrentDirectory(), @"MinGW\bin");
                }
                var target = EnvironmentVariableTarget.Machine;
                Environment.SetEnvironmentVariable(envName, value, target);
            }
        }

        private void AddPythonToPath()
        {
            // make PATH
            string envName = "Path";
            string pathVar = Environment.GetEnvironmentVariable(envName);
            string pythonCompilerFolder = "Python37-32";
            if (pathVar.IndexOf(pythonCompilerFolder) == -1)
            {
                var value = "your path goes here";
                if (pathVar[pathVar.Length - 1] != ';')
                {
                    value = pathVar + ";" + Path.Combine(Directory.GetCurrentDirectory(), @"Python37-32");
                }
                else
                {
                    value = pathVar + Path.Combine(Directory.GetCurrentDirectory(), @"Python37-32");
                }
                var target = EnvironmentVariableTarget.Machine;
                Environment.SetEnvironmentVariable(envName, value, target);
                
            }
        }

        private void DeleteOldLogFile()
        {
            string fileName = @Directory.GetCurrentDirectory() + @"\log.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!IsAdministrator())
            {
                if (MessageBox.Show("Please run application as Administrator", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            CreateInstruction();
            AddCPPToPath();
            AddPythonToPath();
            DeleteOldLogFile();
        }

        // select folder path
        private void btnTestingDirSelector_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.ShowDialog();
            txtTestingToolDir.Text = fbd.FileName;
        }

        private void btnSolutionDirSelector_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            fbd.ShowDialog();
            txtSolutionFileDir.Text = fbd.FileName;
        }

        // change state so that it is unchangeable during process
        private void changeState()
        {
            txtSolutionFileDir.ReadOnly = !txtSolutionFileDir.ReadOnly;
            txtTestingToolDir.ReadOnly = !txtTestingToolDir.ReadOnly;
            btnSolutionDirSelector.Enabled = !btnSolutionDirSelector.Enabled;
            btnTestingDirSelector.Enabled = !btnTestingDirSelector.Enabled;
            btnJudge.Enabled = !btnJudge.Enabled;
        }

        // set value for process
        private void setValue(ref ProcessStartInfo processInfo, string fileName, string args)
        {
            processInfo.FileName = fileName;
            processInfo.Arguments = args;
            processInfo.UseShellExecute = false; // Do not use OS shell
            processInfo.CreateNoWindow = true; // We don't need new window
            processInfo.RedirectStandardOutput = true; // Any output, generated by application will be redirected back
            processInfo.RedirectStandardError = true; // Any error in standard output will be redirected back (for example exceptions)
        }

        private void WriteToLog(string nextLog)
        {
            string fileName = @Directory.GetCurrentDirectory() + @"\log.txt";
            using (StreamWriter file = File.AppendText(fileName))
            {
                file.WriteLine(nextLog);
            }
        }
        
        // main 
        private void btnJudge_Click(object sender, EventArgs e)
        {
            WriteToLog("Entered main funtion.....");
            // validate some data
            if (string.IsNullOrEmpty(txtTestingToolDir.Text) || string.IsNullOrWhiteSpace(txtTestingToolDir.Text))
            {
                if (MessageBox.Show("Empty directory is not allowed!", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    WriteToLog("Checked. Empty testing tool directory");
                    return;
                }
            }
            if (Path.GetExtension(txtTestingToolDir.Text).ToLower() != ".py")
            {
                if (MessageBox.Show("Testing file is not a .py file!", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    WriteToLog("Checked. Not python file.");
                    return;
                }
            }
            if (string.IsNullOrEmpty(txtSolutionFileDir.Text) || string.IsNullOrWhiteSpace(txtSolutionFileDir.Text))
            {
                if (MessageBox.Show("Empty directory is not allowed!", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    WriteToLog("Checked. Empty solution directory.");
                    return;
                }
            }
            if (Path.GetExtension(txtSolutionFileDir.Text).ToLower() != ".cpp")
            {
                if (MessageBox.Show("Solution file is not a .cpp file!", "Warning", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    WriteToLog("Checked. Not cpp file.");
                    return;
                }
            }

            WriteToLog("Checked. Valid data");
            // get test number
            int testSet;
            if (rbtn1.Checked) testSet = 0;
            else testSet = 1;
            WriteToLog($"Test set {testSet} chosen");


            string TestingToolDirectory = @txtTestingToolDir.Text;
            string SolutionDirectory = @txtSolutionFileDir.Text;
            string verdictMessage = "";

            WriteToLog($"Testing Tool Directory is {TestingToolDirectory}");
            WriteToLog($"Solution Directory is {SolutionDirectory}");

            changeState();
            WriteToLog("State Changed");

            // delete old exe file
            File.Delete(Path.GetDirectoryName(SolutionDirectory) + @"\" + Path.GetFileNameWithoutExtension(SolutionDirectory) + ".exe");
            WriteToLog("Old file exe deleted");

            ////////////////////////////////////compile C++///////////////////////////////////
            // g++ -std=c++14 -O2 zzz.cpp -o zzz
            ProcessStartInfo startCompilingCPP = new ProcessStartInfo();
            string gcc = "g++"; //Path.Combine(Directory.GetCurrentDirectory(), @"MinGW\bin", "g++.exe");
            string compileCPP = string.Format("-std=c++14 -O2 {0} -o {1}", SolutionDirectory, Path.GetDirectoryName(SolutionDirectory) + @"\" + Path.GetFileNameWithoutExtension(SolutionDirectory));
            setValue(ref startCompilingCPP, gcc, compileCPP);
            WriteToLog($"command C++ compile is {compileCPP}");
            Process process = new Process();
            process.StartInfo = startCompilingCPP;
            try
            {
                process.Start();
                while (!process.HasExited)
                {
                    Application.DoEvents();
                    txtVerdict.Text = "Compiling your solution........";
                }
                txtVerdict.Text = "Your solution might compile succesfully. Judging now........";
                verdictMessage = process.StandardError.ReadToEnd() + Environment.NewLine;
            }
            catch(Exception err)
            {
                WriteToLog($"Error {err.Message}");
            }
            
            WriteToLog("Compile successfully");
            //////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////run/////////////////////////////////////////
            string python = "python"; //Path.Combine(Directory.GetCurrentDirectory(), @"Python37-32", "python.exe");
            string interactive_runner = @Path.Combine(Directory.GetCurrentDirectory(), "interactive_runner.py");
            string compilePython = string.Format("{0} {1} {2} {3} -- {4}", interactive_runner, python, TestingToolDirectory, testSet, Path.GetDirectoryName(SolutionDirectory) + @"\" + Path.GetFileNameWithoutExtension(SolutionDirectory));
            ProcessStartInfo startCompilingPython = new ProcessStartInfo();
            setValue(ref startCompilingPython, python, compilePython);
            WriteToLog($"command python compile is {compilePython}");

            try
            {
                using (Process pyProcess = Process.Start(startCompilingPython))
                {
                    while (!pyProcess.HasExited)
                    {
                        Application.DoEvents();
                        TimeSpan runtime = DateTime.Now - pyProcess.StartTime;

                        // allow the process to run for 30s
                        if (runtime.TotalSeconds >= 30)
                        {
                            WriteToLog("Runtime Error");
                            txtVerdict.Text = "Runtime Error";
                            changeState();
                            return;
                        }
                    }
                    string stderr = pyProcess.StandardError.ReadToEnd(); // Here are the exceptions from our Python script
                    string result = pyProcess.StandardOutput.ReadToEnd(); // Here is the result of StdOut(for example: print "test")
                    verdictMessage += stderr + Environment.NewLine + result;
                }
            }
            catch (Exception err)
            {
                WriteToLog($"Error {err.Message}");
            }

            WriteToLog("Python run successfully");
            /////////////////////////////////////////////////////////////////////////////////
            if (verdictMessage.IndexOf("Judge return code: 0") != -1)
            {
                verdictMessage += Environment.NewLine + "Pretest passed";
            }
            txtVerdict.Text = verdictMessage;
            changeState();
            WriteToLog("\n");
        }
    }
}
