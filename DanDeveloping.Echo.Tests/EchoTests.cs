using Echo;

namespace DanDeveloping.Echo.Tests
{
  public class Tests
  {
    [TestCase("123456789012345","123456789012345")]
    [TestCase("12345678901234", "12345678901234")]
    [TestCase("1234567890123", "1234567890123")]
    [TestCase("123456789012", "123456789012")]
    [TestCase("12345678901", "12345678901")]
    [TestCase("1234567890", "1234567890")]
    [TestCase("123456789", "123456789")]
    [TestCase("12345678", "12345678")]
    [TestCase("1234567", "1234567")]
    [TestCase("123456", "123456")]
    [TestCase("12345", "12345")]
    [TestCase("1234", "1234")]
    [TestCase("123", "123")]
    [TestCase("12", "12")]
    [TestCase("1", "1")]
    public void LessThanOrEquals15CharactersProvidesFullMessage(string message, string expectedEcho)
    {
      var echoer = new Echoer();
      var actualEcho = echoer.Echo(message);
      Assert.That(actualEcho, Is.EqualTo(expectedEcho));
    }

    [TestCase("12345678901234567890", "678901234567890")]
    [TestCase("1234567890123456789", "567890123456789")]
    [TestCase("123456789012345678", "456789012345678")]
    [TestCase("12345678901234567", "345678901234567")]
    [TestCase("1234567890123456", "234567890123456")]
    public void MoreThan15CharactersReturnsOnlyLast15CharactersInMessage(string message, string expectedEcho)
    {
      var echoer = new Echoer();
      var actualEcho = echoer.Echo(message);
      Assert.That(actualEcho, Is.EqualTo(expectedEcho));
    }
  }
}