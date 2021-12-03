using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinPlay
{
    public partial class FormTitle : Form
    {
        bool editingMode;

        public FormTitle()
        {
            InitializeComponent();
            editingMode = false;
            foreach(GroupMember member in Core.MemberList)
            {
                membersListBox.Items.Add(member.GetFullName());
            }
            foreach(Group group in Core.GroupList)
            {
                groupsBox.Items.Add(group.Name);
            }
        }

        public FormTitle(Title title) : this()
        {
            editingMode = true;
            addTitleButton.Text = "Save";
            Text = "Edit Title";
            titleNameBox.Text = title.Name;
            groupsBox.SelectedItem = Core.GetTitleGroup(Core.GetTitleByName(title.Name));
            groupsBox.SelectedItem = Core.GetTitleGroup(title);
            foreach (String memberIDCode in title.MembersIDCodes)
            {
                membersListBox.SetItemChecked(Core.MemberList.IndexOf(Core.GetMemberByID(memberIDCode)), true);
            }
        }

        private void TitleBoxClear()
        {
            titleNameBox.Clear();
            for (int i = 0; i < membersListBox.Items.Count; i++)
            {
                if (membersListBox.GetItemChecked(i)) membersListBox.SetItemChecked(i, false);
            }
            if (membersListBox.SelectedIndex >= 0) membersListBox.SetSelected(membersListBox.SelectedIndex, false);
            groupsBox.SelectedItem = null;
        }

        private void addTitleButton_Click(object sender, EventArgs e)
        {
            if (titleNameBox.Text == "") MessageBox.Show("Error");
            else
            {
                try
                {
                    WinPlay winPlay = (WinPlay)Owner;
                    int index = winPlay.titlesList.SelectedIndex;
                    if (editingMode)
                    {
                        if (titleNameBox.Text == Core.TitleList[index].Name || !Core.TitleExists(titleNameBox.Text))
                        {
                            Core.TitleList[index].SetNewName(titleNameBox.Text);
                            if (groupsBox.Text != "" && !Core.GetGroupByName(groupsBox.Text).TitlesNames.Contains(Core.TitleList[index].Name))
                                Core.GetGroupByName(groupsBox.Text).TitlesNames.Add(Core.TitleList[index].Name);
                            Core.TitleList[index].MembersIDCodes.Clear();
                            foreach (int position in membersListBox.CheckedIndices)
                            {
                                Core.TitleList[index].MembersIDCodes.Add(Core.MemberList[position].IDcode);
                            }
                            winPlay.titlesList.Items.RemoveAt(index);
                            winPlay.titlesList.Items.Insert(index, Core.TitleList[index].Name);
                            TitleBoxClear();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Title name is already taken");
                        }
                    }
                    else
                    {
                        if (Core.TitleExists(titleNameBox.Text)) MessageBox.Show("Title name is already taken");
                        else
                        {
                            List<GroupMember> checkedMembers = new List<GroupMember>();
                            foreach (int checkedIndex in membersListBox.CheckedIndices)
                            {
                                checkedMembers.Add(Core.MemberList[checkedIndex]);
                            }
                            Title title = new Title(titleNameBox.Text);
                            Core.AddTitle(title, checkedMembers.ToArray());
                            if (groupsBox.Text != "") Core.GetGroupByName(groupsBox.Text).TitlesNames.Add(title.Name);
                            winPlay.titlesList.Items.Add(title.Name);
                            TitleBoxClear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка");
                }
            }
        }
    }
}
