namespace XUnitTestProject
{
    public class UnitTest1 : object
    {
        public UnitTest1() : base()
        {
        }

        [Xunit.Fact]
        public void Test_010()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: null);

            string expected = string.Empty;

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_020()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: string.Empty);

            string expected = string.Empty;

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_030()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: "     ");

            string expected = string.Empty;

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_040()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: "Hello, World!");

            string expected = "Hello, World!";

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_050()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: "    Hello, World!    ");

            string expected = "Hello, World!";

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_060()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: "    Hello,  World!    ");

            string expected = "Hello, World!";

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }

        [Xunit.Fact]
        public void Test_070()
        {
            // Arrange
            WebApplicationTest.Infrastructure.Utility utility =
                    new WebApplicationTest.Infrastructure.Utility();

            // Act
            string actual =
                utility.FixText(text: "    Hello,     World!    ");

            string expected = "Hello, World!";

            // Assert
            Xunit.Assert.Equal
                (expected: expected, actual: actual);
        }
    }
}
