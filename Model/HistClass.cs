using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_IP.Model
{ 
    public class HisData
    {
        public string HisURL { get; set; }
        public int NoHis { get; set; }

    }
    

    
   public class HistClass : IBasicFunc
    {
        private static List<HisData> HisList = new List<HisData>();
        private int HisCount { get; set; } 

       public HistClass()
        {
            LoadData();
            
        }
       public bool AddTo(string url, string name)
        {
            HisCount = HisList.Count;
            HisList.Add(item: new HisData() { NoHis = HisCount + 1, HisURL = url });
            return true;
        }

       public bool RemoveFrom(string url)
        {
            HisCount = HisList.Count;
            var query = from x in HisList                                //LinQ to select all values in list HisData
                                where x.NoHis <= HisCount
                            select x;
            try 
            {
                foreach (HisData s in query)                             // If query = null, catches error
                {
                    HisList.Remove(s);

                }
                SaveData();
            }catch (Exception)
            {
                return false;
            }
            return true;
        }

       public void SaveData()
        {
          /*  TextWriter tw = new StreamWriter(@"./Data/Files/History.txt");

           foreach( HisData s in HisList)
            {
                tw.WriteLine(s.HisURL);
            }
            tw.Close();*/

        }

        public void LoadData()
        {/*
            List<string> tmp = System.IO.File.ReadLines(@".\Data\Files\History.txt").ToList();
            int count=1;
            File.WriteAllText(@".\Data\Files\History.txt", "");
            foreach (string s in tmp)
            {
                HisList.Add(item: new HisData() { NoHis = count, HisURL = s });
                count++;
            }
            // HisList = (HisData) tmp;*/
        }

        public object GetList()
        {
            LoadData();
            return HisList;
        }

    }
}
