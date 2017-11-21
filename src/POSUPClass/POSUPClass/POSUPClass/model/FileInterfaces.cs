using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSUPClass
{
   


    public interface IUploadWebService
    {
        void uploadFileAsync(Uri uri, String file);
        Uri[] listFiles();
        void deleteFile(Uri uri);
    }

    public interface IURLDialog
    {
        void show();
        string getText();
      
    }
}
