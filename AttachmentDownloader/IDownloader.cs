namespace AttachmentDownloader
{
    public interface IDownloader
    {
        Task<int> ExecuteWithProccess();
    }
}