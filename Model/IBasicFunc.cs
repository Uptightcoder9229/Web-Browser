using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW1_IP.Model
{
    interface IBasicFunc
    {
        void SaveData();                                  //Used to save data Json File

        void LoadData();                                  //Used to Load data to Excel File


        bool AddTo(string name, string url);               //to remove Favriotes or History

        bool RemoveFrom(string name);                         //to remove Favriotes or History
    }
}

