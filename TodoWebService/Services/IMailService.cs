namespace TodoWebService.Services
{
    public interface IMailService
    {
        void SendAlertMessage(string userMail, string receiverName);
    }
}
