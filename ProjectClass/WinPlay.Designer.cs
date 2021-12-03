namespace WinPlay
{
    partial class WinPlay
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExecutorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAssignmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.membersList = new System.Windows.Forms.ListBox();
            this.titlesList = new System.Windows.Forms.ListBox();
            this.groupsList = new System.Windows.Forms.ListBox();
            this.removeExecutorButton = new System.Windows.Forms.Button();
            this.editExecutorButton = new System.Windows.Forms.Button();
            this.editAssignmentButton = new System.Windows.Forms.Button();
            this.removeAssignmentButton = new System.Windows.Forms.Button();
            this.editProjectButton = new System.Windows.Forms.Button();
            this.removeProjectButton = new System.Windows.Forms.Button();
            this.openFormSoundtrack = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExecutorMenuItem,
            this.addProjectMenuItem,
            this.addAssignmentMenuItem,
            this.clearAllDataMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ToolStripMenuItem.Text = "Menu";
            // 
            // addExecutorMenuItem
            // 
            this.addExecutorMenuItem.Name = "addExecutorMenuItem";
            this.addExecutorMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addExecutorMenuItem.Text = "Add Member";
            this.addExecutorMenuItem.Click += new System.EventHandler(this.addMemberMenuItem_Click);
            // 
            // addProjectMenuItem
            // 
            this.addProjectMenuItem.Name = "addProjectMenuItem";
            this.addProjectMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addProjectMenuItem.Text = "Add Group";
            this.addProjectMenuItem.Click += new System.EventHandler(this.addGroupMenuItem_Click);
            // 
            // addAssignmentMenuItem
            // 
            this.addAssignmentMenuItem.Name = "addAssignmentMenuItem";
            this.addAssignmentMenuItem.Size = new System.Drawing.Size(144, 22);
            this.addAssignmentMenuItem.Text = "Add Title";
            this.addAssignmentMenuItem.Click += new System.EventHandler(this.addTitleMenuItem_Click);
            // 
            // clearAllDataMenuItem
            // 
            this.clearAllDataMenuItem.Name = "clearAllDataMenuItem";
            this.clearAllDataMenuItem.Size = new System.Drawing.Size(144, 22);
            this.clearAllDataMenuItem.Text = "Clean All";
            this.clearAllDataMenuItem.Click += new System.EventHandler(this.clearAllDataMenuItem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(70, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Members List";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(324, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Groups List";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(576, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 24;
            this.label14.Text = "Titles List";
            // 
            // membersList
            // 
            this.membersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.membersList.FormattingEnabled = true;
            this.membersList.HorizontalScrollbar = true;
            this.membersList.ItemHeight = 15;
            this.membersList.Location = new System.Drawing.Point(24, 74);
            this.membersList.Name = "membersList";
            this.membersList.Size = new System.Drawing.Size(207, 124);
            this.membersList.TabIndex = 25;
            // 
            // titlesList
            // 
            this.titlesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titlesList.FormattingEnabled = true;
            this.titlesList.HorizontalScrollbar = true;
            this.titlesList.ItemHeight = 15;
            this.titlesList.Location = new System.Drawing.Point(510, 74);
            this.titlesList.Name = "titlesList";
            this.titlesList.Size = new System.Drawing.Size(207, 124);
            this.titlesList.TabIndex = 26;
            // 
            // groupsList
            // 
            this.groupsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupsList.FormattingEnabled = true;
            this.groupsList.HorizontalScrollbar = true;
            this.groupsList.ItemHeight = 15;
            this.groupsList.Location = new System.Drawing.Point(266, 74);
            this.groupsList.Name = "groupsList";
            this.groupsList.Size = new System.Drawing.Size(207, 124);
            this.groupsList.TabIndex = 27;
            // 
            // removeExecutorButton
            // 
            this.removeExecutorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeExecutorButton.Location = new System.Drawing.Point(131, 211);
            this.removeExecutorButton.Name = "removeExecutorButton";
            this.removeExecutorButton.Size = new System.Drawing.Size(100, 40);
            this.removeExecutorButton.TabIndex = 34;
            this.removeExecutorButton.Text = "Delete";
            this.removeExecutorButton.UseVisualStyleBackColor = true;
            this.removeExecutorButton.Click += new System.EventHandler(this.removeMemberButton_Click);
            // 
            // editExecutorButton
            // 
            this.editExecutorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editExecutorButton.Location = new System.Drawing.Point(24, 211);
            this.editExecutorButton.Name = "editExecutorButton";
            this.editExecutorButton.Size = new System.Drawing.Size(100, 40);
            this.editExecutorButton.TabIndex = 35;
            this.editExecutorButton.Text = "Edit";
            this.editExecutorButton.UseVisualStyleBackColor = true;
            this.editExecutorButton.Click += new System.EventHandler(this.editMemberButton_Click);
            // 
            // editAssignmentButton
            // 
            this.editAssignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editAssignmentButton.Location = new System.Drawing.Point(510, 211);
            this.editAssignmentButton.Name = "editAssignmentButton";
            this.editAssignmentButton.Size = new System.Drawing.Size(100, 40);
            this.editAssignmentButton.TabIndex = 36;
            this.editAssignmentButton.Text = "Edit";
            this.editAssignmentButton.UseVisualStyleBackColor = true;
            this.editAssignmentButton.Click += new System.EventHandler(this.editTitleButton_Click);
            // 
            // removeAssignmentButton
            // 
            this.removeAssignmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeAssignmentButton.Location = new System.Drawing.Point(617, 211);
            this.removeAssignmentButton.Name = "removeAssignmentButton";
            this.removeAssignmentButton.Size = new System.Drawing.Size(100, 40);
            this.removeAssignmentButton.TabIndex = 37;
            this.removeAssignmentButton.Text = "Delete";
            this.removeAssignmentButton.UseVisualStyleBackColor = true;
            this.removeAssignmentButton.Click += new System.EventHandler(this.removeTitleButton_Click);
            // 
            // editProjectButton
            // 
            this.editProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProjectButton.Location = new System.Drawing.Point(266, 211);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(100, 40);
            this.editProjectButton.TabIndex = 38;
            this.editProjectButton.Text = "Edit";
            this.editProjectButton.UseVisualStyleBackColor = true;
            this.editProjectButton.Click += new System.EventHandler(this.editGroupButton_Click);
            // 
            // removeProjectButton
            // 
            this.removeProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeProjectButton.Location = new System.Drawing.Point(372, 211);
            this.removeProjectButton.Name = "removeProjectButton";
            this.removeProjectButton.Size = new System.Drawing.Size(100, 40);
            this.removeProjectButton.TabIndex = 39;
            this.removeProjectButton.Text = "Delete";
            this.removeProjectButton.UseVisualStyleBackColor = true;
            this.removeProjectButton.Click += new System.EventHandler(this.removeGroupButton_Click);
            // 
            // openFormSoundtrack
            // 
            this.openFormSoundtrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFormSoundtrack.Location = new System.Drawing.Point(652, 275);
            this.openFormSoundtrack.Name = "openFormSoundtrack";
            this.openFormSoundtrack.Size = new System.Drawing.Size(129, 57);
            this.openFormSoundtrack.TabIndex = 48;
            this.openFormSoundtrack.Text = "Player";
            this.openFormSoundtrack.UseVisualStyleBackColor = true;
            this.openFormSoundtrack.Click += new System.EventHandler(this.openFormSoundtrack_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.jSONToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            this.jSONToolStripMenuItem.Click += new System.EventHandler(this.jSONToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jSONToolStripMenuItem1.Text = "JSON";
            this.jSONToolStripMenuItem1.Click += new System.EventHandler(this.jSONToolStripMenuItem1_Click);
            // 
            // WinPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 360);
            this.Controls.Add(this.openFormSoundtrack);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.removeProjectButton);
            this.Controls.Add(this.editProjectButton);
            this.Controls.Add(this.removeAssignmentButton);
            this.Controls.Add(this.editAssignmentButton);
            this.Controls.Add(this.editExecutorButton);
            this.Controls.Add(this.removeExecutorButton);
            this.Controls.Add(this.groupsList);
            this.Controls.Add(this.titlesList);
            this.Controls.Add(this.membersList);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "WinPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinPlay";
            this.Load += new System.EventHandler(this.WinPlay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button removeExecutorButton;
        private System.Windows.Forms.Button editExecutorButton;
        private System.Windows.Forms.Button editAssignmentButton;
        private System.Windows.Forms.Button removeAssignmentButton;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.Button removeProjectButton;
        private System.Windows.Forms.ToolStripMenuItem addExecutorMenuItem;
        internal System.Windows.Forms.ListBox membersList;
        private System.Windows.Forms.ToolStripMenuItem addProjectMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAssignmentMenuItem;
        internal System.Windows.Forms.ListBox groupsList;
        internal System.Windows.Forms.ListBox titlesList;
        private System.Windows.Forms.ToolStripMenuItem clearAllDataMenuItem;
        private System.Windows.Forms.Button openFormSoundtrack;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
    }
}

