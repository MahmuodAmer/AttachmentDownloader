
using System.Diagnostics;
using System.Text;

namespace AttachmentDownloader
{
    public class DownloaderViaPython : IDownloader
    {
        private readonly Options options;
        private string args = "";

        public DownloaderViaPython(Options options)
        {
            this.options = options;
            ArgsBuilder builder = new ArgsBuilder();
            args = builder.CreateFromOptions(options);
        }

        /// <summary>
        /// Every Execution will make in sparated process
        /// </summary>
        /// <returns></returns>
        public async Task<int> ExecuteWithProccess()
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = options.PythonPath;

            // 2) Provide script and arguments


            psi.Arguments = args;

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output

            var process = Process.Start(psi);


            var standardOutputTask = process.StandardOutput.ReadToEndAsync();
            var standardErrorTask = process.StandardError.ReadToEndAsync();

            await Task.WhenAll(standardOutputTask, standardErrorTask, process.WaitForExitAsync());

            try
            {
                File.WriteAllText("Output.txt", standardOutputTask.Result.ToString());
                File.WriteAllText("Error.txt", standardErrorTask.Result.ToString());
            }
            catch
            {


            }



            return process.ExitCode;
        }
    }
}
