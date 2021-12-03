using System;
using System.Windows.Forms;

namespace WinPlay
{
    public partial class WinPlay : Form
    {
        public WinPlay()
        {
            InitializeComponent();
        }

        private void RefreshDataOnForm()
        {
            membersList.Items.Clear();
            foreach (GroupMember member in Core.MemberList)
            {
                membersList.Items.Add(member.GetFullName());
            }
            titlesList.Items.Clear();
            foreach (Title title in Core.TitleList)
            {
                if (!titlesList.Items.Contains(title.Name)) titlesList.Items.Add(title.Name);
            }
            groupsList.Items.Clear();
            foreach (Group group in Core.GroupList)
            {
                if (!groupsList.Items.Contains(group.Name)) groupsList.Items.Add(group.Name);
            }
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            if (membersList.SelectedItem != null)
            {
                FormMember formMember = new FormMember(Core.MemberList[membersList.SelectedIndex]);
                formMember.StartPosition = FormStartPosition.CenterParent;
                formMember.Owner = this;
                formMember.ShowDialog();
            }
            else MessageBox.Show("Choose member", "Error");
        }

        private void removeMemberButton_Click(object sender, EventArgs e)
        {
            if (membersList.SelectedItem != null)
            {
                Core.RemoveMember(Core.MemberList[membersList.SelectedIndex]);
                membersList.Items.RemoveAt(membersList.SelectedIndex);
            }
            else MessageBox.Show("Choose member", "Error");
        }

        private void editGroupButton_Click(object sender, EventArgs e)
        {
            if (groupsList.SelectedItem != null)
            {
                FormGroup formGroup = new FormGroup(Core.GroupList[groupsList.SelectedIndex]);
                formGroup.StartPosition = FormStartPosition.CenterParent;
                formGroup.Owner = this;
                formGroup.ShowDialog();
            }
            else MessageBox.Show("Choose group", "Error");
        }

        private void removeGroupButton_Click(object sender, EventArgs e)
        {
            if (groupsList.SelectedItem != null)
            {
                Core.RemoveGroup(Core.GetGroupByName(groupsList.SelectedItem.ToString()));
                groupsList.Items.Remove(groupsList.SelectedItem);
            }
            else MessageBox.Show("Choose group", "Error");
        }

        private void editTitleButton_Click(object sender, EventArgs e)
        {
            if (titlesList.SelectedItem != null)
            {
                FormTitle formTitle = new FormTitle(Core.TitleList[titlesList.SelectedIndex]);
                formTitle.StartPosition = FormStartPosition.CenterParent;
                formTitle.Owner = this;
                formTitle.ShowDialog();
            }
            else MessageBox.Show("Choose title", "Error");
        }

        private void removeTitleButton_Click(object sender, EventArgs e)
        {
            if (titlesList.SelectedItem != null)
            {
                int index = titlesList.SelectedIndex;
                titlesList.Items.RemoveAt(index);
                Core.RemoveTitle(Core.TitleList[index]);
            }
            else MessageBox.Show("Choose title", "Error");
        }

        private void addMemberMenuItem_Click(object sender, EventArgs e)
        {
            FormMember formMember = new FormMember();
            formMember.StartPosition = FormStartPosition.CenterParent;
            formMember.Owner = this;
            formMember.ShowDialog();
        }

        private void addGroupMenuItem_Click(object sender, EventArgs e)
        {
            FormGroup formGroup = new FormGroup();
            formGroup.StartPosition = FormStartPosition.CenterParent;
            formGroup.Owner = this;
            formGroup.ShowDialog();
        }

        private void addTitleMenuItem_Click(object sender, EventArgs e)
        {
            FormTitle formTitle = new FormTitle();
            formTitle.StartPosition = FormStartPosition.CenterParent;
            formTitle.Owner = this;
            formTitle.ShowDialog();
        }


        private void clearAllDataMenuItem_Click(object sender, EventArgs e)
        {
            Core.ClearAll();
            membersList.Items.Clear();
            titlesList.Items.Clear();
            groupsList.Items.Clear();
        }

        private void openFormSoundtrack_Click(object sender, EventArgs e)
        {
            FormSoundtrack formSoundtrack = new FormSoundtrack();
            formSoundtrack.StartPosition = FormStartPosition.CenterParent;
            formSoundtrack.Owner = this;
            formSoundtrack.ShowDialog();
        }
        private void WinPlay_Load(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String members = Environment.CurrentDirectory.ToString() + "\\Data\\XML\\Members.xml";
            String titles = Environment.CurrentDirectory.ToString() + "\\Data\\XML\\Titles.xml";
            String groups = Environment.CurrentDirectory.ToString() + "\\Data\\XML\\Groups.xml";
            Core.SaveAllDataInXML(members, titles, groups);
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String members = Environment.CurrentDirectory.ToString() + "\\Data\\XML\\Members.xml";
            String titles = Environment.CurrentDirectory.ToString() + "\\Data\\XML\\Titles.xml";
            String groups = Environment.CurrentDirectory.ToString() + "\\Data\\XML\\Groups.xml";
            Core.RestoreAllDataFromXML(members, titles, groups);
            RefreshDataOnForm();
        }

        private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String members = Environment.CurrentDirectory.ToString() + "\\Data\\JSON\\Members.json";
            String titles = Environment.CurrentDirectory.ToString() + "\\Data\\JSON\\Titles.json";
            String groups = Environment.CurrentDirectory.ToString() + "\\Data\\JSON\\Groups.json";
            Core.SaveAllDataInJSON(members, titles, groups);
        }

        private void jSONToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String members = Environment.CurrentDirectory.ToString() + "\\Data\\JSON\\Members.json";
            String titles = Environment.CurrentDirectory.ToString() + "\\Data\\JSON\\Titles.json";
            String groups = Environment.CurrentDirectory.ToString() + "\\Data\\JSON\\Groups.json";
            Core.RestoreAllDataFromJSON(members, titles, groups);
            RefreshDataOnForm();
        }
    }
}