namespace testt
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.Title = new System.Windows.Forms.Label();
            this.Question1 = new System.Windows.Forms.Label();
            this.Information1 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Transparent;
            this.Title.Location = new System.Drawing.Point(262, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(177, 32);
            this.Title.TabIndex = 6;
            this.Title.Text = "Budget Buddy";
            this.Title.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_Paint);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // Question1
            // 
            this.Question1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Lucida Console", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(244, 66);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(217, 15);
            this.Question1.TabIndex = 7;
            this.Question1.Text = "What is Budget Buddy?";
            this.Question1.Click += new System.EventHandler(this.Question1_Click);
            // 
            // Information1
            // 
            this.Information1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Information1.AutoSize = true;
            this.Information1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information1.Location = new System.Drawing.Point(60, 91);
            this.Information1.Name = "Information1";
            this.Information1.Size = new System.Drawing.Size(602, 39);
            this.Information1.TabIndex = 8;
            this.Information1.Text = resources.GetString("Information1.Text");
            this.Information1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Information1.Click += new System.EventHandler(this.Information1_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeaderPanel.BackColor = System.Drawing.Color.Salmon;
            this.HeaderPanel.Controls.Add(this.Title);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(737, 54);
            this.HeaderPanel.TabIndex = 9;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(731, 334);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.Information1);
            this.Controls.Add(this.Question1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.Text = "Help";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Label Information1;
        private System.Windows.Forms.Panel HeaderPanel;
    }
}