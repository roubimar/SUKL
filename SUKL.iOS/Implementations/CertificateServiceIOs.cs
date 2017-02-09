using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using SUKL.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(ICertificateService))]
namespace SUKL.iOS.Implementations
{
    public class CertificateServiceIOs : ICertificateService
    {
        public CertificateServiceIOs() { }

        public byte[] Encrypt(byte[] data)
        {
            var certificate = new System.Security.Cryptography.X509Certificates.X509Certificate2(data).PrivateKey;
            return null;
        }

        public string ReadFile(string fileName)
        {
            return string.Empty;
        }
    }
}