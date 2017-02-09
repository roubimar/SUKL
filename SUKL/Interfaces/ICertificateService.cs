using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUKL.Interfaces
{
    public interface ICertificateService
    {
        byte[] Encrypt(byte[] data);

        string ReadFile(string fileName);
    }
}
