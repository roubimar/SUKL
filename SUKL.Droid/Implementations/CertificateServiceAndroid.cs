using SUKL.Interfaces;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(ICertificateService))]
namespace SUKL.iOS.Implementations
{
    public class CertificateServiceAndroid : ICertificateService
    {
        public CertificateServiceAndroid() { }

        public byte[] Encrypt(byte[] data)
        {
            var certificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(data).PrivateKey;
            return null;
        }

        public string ReadFile(string fileName)
        {
            var path = "sdcard/android/data/SUKL.Droid/files/";
            var filePath = Path.Combine(path.ToString(), fileName);
            string text = File.ReadAllText(path.ToString());
            return text;
        }
    }
}