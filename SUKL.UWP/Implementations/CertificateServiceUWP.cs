using SUKL.Interfaces;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(ICertificateService))]
namespace SUKL.iOS.Implementations
{
    public class CertificateServiceUWP : ICertificateService
    {
        public CertificateServiceUWP() { }

        public byte[] Encrypt(byte[] data)
        {
            return null;
        }

        public string ReadFile(string fileName)
        {
            return string.Empty;
        }
    }
}