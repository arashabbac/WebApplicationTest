namespace XUnitTestProject
{
    public class UnitTest2 : object
    {
        public UnitTest2() : base()
        {
        }

        [Xunit.Fact]
        public void Test_010()
        {
            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            string actual =
                homeController.Action0100(name: "Dariush");

            string expected = "Hello, Dariush!";

            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_020()
        {
            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            var result =
                homeController.Action0200(name: "Dariush");

            var expectedType =
                typeof(Microsoft.AspNetCore.Mvc.ViewResult);

            Xunit.Assert.IsType
                (expectedType: expectedType, @object: result);
        }

        // OR

        [Xunit.Fact]
        public void Test_030()
        {
            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            var result =
                homeController.Action0200(name: "Dariush");

            Xunit.Assert.IsType<Microsoft.AspNetCore.Mvc.ViewResult>(@object: result);
        }

        [Xunit.Fact]
        public void Test_040()
        {

            // ************************************************
            Test_030();
            // ************************************************

            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            var result =
                homeController.Action0200(name: "Dariush")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            bool actual =
                result.ViewData.Keys.Contains("Message");

            Xunit.Assert.True(condition: actual);
        }

        [Xunit.Fact]
        public void Test_050()
        {

            // ************************************************
            Test_040();
            // ************************************************

            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            var result =
                homeController.Action0200(name: "Dariush")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"];

            Xunit.Assert.IsType<string>(@object: actual);
        }

        [Xunit.Fact]
        public void Test_060()
        {

            // ************************************************
            Test_050();
            // ************************************************

            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            var result =
                homeController.Action0200(name: "Dariush")
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"] as string;

            string expected =
                "Hello, Dariush!";

            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_070()
        {

            // ************************************************
            Test_050();
            // ************************************************

            WebApplicationTest.Controllers.HomeController
                homeController = new WebApplicationTest.Controllers.HomeController();

            var result =
                homeController.Action0200(name: null)
                as Microsoft.AspNetCore.Mvc.ViewResult;

            object actual =
                result.ViewData["Message"] as string;

            string expected =
                "Name is null!";

            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }
    }
}
