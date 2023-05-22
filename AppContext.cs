namespace sysTrayNotif;

public partial class AppContext : ApplicationContext
{
    private NotifyIcon trayIcon;
    public AppContext()
    {
        // Initialize Tray Icon
        trayIcon = new NotifyIcon();
        trayIcon.Icon = new Icon("database-ok-32.ico");   
        trayIcon.Text = "Upload File App";
        trayIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
        trayIcon.ContextMenuStrip.Items.Add("Config", null, NotifConfig_Click);
        trayIcon.ContextMenuStrip.Items.Add("Exit", null, NotifExit_Click);
        trayIcon.Visible = true;
    }
    void NotifExit_Click(object? sender, EventArgs e)
    {
        trayIcon.Icon = null;
        Application.Exit();
    }

    void NotifConfig_Click(object? sender, EventArgs e)
    {
        Form1 configForm = new Form1();
        configForm.Show();
    }
}