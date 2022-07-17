using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text.Json;
//using System.Text.Json.Serialization;
namespace CW1_IP.Model
{
     public class HomePg : IBasicFunc
    {
        private string HPg {  get; set; }                //Getter and setter for Hpg that stors homepage
        private string Title { get; set; }

        public HomePg()
        {
            HPg = "https://www.google.com";
        }
        public Boolean AddTo(string url, string name)                 //Store in
        {
            HPg = url;
            Title = name;
            SaveData();
            return true;
        }

        public Boolean RemoveFrom(string url)
        {
            HPg = "";
            Title = "";
            SaveData();
            return true;
        }
        public void SaveData()
        {
            try
            {
                string path = @"./Data/Files/HomePage.json";
                

                if (HPg != "" && HPg != null)
                {
                    string homepage = JsonConvert.SerializeObject(HPg, Formatting.Indented);
                    System.IO.File.WriteAllText(path, homepage);
                }
                else
                {
                    System.IO.File.WriteAllText(path, string.Empty);
                }
            }

            catch (Exception)
            {
                // ignored
            }
        }

        public void LoadData()
        {
            string path = @"./Data/Files/HomePage.json";
            string homepage;

           

        }

        public string GetHomePg()
        {
            LoadData();
            return HPg;
        }
    }
}
