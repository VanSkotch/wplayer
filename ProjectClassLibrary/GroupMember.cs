using System;
using System.Runtime.Serialization;

namespace WinPlay
{
    [DataContract]
    [Serializable]
    public class GroupMember : Member
    {
        private Guid groupID;
        [DataMember]
        public Guid GroupID
        {
            get { return groupID; }
            private set { groupID = value; }
        }

        [DataMember]
        public override String Position
        {
            get { return base.Position; }
            set
            {
                if (value != "Vocal" && value != "Key" && value != "Drums" && value != "Guitar")
                    throw new Exception("Wrong position");
                else base.Position = value;
            }
        }


        public string GetMemberGeneralInfo()
        {
            String info = "Name: " + GetFullName() + " ID Code: " + IDcode + " Position: " + Position;
            return info;
        }

        public GroupMember(String firstName, String lastName, String patronym, String idCode, String position) : base(firstName, lastName, patronym, idCode, position)
        {
            GroupID = Guid.NewGuid();
        }

        public GroupMember(String firstName, String lastName, String patronym, String idCode, String position, Guid companyID) : base(firstName, lastName, patronym, idCode, position)
        {
            GroupID = companyID;
        }
    }
}