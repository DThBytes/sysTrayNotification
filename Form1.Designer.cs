using System.Diagnostics;
namespace sysTrayNotif;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.NotifyIcon notifyIcon;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem configMenuItem;
    //private System.Windows.Forms.ContextMenuStrip contextMenu;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        Trace.WriteLine("Form load");
        this.Hide();
    }


    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
        mainMenu = new MenuStrip();
        configMenuItem = new ToolStripMenuItem();
        this.configMenuItem.Text = "Config";
        this.mainMenu.Items.Add(configMenuItem);
        MainMenuStrip = this.mainMenu;
        this.Controls.Add(MainMenuStrip);

        // Create the NotifyIcon.
        this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);

        notifyIcon.Icon = new Icon("database-ok-32.ico");
        notifyIcon.Text = "Base Backup";
        notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
        notifyIcon.ContextMenuStrip.Items.Add("Config", null, this.NotifConfig_Click);
        notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.NotifExit_Click);
        notifyIcon.Visible = true;
    }
    void NotifExit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    void NotifConfig_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }


    #endregion
}
