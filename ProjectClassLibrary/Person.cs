using System;
using System.Runtime.Serialization;

namespace WinPlay
{
    [DataContract]
    [Serializable]
    public abstract class Person
    {
        private String firstName;
        private String lastName;
        private String patronym;
        private String idCode;

        [DataMember]
        public String FirstName
        {
            get { return firstName; }
            set
            {
                foreach (Char c in value)
                {
                    if (!Char.IsLetter(c) && c != '\'' && c != '-') throw new Exception("Wrong characters(name)");
                }
                firstName = value;
            }
        }

        [DataMember]
        public String LastName
        {
            get { return lastName; }
            set
            {
                foreach (Char c in value)
                {
                    if (!Char.IsLetter(c) && c != '\'' && c != '-') throw new Exception("Wrong characters(Surname)");
                }
                lastName = value;
            }
        }

        [DataMember]
        public String Patronym
        {
            get { return patronym; }
            set
            {
                foreach (Char c in value)
                {
                    if (!Char.IsLetter(c) && c != '\'' && c != '-') throw new Exception("Wrong characters(Patronymic)");
                }
                patronym = value;
            }
        }

        [DataMember]
        public String IDcode
        {
            get { return idCode; }
            set
            {
                int numbers = 0;
                foreach(Char letter in value)
                {
                    if (Char.IsNumber(letter)) numbers++;
                }
                if (numbers == value.Length && value.Length == 10) idCode = value;
                else throw new Exception("Wrong identific code");
            }
        }

        public Person(String firstName, String lastName, String patronym, String idCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronym = patronym;
            IDcode = idCode;
        }

        public String GetFullName()
        {
            return LastName + " " + FirstName + " " + Patronym;
        }
    }
}