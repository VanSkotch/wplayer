using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace WinPlay
{
    public class JSONSerialisable
    {
        public void SaveData<T>(List<T> data, String filePath)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T[]));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, data.ToArray());
            }
        }

        public List<T> RestoreData<T>(String filePath)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T[]));
            List<T> restoredData = new List<T>();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                T[] data = (T[])jsonFormatter.ReadObject(fs);
                restoredData.AddRange(data);
            }
            return restoredData;
        }
    }
}