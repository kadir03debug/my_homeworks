using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace core.Utilities.Externalprocessor
{
    public static class Externalfileprocessortool
    {
        public static string Fileaddres { get; set; }
        
        public static string Containneraddress { get; set; }
        public staticbool  Filterfileextension(string fileextension)
        {
            FileInfo _fileınfo = new FileInfo(Fileaddres);
            if (_fileınfo.Extension == fileextension)
            { return true; }
            else { return false; }
        }
        //bu metod sadece bir uzantıya görekısıtlamayapar.
        public static bool fileextensionsfilters(params string[]extensions)
        {
            FileInfo _fileınfo = new FileInfo(Fileaddres );
            foreach (var extension in extensions) { if (extension == _fileınfo.Extension) { return true; } else { return false; } }
              }
        //birçok uzantıya göre kısıtlamayapılabilir.


    }
}
