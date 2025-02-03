namespace Door_to_Door_Sales_App
{
    partial class ViewRoutePage
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
            this.panelHouses = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.panelNotes = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHouses
            // 
            this.panelHouses.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHouses.Location = new System.Drawing.Point(109, 131);
            this.panelHouses.Name = "panelHouses";
            this.panelHouses.Size = new System.Drawing.Size(608, 140);
            this.panelHouses.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(122, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 76);
            this.label1.TabIndex = 19;
            this.label1.Text = "View Route Page";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 89);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtRouteName
            // 
            this.txtRouteName.Enabled = false;
            this.txtRouteName.Location = new System.Drawing.Point(134, 105);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(100, 20);
            this.txtRouteName.TabIndex = 20;
            this.txtRouteName.Text = "Route name";
            // 
            // panelNotes
            // 
            this.panelNotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelNotes.Location = new System.Drawing.Point(113, 324);
            this.panelNotes.Name = "panelNotes";
            this.panelNotes.Size = new System.Drawing.Size(604, 114);
            this.panelNotes.TabIndex = 21;
            this.panelNotes.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Route Notes";
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddHouse.ForeColor = System.Drawing.Color.Red;
            this.btnAddHouse.Location = new System.Drawing.Point(598, 276);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(109, 42);
            this.btnAddHouse.TabIndex = 23;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 396);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 42);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // ViewRoutePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelNotes);
            this.Controls.Add(this.txtRouteName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHouses);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewRoutePage";
            this.Text = "ViewRoutePage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHouses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Panel panelNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnBack;
    }
}