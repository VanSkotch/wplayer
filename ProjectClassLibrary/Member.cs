using System;
using System.Runtime.Serialization;

namespace WinPlay
{
    [DataContract]
    [Serializable]
    public abstract class Member : Person
    {
        private String position;

        [DataMember]
        public virtual String Position
        {
            get { return position; }
            set { position = value; }
        }

        public Member(String firstName, String lastName, String patronym, String idCode, String position) : base(firstName, lastName, patronym, idCode)
        {
            Position = position;
        }
    }
}