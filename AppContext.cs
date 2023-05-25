using System.Net.Http;
using System.Net.Http.Headers;

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
        trayIcon.ContextMenuStrip.Items.Add("Upload", null, NotifUpload_Click);
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

    async void NotifUpload_Click(object? sender, EventArgs e)
    {
        var httpClient = new HttpClient()
        {
            BaseAddress = new Uri("http://localhost:3000")
        };
            
        //var filePath = @"C:\house.png";
        var filePath = "HORARIOS_2019_DATOS.mdx";
        using (var multipartFormContent = new MultipartFormDataContent())
        {
            //Load the file and set the file's Content-Type header
            var fileStreamContent = new StreamContent(File.OpenRead(filePath));
            fileStreamContent.Headers.ContentType = new MediaTypeHeaderValue("multipart/form-data");

            //Add the file
            multipartFormContent.Add(fileStreamContent, name: "myFile", fileName: "HORARIOS_2019_DATOS.mdx");

            //Send it
            var response = await httpClient.PostAsync("/uploadfile", multipartFormContent);
            response.EnsureSuccessStatusCode();
            //return await response.Content.ReadAsStringAsync();
        }
    }
}