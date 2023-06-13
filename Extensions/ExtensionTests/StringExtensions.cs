
using ValidationExtensions;

namespace ExtensionTests
{
    public class StringExtensions

    {
        [Theory]
        [InlineData("bla@example.com", true)]
        [InlineData("th.@gmail", false)]
        public void Should_Return_ValidityOfEmail(string e, bool expected)
        {
            //Arrange

            //Act

            var result = e.IsValidEmail();
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("0031304569872", true)]
        [InlineData("003430567912345", false)]
        public void Should_Return_ValidityOfPhoneNr(string p, bool expected)
        {
            var result = p.IsValidNLPhoneNr();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Testing1!", true)]
        [InlineData("Passwoordenzijncool", false)]
        public void Should_Return_ValidityOfPassword(string p, bool expected)
        {
            var result = p.IsValidPassword();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("This string contains emails. Like admin@example.com. And blabla@gmail.com")]
        public void Should_Replace_Emails_with_Asterisks(string input)
        {
            string testOutput = "This string contains emails. Like ********. And ********";
            var result = input.ReplaceEmails();
            Assert.Equal(testOutput, result);

        }
    }
}