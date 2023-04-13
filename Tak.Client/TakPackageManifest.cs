namespace TheBentern.Tak.Client;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
internal class TakPackageManifest
{
    public string Host { get; set; }
    public int Port { get; set; }
    public byte[] CertData { get; set; }
    public string CertPassword { get; set; }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
