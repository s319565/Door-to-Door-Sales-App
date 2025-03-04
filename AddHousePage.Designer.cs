﻿namespace Door_to_Door_Sales_App
{
    partial class AddHousePage
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHouseAddress = new System.Windows.Forms.TextBox();
            this.btnCreateNewHouse = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHouseNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 76);
            this.label1.TabIndex = 26;
            this.label1.Text = "Create New House Page";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 89);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(124, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter House Address: ";
            // 
            // txtHouseAddress
            // 
            this.txtHouseAddress.Location = new System.Drawing.Point(331, 149);
            this.txtHouseAddress.Name = "txtHouseAddress";
            this.txtHouseAddress.Size = new System.Drawing.Size(271, 20);
            this.txtHouseAddress.TabIndex = 28;
            // 
            // btnCreateNewHouse
            // 
            this.btnCreateNewHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateNewHouse.ForeColor = System.Drawing.Color.Red;
            this.btnCreateNewHouse.Location = new System.Drawing.Point(430, 216);
            this.btnCreateNewHouse.Name = "btnCreateNewHouse";
            this.btnCreateNewHouse.Size = new System.Drawing.Size(172, 33);
            this.btnCreateNewHouse.TabIndex = 29;
            this.btnCreateNewHouse.Text = "Create New House";
            this.btnCreateNewHouse.UseVisualStyleBackColor = true;
            this.btnCreateNewHouse.Click += new System.EventHandler(this.btnCreateNewHouse_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(12, 405);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(109, 33);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(124, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter House Notes: ";
            // 
            // txtHouseNotes
            // 
            this.txtHouseNotes.Location = new System.Drawing.Point(310, 189);
            this.txtHouseNotes.Name = "txtHouseNotes";
            this.txtHouseNotes.Size = new System.Drawing.Size(292, 20);
            this.txtHouseNotes.TabIndex = 32;
            // 
            // AddHousePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHouseNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreateNewHouse);
            this.Controls.Add(this.txtHouseAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddHousePage";
            this.Text = "AddHousePage";
            this.Load += new System.EventHandler(this.AddHousePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHouseAddress;
        private System.Windows.Forms.Button btnCreateNewHouse;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHouseNotes;
    }
}