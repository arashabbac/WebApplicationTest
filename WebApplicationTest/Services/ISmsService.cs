namespace WebApplicationTest.Services
{
    public interface ISmsService
    {
        int Credit { get; set; }

        int GetCredit();

        bool IsCellPhoneNumberValid(string cellPhoneNumber);

        void SendSms(string cellPhoneNumber, string message);
    }
}
