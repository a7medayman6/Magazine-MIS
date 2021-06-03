
namespace Magazino
{
    partial class Home
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
            this.btnManagersInfo = new System.Windows.Forms.Button();
            this.btnEditionsInfo = new System.Windows.Forms.Button();
            this.btnCustomersInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManagersInfo
            // 
            this.btnManagersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnManagersInfo.FlatAppearance.BorderSize = 0;
            this.btnManagersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagersInfo.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagersInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnManagersInfo.Location = new System.Drawing.Point(34, 128);
            this.btnManagersInfo.Name = "btnManagersInfo";
            this.btnManagersInfo.Size = new System.Drawing.Size(315, 48);
            this.btnManagersInfo.TabIndex = 4;
            this.btnManagersInfo.Text = "Managers Information";
            this.btnManagersInfo.UseVisualStyleBackColor = false;
            this.btnManagersInfo.Click += new System.EventHandler(this.btnManagersInfo_Click);
            // 
            // btnEditionsInfo
            // 
            this.btnEditionsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnEditionsInfo.FlatAppearance.BorderSize = 0;
            this.btnEditionsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditionsInfo.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditionsInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEditionsInfo.Location = new System.Drawing.Point(34, 213);
            this.btnEditionsInfo.Name = "btnEditionsInfo";
            this.btnEditionsInfo.Size = new System.Drawing.Size(315, 48);
            this.btnEditionsInfo.TabIndex = 5;
            this.btnEditionsInfo.Text = "Editions Information";
            this.btnEditionsInfo.UseVisualStyleBackColor = false;
            this.btnEditionsInfo.Click += new System.EventHandler(this.btnEditionsInfo_Click);
            // 
            // btnCustomersInfo
            // 
            this.btnCustomersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
            this.btnCustomersInfo.FlatAppearance.BorderSize = 0;
            this.btnCustomersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomersInfo.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomersInfo.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnCustomersInfo.Location = new System.Drawing.Point(34, 297);
            this.btnCustomersInfo.Name = "btnCustomersInfo";
            this.btnCustomersInfo.Size = new System.Drawing.Size(315, 48);
            this.btnCustomersInfo.TabIndex = 6;
            this.btnCustomersInfo.Text = "Customers Information";
            this.btnCustomersInfo.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magazino.Properties.Resources.power_button_off;
            this.pictureBox1.Location = new System.Drawing.Point(304, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCustomersInfo);
            this.Controls.Add(this.btnEditionsInfo);
            this.Controls.Add(this.btnManagersInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManagersInfo;
        private System.Windows.Forms.Button btnEditionsInfo;
        private System.Windows.Forms.Button btnCustomersInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}