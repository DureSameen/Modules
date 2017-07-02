using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SCClientApp.SetupDialogue
{
    [RunInstaller(true)]
    public partial class CustomerModuleInstaller : System.Configuration.Install.Installer
    {
      
       
        public CustomerModuleInstaller()
        {
            InitializeComponent();
            
        }

         public override void Install(IDictionary stateSaver)

    {

        base.Install(stateSaver);


        Debugger.Launch();
        string strSecretKey = Context.Parameters["SecretKey"];

        string assemblyPath = Context.Parameters["assemblyPath"];

        int i = assemblyPath.Length - 1;
        while (assemblyPath[i] != '\\') --i;
        string path = assemblyPath.Substring(0, i);

        RunAsync(strSecretKey, path).Wait();
         }

         static async Task RunAsync(string strSecretKey, string working_dir_path)
         {    
             HttpClient client = new HttpClient();
             string serverwebapi_url = ConfigurationManager.AppSettings["serverwebapi_url"].ToString();
             client.BaseAddress = new Uri(serverwebapi_url);
             client.DefaultRequestHeaders.Accept.Clear();
             client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
             string path = serverwebapi_url + "customer/edition_url/" + strSecretKey;

             HttpResponseMessage response = await client.GetAsync(path);
             if (response.IsSuccessStatusCode)
             {
                 string zipfile_url = await response.Content.ReadAsAsync<string>();
                 WebClient webClient = new WebClient();

               

                 webClient.DownloadFile(zipfile_url, working_dir_path);

                 //unzip files in mdoule fodler;

                 Uri uri = new Uri(zipfile_url);
                 if (uri.IsFile)
                 {
                     string filename = System.IO.Path.GetFileName(uri.LocalPath);

                     var extractPath = working_dir_path + "\\Modules";

                     if (!System.IO.Directory.Exists(extractPath))
                         System.IO.Directory.CreateDirectory(extractPath);
                     var zipPath = working_dir_path + filename;
                     ZipFile.ExtractToDirectory(zipPath, extractPath);

                 }
              

             }

         }
    }
}
