using System;
using System.Windows.Forms;

namespace WinPlay
{
    public partial class FormGroup : Form
    {
        bool editingMode;

        public FormGroup()
        {
            InitializeComponent();
            editingMode = false;
        }

        public FormGroup(Group group)
        {
            InitializeComponent();
            editingMode = true;
            addGroupButton.Text = "Save";
            Text = "Edit Group";
            groupNameBox.Text = group.Name;
        }

        private void GroupBoxClear()
        {
            groupNameBox.Clear();
        }

        private void addGroupButton_Click(object sender, EventArgs e)
        {
            if (groupNameBox.Text == "") MessageBox.Show("Error");
            else
            {
                try
                {
                    WinPlay winPlay = (WinPlay)Owner;
                    if (editingMode)
                    {
                        int index = winPlay.groupsList.SelectedIndex;
                        if (groupNameBox.Text == Core.GroupList[index].Name || !Core.GroupExists(groupNameBox.Text))
                        {
                            Core.GroupList[index].SetNewName(groupNameBox.Text);
                            winPlay.groupsList.Items.RemoveAt(index);
                            winPlay.groupsList.Items.Insert(index, Core.GroupList[index].Name);
                            GroupBoxClear();
                            Close();
                        }
                    }
                    else
                    {
                        if (Core.GroupExists(groupNameBox.Text)) MessageBox.Show("Group name is already taken");
                        else
                        {
                            Group group = new Group(groupNameBox.Text);
                            Core.AddGroup(group);
                            winPlay.groupsList.Items.Add(group.Name);
                            GroupBoxClear();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }
    }
}
