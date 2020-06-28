using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace VsSourceExtractor
{
    public partial class Form1 : Form
    {
        string SoursePath, OutputPath, WorkDir;
        public Form1()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;
            SoursePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"source\repos");
            OutputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string.Format(@"Sourses [{0}].zip", new object[] { DateTime.Now.ToShortDateString() }));
            WorkDir = Path.Combine(System.IO.Path.GetTempPath(), "VSExtractFolder");
        }

        private void ChangeInputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                SoursePath = FBD.SelectedPath;
                InputPathTextbox.Text = FBD.SelectedPath;
            }
        }

        private void ChangeOutputButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog FBD = new SaveFileDialog();
            FBD.Filter = "Zip files(*.zip)|*.zip";
            FBD.FileName = string.Format(@"Sourses [{0}].zip", new object[] { DateTime.Now.ToShortDateString() });
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                OutputPath = FBD.FileName;
                OutputPathTextbox.Text = FBD.FileName;
            }
        }

        async private void ExtractButton_Click(object sender, EventArgs e)
        {
            ExtractButton.Enabled = false;
            ExtractButton.Text = "Extracting...";

            await Task.Run(()=> {
                int FileCount = 0;
                foreach (string newPath in Directory.GetFiles(SoursePath, "*.*", SearchOption.AllDirectories))
                {
                    if (newPath.Contains(".vs") || newPath.Contains("bin") || newPath.Contains("Debug") || newPath.Contains("Release") || newPath.Contains("obj")) continue;
                    if (ClearPackagesCheckbox.Checked) if (newPath.Contains("packages")) continue;
                    FileCount++;
                }
                Invoke((Action)(() => { Progressbar.Maximum = FileCount; }));
                if (!Directory.Exists(WorkDir)) Directory.CreateDirectory(WorkDir);
                if (Directory.Exists(SoursePath))
                {
                    foreach (string dirPath in Directory.GetDirectories(SoursePath, "*", SearchOption.AllDirectories))
                    {
                        try
                        {
                            if (dirPath.Contains(".vs") || dirPath.Contains("bin") || dirPath.Contains("Debug") || dirPath.Contains("Release") || dirPath.Contains("obj")) continue;
                            if (ClearPackagesCheckbox.Checked) if (dirPath.Contains("packages")) continue;
                            Directory.CreateDirectory(dirPath.Replace(SoursePath, WorkDir));
                        }
                        catch { }
                    }
                    foreach (string newPath in Directory.GetFiles(SoursePath, "*.*", SearchOption.AllDirectories))
                    {
                        if (newPath.Contains(".vs") || newPath.Contains("bin") || newPath.Contains("Debug") || newPath.Contains("Release") || newPath.Contains("obj")) continue;
                        if (ClearPackagesCheckbox.Checked) if (newPath.Contains("packages")) continue;
                        File.Copy(newPath, newPath.Replace(SoursePath, WorkDir), true);
                        Invoke((Action)(() => { Progressbar.Value++; }));
                    }
                    if (File.Exists(OutputPath)) File.Delete(OutputPath);
                    ZipFile.CreateFromDirectory(WorkDir, OutputPath, CompressionLevel.Optimal, false);
                    if (Directory.Exists(WorkDir)) Directory.Delete(WorkDir, true);
                    Invoke((Action)(() => { Progressbar.Value = 0; }));
                }

            });
            if (ExitCheckbox.Checked) Environment.Exit(0);
            ExtractButton.Text = "Extract";
            ExtractButton.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InputPathTextbox.Text = SoursePath;
            OutputPathTextbox.Text = OutputPath;
        }
    }
}
