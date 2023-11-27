namespace PointOfSaleMVC.EmailSer
{
    public interface IEmailConfigurationSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }

}
