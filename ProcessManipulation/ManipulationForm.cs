using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Management;

namespace ProcessManipulation
{
	public partial class ManipulationForm : Form
	{
		List<Process> processes = new List<Process>();
		int counter = 0;
		delegate void ProcessDelegate(Process process);
		public ManipulationForm()
		{
			InitializeComponent();
			LoadAvailableAssemblies();
		}
		private void process_Exited(object sender, EventArgs e)
		{
			if (InvokeRequired) {
				Invoke(new Action<object, EventArgs>(process_Exited), sender, e);
				return;
			}

			Process process = sender as Process;
			listBoxRunnedAssemblies.Items.Remove(process.ProcessName);
			listBoxAvalableAssemblies.Items.Add(process.ProcessName);
			processes.Remove(process);
			counter--;

			for (int i = 0; i < processes.Count; i++)
				SetChildWindowText(processes[i].MainWindowHandle, $"Child process {i + 1}");
		}
		void LoadAvailableAssemblies(string FilePath = null)
		{
			string except = new FileInfo(Application.ExecutablePath).Name.Split('.').First();
			string[] files;
			if (FilePath == null) files = Directory.GetFiles(Application.StartupPath, "*.exe");
			else files = Directory.GetFiles(FilePath, "*.exe");

			for (int i = 0; i < files.Length; i++)
				listBoxAvalableAssemblies.Items.Add(files[i].Split('\\').Last().Split('.').First());
			
			listBoxAvalableAssemblies.Items.Remove(except);
		}
		void RunProcess(string assemblyName)
		{
			Process process = Process.Start(folderBrowserDialog1.SelectedPath+'\\'+assemblyName);
			processes.Add(process);

			process.EnableRaisingEvents = true;
			process.Exited += process_Exited;
			SendMessage(process.MainWindowHandle, WM_SETTEXT, (System.IntPtr)0, $"Child process #{processes.Count}");
			listBoxRunnedAssemblies.Items.Add(process.ProcessName);
			listBoxAvalableAssemblies.Items.Remove(process.ProcessName);
		}
		void ExecuteOnProcessByName(string name, ProcessDelegate func)
		{
			Process[] processes = Process.GetProcessesByName(name);
			if (processes.Length == 0)
			{
				MessageBox.Show($"No running process found with the name {name}.");
				return;
			}

			foreach (Process proc in processes)
				if (Process.GetCurrentProcess().Id == GetParentProcessId(proc.Id)) func(proc);
		}
		int GetParentProcessId(int id)
		{
			int parentID;
			using (ManagementObject obj = new ManagementObject("win32_process.handle=" + id.ToString()))
			{
				obj.Get();
				parentID = Convert.ToInt32(obj["ParentProcessId"]);
			}
			return parentID;
		}
		void SetChildWindowText(IntPtr handle, string text)
		{
			SendMessage(handle, WM_SETTEXT, (System.IntPtr)0, text);
		}
		/// <summary>
		/// API function:
		/// </summary>
		const uint WM_SETTEXT = 0x0C;
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hwnd, uint uMsg, IntPtr wParam,
			[MarshalAs(UnmanagedType.LPStr)] string lParam);

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (listBoxAvalableAssemblies.SelectedItem != null)
				RunProcess(listBoxAvalableAssemblies.SelectedItem.ToString());
		}

		private void ManipulationForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach (Process proc in processes)
			{
				proc.CloseMainWindow();
				proc.Close();
			}
		}
		void Kill(Process process)
		{
			process.Kill();
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			if (listBoxRunnedAssemblies.SelectedItem != null)
			{
				string selectedProcessName = listBoxRunnedAssemblies.SelectedItem.ToString();
				ExecuteOnProcessByName(selectedProcessName, Kill);
				listBoxRunnedAssemblies.Items.Remove(selectedProcessName);
			}
			else
				MessageBox.Show("Select a process to stop.");
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.SelectedPath = Application.StartupPath;
			if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				listBoxAvalableAssemblies.Items.Clear();
				LoadAvailableAssemblies(folderBrowserDialog1.SelectedPath);
				//MessageBox.Show(this, folderBrowserDialog1.SelectedPath, "Selected folder: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
