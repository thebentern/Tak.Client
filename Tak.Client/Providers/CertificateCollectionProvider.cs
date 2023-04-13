
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using TheBentern.Tak.Client.Generated;

namespace TheBentern.Tak.Client.Providers;

internal class CertificateCollectionProvider
{
    private const string PrefsKey = "com.atakmap.app_preferences";
    private const string CertLocationKey = "certificateLocation";
    private const string CertPasswordKey = "clientPassword";

    private readonly string packagePath;

    public CertificateCollectionProvider(string packagePath)
    {
        this.packagePath = packagePath;
    }

    public X509CertificateCollection GetCollection(Preferences manifest)
    {
        using var package = new ZipArchive(new FileStream(packagePath, FileMode.Open));
        var pref = manifest.Preference.First(p => p.Name == PrefsKey);
        var certFileName = Path.GetFileName(pref.Entry.First(e => e.Key == CertLocationKey).Text);

        using var certStream = new MemoryStream();
        var certEntry = package.Entries.First(e => e.Name.Contains(certFileName));
        certEntry.Open().CopyToAsync(certStream);

        var cert = new X509Certificate(certStream.ToArray(), pref.Entry.FirstOrDefault(e => e.Key == CertPasswordKey)?.Text);

        return new X509CertificateCollection() { cert };
    }
}
