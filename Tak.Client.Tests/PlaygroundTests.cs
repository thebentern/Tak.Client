namespace Tak.Client.Tests;

[TestFixture]
public class PlaygroundTests
{
    [Test]
    public async Task End2End()
    {
        var takClient = new TakClient(@"C:\Users\Meadors\Downloads\atak.zip");
        await takClient.ConnectAsync();
    }
}