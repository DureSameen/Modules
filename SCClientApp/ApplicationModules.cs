﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SSClientApp
{
    public static class ApplicationModules
    {
        public static void Install()
        {
            string working_dir_path = System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("SCClientApp.exe","");

            HttpClient client = new HttpClient();

            try
            {

                string strSecretKey = System.IO.File.ReadAllText(working_dir_path + "Edition.txt");

                string serverwebapi_url = ConfigurationManager.AppSettings["serverwebapi_url"].ToString();
                client.BaseAddress = new Uri(serverwebapi_url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string path = serverwebapi_url +  strSecretKey;

                HttpResponseMessage response = client.GetAsync(path).Result;
                if (response.IsSuccessStatusCode)
                {
                    string zipfile_url =   response.Content.ReadAsAsync<string>().Result;

                    Uri uri = new Uri(zipfile_url);
                    
                        string filename = System.IO.Path.GetFileName(uri.LocalPath);
                    WebClient webClient = new WebClient();



                    webClient.DownloadFile(zipfile_url, working_dir_path+filename);

                    //unzip files in mdoule fodler;

                   

                        var extractPath = working_dir_path + "\\Modules";

                        if (!System.IO.Directory.Exists(extractPath))
                            System.IO.Directory.CreateDirectory(extractPath);
                        var zipPath = working_dir_path + filename;
                        ZipFile.ExtractToDirectory(zipPath, extractPath);

                    

                }
            }
            catch (Exception ex)
            { }
        }



    }
}

