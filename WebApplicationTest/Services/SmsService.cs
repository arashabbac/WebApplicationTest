namespace WebApplicationTest.Services
{
    public class SmsService : object, ISmsService
    {
        public SmsService() : base()
        {
        }

        public int Credit { get; set; }

        public int GetCredit()
        {
            return 0;
        }


        public bool IsCellPhoneNumberValid(string cellPhoneNumber)
        {
            return false;
        }

        public void SendSms(string cellPhoneNumber, string message)
        {
            throw new System.Exception("Server Not Found!");
        }
    }
}
