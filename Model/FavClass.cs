using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.SqlServer.Server;
using Nancy.Json;
using Newtonsoft;
using Newtonsoft.Json;

namespace CW1_IP.Model
{
    class FavData
    {
        public string FavURL { get; set; }
        public string FavName { get; set; }
    }
    public class FavClass : IBasicFunc
    {
        private static HashSet<FavData> FavList = new HashSet<FavData>();
        

        public FavClass()
        {
            LoadData();
        }

        public void SaveData()                                  //Used to save data Json File
        {
            LoadData();
            HashSet<FavData> tmp = new HashSet<FavData>();
            string json = JsonConvert.SerializeObject(FavList, Formatting.Indented);
            File.WriteAllText(@"./Data/Files/Favorites.json", json);
        }
        public void LoadData()                                  //Used to Load data to Excel File
        {
          /*  //deserialize JSON from file  
            string Json = File.ReadAllText(@"./Data/Files/Favorites.json");
            if (Json != null && Json.Length > 0)
            {
                JavaScriptSerializer ser = new JavaScriptSerializer();
                var Tlist = ser.Deserialize<HashSet<FavData>>(Json);
                FavList = Tlist;
            }*/
            
        }

        public bool AddTo(string url, string name)           //to remove Favriotes or History
        {
            
            try
            {
                    if (name == "Title not Found")              //if title wasnt found in Html code
                    {
                        string S1 = "//:";
                        int I1 = url.IndexOf(S1);

                        string S2 = ".com";
                        int I2 = url.IndexOf(S2);

                        I1 += 7;
                        int lenght = I2 - I1;
                        name = url.Substring(I1, lenght);       //gets name from url

                    }
                    FavList.Add(item: new FavData { FavName = name, FavURL = url });
                    SaveData();
                    return true;
                } catch (Exception)
                {
                    return false;
                }



            }
            public bool RemoveFrom(string url)                         //to remove Favriotes or History
            {
                var query = from x in FavList
                            where x.FavURL == url
                            select x;

                if (query != null)
                {

                    foreach (FavData s in query.ToList())
                    {
                        FavList.Remove(s);
                        SaveData();
                    }

                }
                return true;
            }

            public bool ModifyFav(string url, string name, bool Change)
            {
                try
                {


                    if (Change == true)
                    {
                        var query = from x in FavList
                                    where x.FavURL == url
                                    select x;

                        foreach (FavData s in query.ToList())
                        {
                            FavList.Remove(s);
                            FavList.Add(item: new FavData { FavName = name, FavURL = url });
                        }
                    SaveData();
                        return true;
                    }
                    else
                    {
                        var query = from x in FavList
                                    where x.FavName == name
                                    select x;

                    foreach (FavData s in query.ToList())
                    {
                        FavList.Remove(s);
                        FavList.Add(item: new FavData { FavName = name, FavURL = url });
                    }
                    SaveData();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }

            public object getList()
            {
                LoadData();
                return FavList;
            }
        }

    }

