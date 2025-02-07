namespace Door_to_Door_Sales_App
{
    partial class CreateNewRoutePage
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
            this.btnCreateRoute = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRouteNotes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateRoute
            // 
            this.btnCreateRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateRoute.ForeColor = System.Drawing.Color.Red;
            this.btnCreateRoute.Location = new System.Drawing.Point(523, 370);
            this.btnCreateRoute.Name = "btnCreateRoute";
            this.btnCreateRoute.Size = new System.Drawing.Size(126, 56);
            this.btnCreateRoute.TabIndex = 29;
            this.btnCreateRoute.Text = "Create Route";
            this.btnCreateRoute.UseVisualStyleBackColor = true;
            this.btnCreateRoute.Click += new System.EventHandler(this.btnCreateRoute_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label7.Location = new System.Drawing.Point(101, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 37);
            this.label7.TabIndex = 27;
            this.label7.Text = "Route Notes";
            // 
            // txtRouteName
            // 
            this.txtRouteName.Location = new System.Drawing.Point(301, 144);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.Size = new System.Drawing.Size(202, 20);
            this.txtRouteName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label6.Location = new System.Drawing.Point(90, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 37);
            this.label6.TabIndex = 25;
            this.label6.Text = "Route Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 76);
            this.label1.TabIndex = 24;
            this.label1.Text = "Create New Route Page";
            this.label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 89);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panelRouteNotes
            // 
            this.panelRouteNotes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelRouteNotes.Location = new System.Drawing.Point(111, 253);
            this.panelRouteNotes.Name = "panelRouteNotes";
            this.panelRouteNotes.Size = new System.Drawing.Size(553, 100);
            this.panelRouteNotes.TabIndex = 30;
            this.panelRouteNotes.UseWaitCursor = true;
            // 
            // CreateNewRoutePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRouteNotes);
            this.Controls.Add(this.btnCreateRoute);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRouteName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateNewRoutePage";
            this.Text = "CreateNewRoutePage";
            this.Load += new System.EventHandler(this.CreateNewRoutePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRoute;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRouteName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRouteNotes;
    }
}