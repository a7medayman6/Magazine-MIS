namespace Magazino
{
     partial class Form3
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
               this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
               this.btnGenerateReport = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // crystalReportViewer1
               // 
               this.crystalReportViewer1.ActiveViewIndex = -1;
               this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
               this.crystalReportViewer1.Location = new System.Drawing.Point(22, 105);
               this.crystalReportViewer1.Name = "crystalReportViewer1";
               this.crystalReportViewer1.Size = new System.Drawing.Size(1004, 603);
               this.crystalReportViewer1.TabIndex = 15;
               // 
               // btnGenerateReport
               // 
               this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(124)))));
               this.btnGenerateReport.FlatAppearance.BorderSize = 0;
               this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.btnGenerateReport.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnGenerateReport.ForeColor = System.Drawing.Color.AliceBlue;
               this.btnGenerateReport.Location = new System.Drawing.Point(368, 32);
               this.btnGenerateReport.Name = "btnGenerateReport";
               this.btnGenerateReport.Size = new System.Drawing.Size(276, 48);
               this.btnGenerateReport.TabIndex = 14;
               this.btnGenerateReport.Text = "Show Report";
               this.btnGenerateReport.UseVisualStyleBackColor = false;
               this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::Magazino.Properties.Resources.power_button_off;
               this.pictureBox1.Location = new System.Drawing.Point(912, 32);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(96, 67);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 13;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
               // 
               // Form3
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1053, 741);
               this.Controls.Add(this.crystalReportViewer1);
               this.Controls.Add(this.btnGenerateReport);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Form3";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form3";
               this.Load += new System.EventHandler(this.Form3_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}