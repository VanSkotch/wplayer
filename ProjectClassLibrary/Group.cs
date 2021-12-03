using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WinPlay
{
    [DataContract]
    [Serializable]
    public class Group
    {
        private String name;
        private List<String> titlesNames;

        [DataMember]
        public String Name
        {
            get { return name; }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value)) name = value;
                else throw new Exception("Enter group name!");
            }
        }

        [DataMember]
        public List<String> TitlesNames
        {
            get { return titlesNames; }
            private set { titlesNames = value; }
        }

        public Group(String name)
        {
            Name = name;
            TitlesNames = new List<String>();
        }

        public string GetGroup()
        {
            String info = "Group name: " + name;
            return info;
        }

        public void SetNewName(String newName)
        {
            Name = newName;
        }
    }
}