namespace Tak.Client;

internal class TakPackageManifest
{
    public string Host { get; set; }
    public int Port { get; set; }
    public byte[] CertData { get; set; }
    public string CertPassword { get; set; }
}
