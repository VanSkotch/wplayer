using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace WinPlay
{
    public class XMLSerialisable
    {
        public void SaveData<T>(List<T> data, String filePath)
        {
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(T[]));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                xmlFormatter.WriteObject(fs, data.ToArray());
            }
        }

        public List<T> RestoreData<T>(String filePath)
        {
            DataContractSerializer xmlFormatter = new DataContractSerializer(typeof(T[]));
            List<T> restoredData = new List<T>();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                T[] data = (T[])xmlFormatter.ReadObject(fs);
                restoredData.AddRange(data);
            }
            return restoredData;
        }
    }
}