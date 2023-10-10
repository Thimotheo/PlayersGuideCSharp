
using MyValidationExtensions;

namespace ExtensionTests
{
    public class StringExtensions

    {
        [Theory]
        [InlineData("bla@example.com", true)]
        [InlineData("th@gmail", false)]
        [InlineData("master.@example.com", false)]
        [InlineData("admin@hotmail.", false)]
        [InlineData("bla.bla@example.com", true)]
        public void Should_Return_ValidityOfEmail(string e, bool expected)
        {
            //Arrange

            //Act

            var result = e.IsValidEmail();
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Should_Throw_ArgumentNullException_ForEmail(string e)
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => e.IsValidEmail());
        }

        [Theory]
        [InlineData("0031304569872", true)]
        [InlineData("0034305679123", false)]
        [InlineData("003143343224445", false)]
        [InlineData("+31309945456", true)]
        [InlineData("+313457812134", false)]
        [InlineData("+32345987312", false)]
        [InlineData("0302289496", false)]
        [InlineData("31567812349", false)]
        public void Should_Return_ValidityOfPhoneNr(string p, bool expected)
        {
            var result = p.IsValidNLPhoneNr();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Testing1!", true)]
        [InlineData("Watiser?", false)]
        [InlineData("coolwachtwoord1!", false)]
        [InlineData("WACHTW0ORD!", false)]
        [InlineData("Passwoordenzijncool", false)]
        [InlineData("watiseenwachtwoord?", false)]
        [InlineData("poeslief01", false)]
        [InlineData("!!!!@007", false)]
        [InlineData("pindakaas", false)]
        [InlineData("PASSWORDSIDK", false)]
        [InlineData("080000742", false)]
        [InlineData(":<!@$%&!!", false)]
        public void Should_Return_ValidityOfPassword(string p, bool expected)
        {
            var result = p.IsValidPassword();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Should_Throw_ArgumentNullException_ForPassword(string p)
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => p.IsValidPassword());
        }

        [Fact]
        public void Should_Replace_Emails_with_Asterisks()
        {
            string input = "This string contains emails. Like admin@example.com. And blabla@gmail.com";
            string testOutput = "This string contains emails. Like ********. And ********";
            var result = input.ReplaceEmails();
            Assert.Equal(testOutput, result);

        }
    }
}