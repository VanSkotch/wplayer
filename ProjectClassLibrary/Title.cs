using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WinPlay
{
    [DataContract]
    [Serializable]
    public class Title 
    {
        private String name;
        private List<String> membersIDCodes;

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
        public List<String> MembersIDCodes
        {
            get { return membersIDCodes; }
            private set { membersIDCodes = value; }
        }

        public Title(String name)
        {
            Name = name;
            MembersIDCodes = new List<String>();
        }

        public string GetTitle()
        {
            String info = "Title name: " + name;
            return info;
        }

        public void SetNewName(String newName)
        {
            Name = newName;
        }
    }
}