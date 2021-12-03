namespace WinPlay
{
    partial class FormMember
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
            this.memberPositionBox = new System.Windows.Forms.ComboBox();
            this.memberIDcodeBox = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.memberPatronymBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.memberLNameBox = new System.Windows.Forms.TextBox();
            this.memberFNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberPositionBox
            // 
            this.memberPositionBox.ItemHeight = 13;
            this.memberPositionBox.Items.AddRange(new object[] {
            "Vocal",
            "Key",
            "Drums",
            "Guitar"});
            this.memberPositionBox.Location = new System.Drawing.Point(161, 181);
            this.memberPositionBox.Name = "memberPositionBox";
            this.memberPositionBox.Size = new System.Drawing.Size(120, 21);
            this.memberPositionBox.TabIndex = 55;
            // 
            // memberIDcodeBox
            // 
            this.memberIDcodeBox.Location = new System.Drawing.Point(161, 144);
            this.memberIDcodeBox.Mask = "0000000000";
            this.memberIDcodeBox.Name = "memberIDcodeBox";
            this.memberIDcodeBox.Size = new System.Drawing.Size(120, 20);
            this.memberIDcodeBox.TabIndex = 54;
            this.memberIDcodeBox.ValidatingType = typeof(int);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(37, 181);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 15);
            this.label18.TabIndex = 60;
            this.label18.Text = "Position:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(12, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 15);
            this.label17.TabIndex = 59;
            this.label17.Text = "Identific code:";
            // 
            // memberPatronymBox
            // 
            this.memberPatronymBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberPatronymBox.Location = new System.Drawing.Point(161, 110);
            this.memberPatronymBox.Name = "memberPatronymBox";
            this.memberPatronymBox.Size = new System.Drawing.Size(120, 21);
            this.memberPatronymBox.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(20, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 15);
            this.label16.TabIndex = 58;
            this.label16.Text = "Patronymic:";
            // 
            // addExecutorButton
            // 
            this.addMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMemberButton.Location = new System.Drawing.Point(102, 228);
            this.addMemberButton.Name = "addExecutorButton";
            this.addMemberButton.Size = new System.Drawing.Size(100, 40);
            this.addMemberButton.TabIndex = 57;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // memberLNameBox
            // 
            this.memberLNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberLNameBox.Location = new System.Drawing.Point(161, 38);
            this.memberLNameBox.Name = "memberLNameBox";
            this.memberLNameBox.Size = new System.Drawing.Size(120, 21);
            this.memberLNameBox.TabIndex = 50;
            // 
            // memberFNameBox
            // 
            this.memberFNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memberFNameBox.Location = new System.Drawing.Point(161, 74);
            this.memberFNameBox.Name = "memberFNameBox";
            this.memberFNameBox.Size = new System.Drawing.Size(120, 21);
            this.memberFNameBox.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Add Groupmember";
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 287);
            this.Controls.Add(this.memberPositionBox);
            this.Controls.Add(this.memberIDcodeBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.memberPatronymBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.memberLNameBox);
            this.Controls.Add(this.memberFNameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormMember";
            this.Text = "Add Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox memberPositionBox;
        private System.Windows.Forms.MaskedTextBox memberIDcodeBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox memberPatronymBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.TextBox memberLNameBox;
        private System.Windows.Forms.TextBox memberFNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}