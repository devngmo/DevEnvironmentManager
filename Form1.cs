namespace DevEnvironmentManager
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Hide();
            notifyIcon1.Visible = true;

            foreach(var sdk in AppSettings.Instance.InstalledFlutterSDKs)
            {
                mnuFluter.DropDownItems.Add(sdk, null, mnuFluter_Click);
            }
        }

        private void mnuFluter_Click(object? sender, EventArgs e)
        {
            string flutterFolderName = ((ToolStripMenuItem)sender).Text;
            string flutterFolderPath = Path.Combine(AppSettings.Instance.FlutterSDKFolder, flutterFolderName);
            notifyIcon1.ShowBalloonTip(1000, "Switch Flutter SDK", $"Use: {flutterFolderName}", ToolTipIcon.Info);
            
            RegeditHelper.SetFlutterPath(flutterFolderPath);
            Thread.Sleep(500);
            FlutterDoctor.Run(flutterFolderPath);
        }
    }
}
