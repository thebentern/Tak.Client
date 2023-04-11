namespace Tak.Client.Tests;

[TestFixture]
public class TakClientTests
{
    [Test]
    public void RequiresValidPackagePath()
    {
        var ctor = () => new TakClient(null);
        ctor.Should().Throw<ArgumentNullException>();

        ctor = () => new TakClient(String.Empty);
        ctor.Should().Throw<ArgumentNullException>();

        ctor = () => new TakClient("nope.jpg");
        ctor.Should().Throw<ArgumentException>();
    }
}