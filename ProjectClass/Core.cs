using System;
using System.Collections.Generic;

namespace WinPlay
{
    public static class Core
    {
        private static List<GroupMember> memberList = new List<GroupMember>();
        private static List<Title> titleList = new List<Title>();
        private static List<Group> groupList = new List<Group>();

        public static List<GroupMember> MemberList
        {
            get { return memberList; }
        }

        public static List<Title> TitleList
        {
            get { return titleList; }
        }

        public static List<Group> GroupList
        {
            get { return groupList; }
        }

        public static void ClearAll()
        {
            memberList.Clear();
            titleList.Clear();
            groupList.Clear();
        }

        public static GroupMember GetMemberByID(String memberIDCode)
        {
            if (MemberExists(memberIDCode))
            {
                foreach (GroupMember member in MemberList)
                {
                    if (member.IDcode == memberIDCode) return member;
                }
            }
            return null;
        }

        public static Title GetTitleByName(String titletName)
        {
            if (TitleExists(titletName))
            {
                foreach (Title title in TitleList)
                {
                    if (title.Name == titletName) return title;
                }
            }
            return null;
        }

        public static Group GetGroupByName(String groupName)
        {
            if (GroupExists(groupName))
            {
                foreach (Group group in GroupList)
                {
                    if (group.Name == groupName) return group;
                }
            }
            return null;
        }

        public static String GetTitleGroup(Title title)
        {
            String titleGroup = "";
            foreach (Group group in GroupList)
            {
                if (group.TitlesNames.Contains(title.Name))
                {
                    titleGroup += "Group " + group.Name;
                    break;
                }
            }
            if (titleGroup == "") titleGroup = "Group was't added";
            return titleGroup;
        }

        public static bool MemberExists(String idCode)
        {
            foreach (GroupMember member in MemberList)
            {
                if (member.IDcode == idCode)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddMember(GroupMember member)
        {
            if (!MemberExists(member.IDcode))
            {
                MemberList.Add(member);
            }
            else throw new Exception("This member is already exists");
        }

        public static void RemoveMember(GroupMember member)
        {
            if (MemberList.Contains(member))
            {
                foreach (Title title in TitleList)
                {
                    if (title.MembersIDCodes.Contains(member.IDcode)) title.MembersIDCodes.Remove(member.IDcode);
                }
                MemberList.Remove(member);
            }
        }

        public static bool TitleExists(String titleName)
        {
            foreach (Title title in TitleList)
            {
                if (title.Name == titleName) return true;
            }
            return false;
        }

        public static void AddTitle(Title title, params GroupMember[] members)
        {
            if (!TitleExists(title.Name))
            {
                TitleList.Add(title);
                foreach (GroupMember member in members)
                {
                    if (!title.MembersIDCodes.Contains(member.IDcode)) title.MembersIDCodes.Add(member.IDcode);
                }
            }
            else throw new Exception("Title name is already taken");
        }

        public static void RemoveTitle(Title title)
        {
            foreach (Group group in GroupList)
            {
                group.TitlesNames.Remove(title.Name);
            }
            TitleList.Remove(title);
        }

        public static bool GroupExists(String groupName)
        {
            foreach (Group group in GroupList)
            {
                if (group.Name == groupName) return true;
            }
            return false;
        }

        public static void AddGroup(Group group)
        {
            if (!GroupExists(group.Name))
            {
                GroupList.Add(group);
            }
            else throw new Exception("Group name is already taken");
        }

        public static void RemoveGroup(Group group)
        {
            GroupList.Remove(group);
        }
        public static void SaveAllDataInJSON(String members, String titles, String groups)
        {
            JSONSerialisable jsonSaver = new JSONSerialisable();
            jsonSaver.SaveData(MemberList, members);
            jsonSaver.SaveData(TitleList, titles);
            jsonSaver.SaveData(GroupList, groups);
        }

        public static void RestoreAllDataFromJSON(String members, String titles, String groups)
        {
            JSONSerialisable jsonRestorer = new JSONSerialisable();
            List<GroupMember> restoredMembers = jsonRestorer.RestoreData<GroupMember>(members);
            foreach (GroupMember member in restoredMembers)
            {
                AddMember(member);
            }
            List<Title> restoredTitles = jsonRestorer.RestoreData<Title>(titles);
            foreach (Title title in restoredTitles)
            {
                AddTitle(title);
            }
            List<Group> restoredGroups = jsonRestorer.RestoreData<Group>(groups);
            foreach (Group group in restoredGroups)
            {
                AddGroup(group);
            }
        }

        public static void SaveAllDataInXML(String members, String titles, String groups)
        {
            XMLSerialisable xmlSaver = new XMLSerialisable();
            xmlSaver.SaveData(MemberList, members);
            xmlSaver.SaveData(TitleList, titles);
            xmlSaver.SaveData(GroupList, groups);
        }

        public static void RestoreAllDataFromXML(String members, String titles, String groups)
        {
            XMLSerialisable xmlRestorer = new XMLSerialisable();
            foreach (GroupMember member in xmlRestorer.RestoreData<GroupMember>(members))
            {
                if (!MemberExists(member.IDcode)) AddMember(member);
            }
            foreach (Title title in xmlRestorer.RestoreData<Title>(titles))
            {
                if (!TitleExists(title.Name)) AddTitle(title);
            }
            foreach (Group group in xmlRestorer.RestoreData<Group>(groups))
            {
                if (!GroupExists(group.Name)) AddGroup(group);
            }
        }

        public static void SaveAllDataInBinary(String members, String titles, String groups)
        {
            BinarySerialisable binarySaver = new BinarySerialisable();
            binarySaver.SaveData(MemberList, members);
            binarySaver.SaveData(TitleList, titles);
            binarySaver.SaveData(GroupList, groups);
        }

        public static void RestoreAllDataFromBinary(String members, String titles, String groups)
        {
            BinarySerialisable xmlRestorer = new BinarySerialisable();
            foreach (GroupMember member in xmlRestorer.RestoreData<GroupMember>(members))
            {
                if (!MemberExists(member.IDcode)) AddMember(member);
            }
            foreach (Title title in xmlRestorer.RestoreData<Title>(titles))
            {
                if (!TitleExists(title.Name)) AddTitle(title);
            }
            foreach (Group group in xmlRestorer.RestoreData<Group>(groups))
            {
                if (!GroupExists(group.Name)) AddGroup(group);
            }
        }
    }
}