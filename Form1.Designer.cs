namespace sysTrayNotif;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem configMenuItem;
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Icon = new Icon("database-ok-32.ico");
        this.Text = "Upload File App";
        mainMenu = new MenuStrip();
        configMenuItem = new ToolStripMenuItem();
        this.configMenuItem.Text = "Config";
        this.mainMenu.Items.Add(configMenuItem);
        MainMenuStrip = this.mainMenu;
        this.Controls.Add(MainMenuStrip);
    }
}
