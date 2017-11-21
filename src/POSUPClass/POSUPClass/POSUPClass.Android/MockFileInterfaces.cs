using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(POSUPClass.MockUploadWebService))]
namespace POSUPClass
{

    


    public class MockUploadWebService : IUploadWebService
    {


        private static List<Uri> fotos = new List<Uri>();

        public MockUploadWebService()
        {

        }

        public void deleteFile(Uri uri)
        {
           

            fotos.Remove(uri);
        }

        public Uri[] listFiles()
        {
            return fotos.ToArray<Uri>();
        }

        public void uploadFileAsync(Uri uri, string file)
        {
            fotos.Add(uri);
        }
    }
}
