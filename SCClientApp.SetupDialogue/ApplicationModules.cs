using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SCClientApp.SetupDialogue
{
    public static class ApplicationModules
    {
        public static void Install(AppConfigurations  config)
        {
             

            HttpClient client = new HttpClient();

            try
            {

 
                 string serverwebapi_url =  config.GetSetting("serverwebapi_url");  

                client.BaseAddress = new Uri(serverwebapi_url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string path = serverwebapi_url + config.SecretKey;

                HttpResponseMessage response = client.GetAsync(path).Result;
                if (response.IsSuccessStatusCode)
                {
                    string zipfile_url =   response.Content.ReadAsAsync<string>().Result;

                    Uri uri = new Uri(zipfile_url);
                    
                        string filename = System.IO.Path.GetFileName(uri.LocalPath);
                    WebClient webClient = new WebClient();



                    webClient.DownloadFile(zipfile_url, config.AssemblyPath + filename);

                    var extractPath = config.AssemblyPath + "Edition";

                        if (!System.IO.Directory.Exists(extractPath))

                            System.IO.Directory.CreateDirectory(extractPath);

                        var zipPath = config.AssemblyPath + filename;

                        ZipFile.ExtractToDirectory(zipPath, extractPath);

                      
                        
                        File.SetAttributes(extractPath,   FileAttributes.Normal);
                }
            }
            catch (Exception ex)
            { }
        }

      

    }
}


