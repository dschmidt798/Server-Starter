using System.Diagnostics;

namespace Server_Starter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process clientProcess = new Process();

            clientProcess.StartInfo.FileName = "java";
            clientProcess.StartInfo.Arguments = @"-Xmx3000M -jar" + "\\Server\\server.jar";
            clientProcess.Start();
            clientProcess.WaitForExit();

            int code = clientProcess.ExitCode;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}