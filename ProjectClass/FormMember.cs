using System;
using System.Windows.Forms;

namespace WinPlay
{
    public partial class FormMember : Form
    {
        bool editingMode;

        public FormMember()
        {
            InitializeComponent();
            editingMode = false;
        }

        public FormMember(GroupMember member)
        {
            InitializeComponent();
            editingMode = true;
            addMemberButton.Text = "Save";
            Text = "Edit member";
            memberLNameBox.Text = member.LastName;
            memberFNameBox.Text = member.FirstName;
            memberPatronymBox.Text = member.Patronym;
            memberIDcodeBox.Text = member.IDcode;
            memberPositionBox.SelectedItem = member.Position;
        }

        private void MemberBoxClear()
        {
            memberFNameBox.Clear();
            memberPatronymBox.Clear();
            memberLNameBox.Clear();
            memberIDcodeBox.Clear();
            memberPositionBox.SelectedItem = null;
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            if (memberFNameBox.Text == "" || memberLNameBox.Text == "" || memberPatronymBox.Text == "" || memberIDcodeBox.Text == "" ||
                memberPositionBox.Text == "")
            {
                MessageBox.Show("All lines should be filled", "Error");
            }
            else
            {
                try
                {
                        WinPlay winPlay = (WinPlay)Owner;
                        if (editingMode)
                        {
                            int index = winPlay.membersList.SelectedIndex;
                            if (memberIDcodeBox.Text == Core.MemberList[index].IDcode)
                            {
                                Core.MemberList[index].LastName = memberLNameBox.Text;
                                Core.MemberList[index].FirstName = memberFNameBox.Text;
                                Core.MemberList[index].Patronym = memberPatronymBox.Text;
                                Core.MemberList[index].Position = memberPositionBox.Text;
                                winPlay.membersList.Items.RemoveAt(index);
                                winPlay.membersList.Items.Insert(index, Core.MemberList[index].GetFullName());
                                MemberBoxClear();
                                winPlay.membersList.SetSelected(index, false);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Member is already exists");
                            }
                        }
                        else
                        {
                            if (!Core.MemberExists(memberIDcodeBox.Text))
                            {
                                GroupMember member = new GroupMember(memberFNameBox.Text, memberLNameBox.Text, memberPatronymBox.Text, memberIDcodeBox.Text, memberPositionBox.Text);
                                Core.AddMember(member);
                                winPlay.membersList.Items.Add(member.GetFullName());
                                MemberBoxClear();
                            }
                            else
                            {
                                MessageBox.Show("Member is already exists");
                                MemberBoxClear();
                            }
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
