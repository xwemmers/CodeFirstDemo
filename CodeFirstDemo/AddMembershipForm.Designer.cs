namespace CodeFirstDemo
{
    partial class AddMembershipForm
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
            this.lbxPeople = new System.Windows.Forms.ListBox();
            this.lbxTeams = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxPeople
            // 
            this.lbxPeople.FormattingEnabled = true;
            this.lbxPeople.Location = new System.Drawing.Point(32, 53);
            this.lbxPeople.Name = "lbxPeople";
            this.lbxPeople.Size = new System.Drawing.Size(181, 264);
            this.lbxPeople.TabIndex = 0;
            // 
            // lbxTeams
            // 
            this.lbxTeams.FormattingEnabled = true;
            this.lbxTeams.Location = new System.Drawing.Point(282, 53);
            this.lbxTeams.Name = "lbxTeams";
            this.lbxTeams.Size = new System.Drawing.Size(193, 264);
            this.lbxTeams.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Voeg persoon aan team toe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            // 
            // AddMembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxTeams);
            this.Controls.Add(this.lbxPeople);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddMembershipForm";
            this.Text = "AddMembership";
            this.Load += new System.EventHandler(this.AddMembershipForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPeople;
        private System.Windows.Forms.ListBox lbxTeams;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}