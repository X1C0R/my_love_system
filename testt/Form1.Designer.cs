namespace testt
{
    partial class BBForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BBForm));
            this.CreateLabel = new System.Windows.Forms.Label();
            this.NewLabel = new System.Windows.Forms.Label();
            this.RecentlySavedLabel = new System.Windows.Forms.Label();
            this.HouseLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HelpBox = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.BackGroundPanel = new System.Windows.Forms.Panel();
            this.HouseButton = new System.Windows.Forms.Button();
            this.recentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.BackGroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.Location = new System.Drawing.Point(15, 68);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(75, 19);
            this.CreateLabel.TabIndex = 7;
            this.CreateLabel.Text = "Create";
            this.CreateLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // NewLabel
            // 
            this.NewLabel.AutoSize = true;
            this.NewLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLabel.Location = new System.Drawing.Point(56, 314);
            this.NewLabel.Name = "NewLabel";
            this.NewLabel.Size = new System.Drawing.Size(95, 15);
            this.NewLabel.TabIndex = 1;
            this.NewLabel.Text = "New Project";
            this.NewLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RecentlySavedLabel
            // 
            this.RecentlySavedLabel.AutoSize = true;
            this.RecentlySavedLabel.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentlySavedLabel.Location = new System.Drawing.Point(15, 347);
            this.RecentlySavedLabel.Name = "RecentlySavedLabel";
            this.RecentlySavedLabel.Size = new System.Drawing.Size(163, 19);
            this.RecentlySavedLabel.TabIndex = 4;
            this.RecentlySavedLabel.Text = "Recently Saved";
            this.RecentlySavedLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // HouseLabel
            // 
            this.HouseLabel.AutoSize = true;
            this.HouseLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseLabel.Location = new System.Drawing.Point(247, 313);
            this.HouseLabel.Name = "HouseLabel";
            this.HouseLabel.Size = new System.Drawing.Size(56, 13);
            this.HouseLabel.TabIndex = 3;
            this.HouseLabel.Text = "Housing";
            this.HouseLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LightSalmon;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 20;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.SeaShell;
            this.AddButton.Location = new System.Drawing.Point(26, 93);
            this.AddButton.Name = "AddButton";
            this.AddButton.Padding = new System.Windows.Forms.Padding(5);
            this.AddButton.Size = new System.Drawing.Size(153, 218);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+\r\n";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.AddButton.MouseHover += new System.EventHandler(this.AddButton_MouseHover);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Salmon;
            this.HeaderPanel.Controls.Add(this.HelpBox);
            this.HeaderPanel.Controls.Add(this.Title);
            this.HeaderPanel.Controls.Add(this.LogoBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(804, 59);
            this.HeaderPanel.TabIndex = 6;
            this.HeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // HelpBox
            // 
            this.HelpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HelpBox.BackColor = System.Drawing.Color.Transparent;
            this.HelpBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpBox.Image = global::testt.Properties.Resources.help_icon_42x42;
            this.HelpBox.InitialImage = global::testt.Properties.Resources.help_icon_42x42;
            this.HelpBox.Location = new System.Drawing.Point(769, 14);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(31, 31);
            this.HelpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HelpBox.TabIndex = 8;
            this.HelpBox.TabStop = false;
            this.HelpBox.Click += new System.EventHandler(this.HelpBox_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(75, 14);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(196, 31);
            this.Title.TabIndex = 5;
            this.Title.Text = "Budget Buddy";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            this.Title.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_Paint);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoBox.Image = global::testt.Properties.Resources.Budget_Buddy_Logo;
            this.LogoBox.InitialImage = global::testt.Properties.Resources.Budget_Buddy_Logo;
            this.LogoBox.Location = new System.Drawing.Point(3, -3);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(68, 70);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoBox.TabIndex = 7;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BackGroundPanel
            // 
            this.BackGroundPanel.BackColor = System.Drawing.Color.SeaShell;
            this.BackGroundPanel.Controls.Add(this.recentPanel);
            this.BackGroundPanel.Controls.Add(this.HeaderPanel);
            this.BackGroundPanel.Controls.Add(this.AddButton);
            this.BackGroundPanel.Controls.Add(this.HouseButton);
            this.BackGroundPanel.Controls.Add(this.HouseLabel);
            this.BackGroundPanel.Controls.Add(this.RecentlySavedLabel);
            this.BackGroundPanel.Controls.Add(this.NewLabel);
            this.BackGroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackGroundPanel.Name = "BackGroundPanel";
            this.BackGroundPanel.Size = new System.Drawing.Size(804, 662);
            this.BackGroundPanel.TabIndex = 6;
            this.BackGroundPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HeaderPanel_Paint);
            // 
            // HouseButton
            // 
            this.HouseButton.BackColor = System.Drawing.Color.LightSalmon;
            this.HouseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HouseButton.Image = global::testt.Properties.Resources.house_icon_21x21;
            this.HouseButton.Location = new System.Drawing.Point(199, 93);
            this.HouseButton.Name = "HouseButton";
            this.HouseButton.Size = new System.Drawing.Size(152, 218);
            this.HouseButton.TabIndex = 2;
            this.HouseButton.UseVisualStyleBackColor = false;
            this.HouseButton.Click += new System.EventHandler(this.HouseButton_Click);
            this.HouseButton.MouseEnter += new System.EventHandler(this.HouseButton_MouseEnter);
            this.HouseButton.MouseLeave += new System.EventHandler(this.HouseButton_MouseLeave);
            this.HouseButton.MouseHover += new System.EventHandler(this.HouseButton_MouseHover);
            // 
            // recentPanel
            // 
            this.recentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentPanel.Location = new System.Drawing.Point(0, 369);
            this.recentPanel.Name = "recentPanel";
            this.recentPanel.Size = new System.Drawing.Size(804, 293);
            this.recentPanel.TabIndex = 7;
            this.recentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.recentPanel_Paint);
            // 
            // BBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(804, 662);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.BackGroundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BBForm";
            this.Text = "Budget Buddy";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.BackGroundPanel.ResumeLayout(false);
            this.BackGroundPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Label NewLabel;
        private System.Windows.Forms.Label RecentlySavedLabel;
        private System.Windows.Forms.Label HouseLabel;
        private System.Windows.Forms.Button HouseButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Panel BackGroundPanel;
        private System.Windows.Forms.PictureBox HelpBox;
        private System.Windows.Forms.FlowLayoutPanel recentPanel;
    }
}

