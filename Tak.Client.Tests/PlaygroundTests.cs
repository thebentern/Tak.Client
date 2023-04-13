using dpp.cot;

namespace TheBentern.Tak.Client.Tests;

[TestFixture]
public class PlaygroundTests
{
    [Test]
    public async Task End2End()
    {
        var takClient = new TakClient(@"C:\Users\Meadors\Downloads\atak.zip");
        await takClient.ListenAsync(cotEventHandler);
    }

    private async Task cotEventHandler(Event arg)
    {
        await Task.CompletedTask;
    }
}