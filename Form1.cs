using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ISO_Builder
{
    public partial class FormBuildISO : Form
    {
        string source, destination, fileName;
        private FolderBrowserDialog ChooseSource = new FolderBrowserDialog();
        private FolderBrowserDialog ChooseDestination = new FolderBrowserDialog();

        public FormBuildISO()
        {
            InitializeComponent();
        }

        private void FormBuildISO_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
            lblProgress.Hide();
            btnBuildISO.Enabled = false;
        }

        private void btnOpenSource_Click(object sender, EventArgs e)
        {
            lblProgress.Hide();
            try
            {
                ChooseSource.ShowDialog();
                txtSourceFiles.Text = ChooseSource.SelectedPath;
                if (CheckFields()) { btnBuildISO.Enabled = true; }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDestinationPath_Click(object sender, EventArgs e)
        {
            lblProgress.Hide();
            try
            {
                ChooseDestination.ShowDialog();
                txtDestinationPath.Text = ChooseDestination.SelectedPath;
                if (CheckFields()) { btnBuildISO.Enabled = true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtISOFileName_TextChanged(object sender, EventArgs e)
        {
            lblProgress.Hide();
            try
            {
                if (txtISOFileName.Text.Contains(".iso"))
                {
                    if (CheckFields()) { btnBuildISO.Enabled = true; }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuildISO_Click(object sender, EventArgs e)
        {
            source = txtSourceFiles.Text;
            destination = txtDestinationPath.Text;
            fileName = txtISOFileName.Text;

            string Cmd = "\"" + Application.StartupPath + "\\References\\oscdimg.exe\"";
            string Args = "-n -m -b\"" + Application.StartupPath + "\\References\\etfsboot.com\" " +
                "\"" + source + "\" \"" + destination + "\\" + fileName + "\"";

            BuildISO(Cmd, Args);
        }

        private void BuildISO(string Cmd, string Args)
        {
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Show(); 
                       
            Thread thread = new Thread(() => {

                ProcessStartInfo info = new ProcessStartInfo();
                info.CreateNoWindow = true;
                info.FileName = Cmd;
                info.Arguments = Args;
                info.UseShellExecute = false;
                info.RedirectStandardError = true;
                info.RedirectStandardOutput = true;
                Process run = new Process();
                run.StartInfo = info;

                try
                {
                    run.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            thread.Start();
            progressBar1.MarqueeAnimationSpeed = 0;
            lblProgress.Show();
            
        }


        private bool CheckFields()
        {
            if (!String.IsNullOrWhiteSpace(txtSourceFiles.Text) &
                !String.IsNullOrWhiteSpace(txtDestinationPath.Text) &
                !String.IsNullOrWhiteSpace(txtISOFileName.Text))
            {
                return true;
            }
            else { return false; }
        }
    }
}
