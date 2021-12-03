namespace WinPlay
{
    partial class FormTitle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.groupsBox = new System.Windows.Forms.ComboBox();
            this.addTitleButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.membersListBox = new System.Windows.Forms.CheckedListBox();
            this.titleNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Group:";
            // 
            // groupsBox
            // 
            this.groupsBox.FormattingEnabled = true;
            this.groupsBox.Location = new System.Drawing.Point(117, 192);
            this.groupsBox.Name = "groupsBox";
            this.groupsBox.Size = new System.Drawing.Size(121, 21);
            this.groupsBox.TabIndex = 66;
            // 
            // addTitleButton
            // 
            this.addTitleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTitleButton.Location = new System.Drawing.Point(118, 233);
            this.addTitleButton.Name = "addTitleButton";
            this.addTitleButton.Size = new System.Drawing.Size(100, 39);
            this.addTitleButton.TabIndex = 64;
            this.addTitleButton.Text = "Add Title";
            this.addTitleButton.UseVisualStyleBackColor = true;
            this.addTitleButton.Click += new System.EventHandler(this.addTitleButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "GroupMembers:";
            // 
            // membersListBox
            // 
            this.membersListBox.CheckOnClick = true;
            this.membersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membersListBox.FormattingEnabled = true;
            this.membersListBox.Location = new System.Drawing.Point(117, 79);
            this.membersListBox.Name = "membersListBox";
            this.membersListBox.Size = new System.Drawing.Size(196, 100);
            this.membersListBox.TabIndex = 63;
            // 
            // titleNameBox
            // 
            this.titleNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleNameBox.Location = new System.Drawing.Point(118, 38);
            this.titleNameBox.Name = "titleNameBox";
            this.titleNameBox.Size = new System.Drawing.Size(120, 21);
            this.titleNameBox.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(20, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Add Title";
            // 
            // FormTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 295);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupsBox);
            this.Controls.Add(this.addTitleButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.membersListBox);
            this.Controls.Add(this.titleNameBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Name = "FormTitle";
            this.Text = "Add Title";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        internal System.Windows.Forms.ComboBox groupsBox;
        private System.Windows.Forms.Button addTitleButton;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.CheckedListBox membersListBox;
        private System.Windows.Forms.TextBox titleNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}