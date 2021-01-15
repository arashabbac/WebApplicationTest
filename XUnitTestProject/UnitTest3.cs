namespace XUnitTestProject
{
    /// <summary>
    /////https://github.com/moq/moq4
    //// https://github.com/moq/moq4/wiki/quickstart

    //// https://www.nuget.org/package/Moq/
    //// Install-Package Moq -Version 4.15.1 
    /// </summary>
    public class UnitTest3 : object
    {
        public UnitTest3() : base()
        {
        }

        [Xunit.Fact]
        public void Test_010()
        {
            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            mock.Setup(current => current.Credit).Returns(0);

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!");

            Xunit.Assert.IsType
                <Microsoft.AspNetCore.Mvc.ViewResult>(@object: result);
        }

        [Xunit.Fact]
        public void Test_020()
        {
            // ********************************************************
            Test_010();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            mock.Setup(current => current.Credit).Returns(0);

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!") 
                as Microsoft.AspNetCore.Mvc.ViewResult;

            bool actual = 
                result.ViewData.Keys.Contains("Message");

            Xunit.Assert.True(condition: actual);
                
        }

        [Xunit.Fact]
        public void Test_030()
        {
            // ********************************************************
            Test_020();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            mock.Setup(current => current.Credit).Returns(0);

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"];

            Xunit.Assert.IsType<string>(@object: actual);

        }

        [Xunit.Fact]
        public void Test_040()
        {
            // ********************************************************
            Test_030();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            mock.Setup(current => current.Credit).Returns(0);

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"] as string;

            string expected =
                "Not Enough Credit!";

            Xunit.Assert.Equal(expected: expected, actual: actual);

        }

        [Xunit.Fact]
        public void Test_050()
        {
            // ********************************************************
            Test_030();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            mock.Setup(current => current.Credit).Returns(10);

            //Mr Mock !! That object that you inject into SmsController , if inside a function that you want to test (Send)
            //someone calls IsCellPhoneNumberValid function with any input parameter of string type , you always return false
            mock.Setup(current => current.IsCellPhoneNumberValid(Moq.It.IsAny<string>())).Returns(false);

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"] as string;

            string expected =
                 "Cell Phone Number Is Not Valid!";

            Xunit.Assert.Equal(expected: expected, actual: actual);

        }

        [Xunit.Fact]
        public void Test_060()
        {
            // ********************************************************
            Test_030();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            string erroeMessage = "Server Not Found!";
            System.Exception exception = 
                new System.Exception(message: erroeMessage);

            mock.Setup(current => current.Credit).Returns(10);
            mock.Setup(current => current.IsCellPhoneNumberValid(Moq.It.IsAny<string>())).Returns(true);
            mock.Setup(current => current.SendSms(Moq.It.IsAny<string>(), Moq.It.IsAny<string>())).Throws(exception);

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"] as string;

            string expected = erroeMessage;

            Xunit.Assert.Equal(expected: expected, actual: actual);

        }

        [Xunit.Fact]
        public void Test_070()
        {
            // ********************************************************
            Test_030();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            string erroeMessage = "Server Not Found!";
            System.Exception exception =
                new System.Exception(message: erroeMessage);

            mock.Setup(current => current.Credit).Returns(10);
            mock.Setup(current => current.IsCellPhoneNumberValid(Moq.It.IsAny<string>())).Returns(true);
            mock.Setup(current => current.SendSms(Moq.It.IsAny<string>(), Moq.It.IsAny<string>())).Verifiable();

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"] as string;

            string expected = 
                "SMS Sent Successfully!";

            Xunit.Assert.Equal
                (expected: expected, actual: actual);

        }

        [Xunit.Fact]
        public void Test_080()
        {
            // ********************************************************
            Test_030();
            // ********************************************************

            var mock =
                new Moq.Mock<WebApplicationTest.Services.ISmsService>();

            string erroeMessage = "Server Not Found!";
            System.Exception exception =
                new System.Exception(message: erroeMessage);

            int credit = 10;
            //mock.Setup(current => current.Credit).Returns(credit);
            //mock.SetupGet(current => current.Credit).Returns(credit);

            // Initial Value!
            mock.SetupProperty(current => current.Credit , credit);

            mock.Setup(current => current.IsCellPhoneNumberValid(Moq.It.IsAny<string>())).Returns(true);
            mock.Setup(current => current.SendSms(Moq.It.IsAny<string>(), Moq.It.IsAny<string>())).Verifiable();

            WebApplicationTest.Controllers.SmsController smsController =
                new WebApplicationTest.Controllers.SmsController(smsService: mock.Object);

            var result =
                smsController.Send
                (cellPhoneNumber: "09351008895", message: "Hello, World!")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            int expectedCredit = credit - 1;
            int actualCredit = mock.Object.Credit;

            Xunit.Assert.Equal
                (expected: expectedCredit, actual: actualCredit);

        }
    }
}
