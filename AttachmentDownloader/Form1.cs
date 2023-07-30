using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace AttachmentDownloader
{
    public partial class Form1 : Form
    {
        private string configPath = "Config.json";
        public Form1()
        {
            InitializeComponent();
            try
            {

                var serializedobject = File.ReadAllText(configPath, Encoding.UTF8);

                var options = JsonConvert.DeserializeObject<Options>(serializedobject);


                textBox_pythonPath.Text = options.PythonPath;


                textBox_host.Text = options.host;
                textBox_username.Text = options.username;
                textBox_password.Text = options.password;
                textBox_imapFolder.Text = options.IMapFolder;
                textBox_outputFolder.Text = options.Output;




                textBox_subjectRegex.Text = options.SubjectRegex;
                dateTimePicker_after.Text = options.DateAfter;
                dateTimePicker_before.Text = options.DateBefore;
                textBox_fileNameTemplate.Text = options.FileNameTemplate;
                textBox_outputFolder.Text = options.Output;
                textBox_port.Text = options.Port;


            }
            catch
            {


            }
        }



        private void button_selectOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                textBox_outputFolder.Text = folder.SelectedPath;
            }
        }

        private async void button_download_Click(object sender, EventArgs e)
        {
            Options options = new Options();

            //Fill in the options 
            options.PythonPath = textBox_pythonPath.Text;

            options.host = textBox_host.Text;
            options.username = textBox_username.Text;
            options.password = textBox_password.Text;
            options.IMapFolder = textBox_imapFolder.Text;
            options.Output = textBox_outputFolder.Text;




            options.SubjectRegex = textBox_subjectRegex.Text;
            options.DateAfter = dateTimePicker_after.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            options.DateBefore = dateTimePicker_before.Value.ToString("yyyy-MM-ddTHH:mm:ss");
            options.FileNameTemplate = textBox_fileNameTemplate.Text;
            options.Output = textBox_outputFolder.Text;
            options.Port = textBox_port.Text;


            DownloaderViaPython downloader = new DownloaderViaPython(options);

            downloader.ExecuteWithProccess();

        }

        private void button_saveCOnfiguration_Click(object sender, EventArgs e)
        {
            Options options = new Options();

            //Fill in the options 
            options.PythonPath = textBox_pythonPath.Text;
            options.host = textBox_host.Text;
            options.username = textBox_username.Text;
            options.password = textBox_password.Text;
            options.IMapFolder = textBox_imapFolder.Text;
            options.Output = textBox_outputFolder.Text;




            options.SubjectRegex = textBox_subjectRegex.Text;
            options.DateAfter = dateTimePicker_after.Text;
            options.DateBefore = dateTimePicker_before.Text;
            options.FileNameTemplate = textBox_fileNameTemplate.Text;
            options.Output = textBox_outputFolder.Text;
            options.Port = textBox_port.Text;

            var serilalizedObject = JsonConvert.SerializeObject(options);
            File.WriteAllText(configPath, serilalizedObject, encoding: Encoding.UTF8);

        }
    }
}