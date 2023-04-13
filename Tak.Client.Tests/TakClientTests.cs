namespace TheBentern.Tak.Client.Tests;

[TestFixture]
public class TakClientTests
{
    [Test]
    public void RequiresValidPackagePath()
    {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        var ctor = () => new TakClient(null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        ctor.Should().Throw<ArgumentNullException>();

        ctor = () => new TakClient(String.Empty);
        ctor.Should().Throw<ArgumentNullException>();

        ctor = () => new TakClient("nope.jpg");
        ctor.Should().Throw<ArgumentException>();
    }
}