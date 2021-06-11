
namespace Magazino
{
    partial class Editions
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
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.textBox4 = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.cmb_edition = new System.Windows.Forms.ComboBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::Magazino.Properties.Resources.power_button_off;
               this.pictureBox1.Location = new System.Drawing.Point(281, 12);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(50, 42);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 5;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(46, 130);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(124, 17);
               this.label1.TabIndex = 7;
               this.label1.Text = "Edition Number:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(46, 287);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(0, 17);
               this.label2.TabIndex = 9;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(46, 270);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(219, 17);
               this.label3.TabIndex = 11;
               this.label3.Text = "Total Number Of Subscribers";
               // 
               // textBox3
               // 
               this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox3.Location = new System.Drawing.Point(48, 307);
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(134, 22);
               this.textBox3.TabIndex = 10;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(46, 347);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(89, 17);
               this.label4.TabIndex = 13;
               this.label4.Text = "Total Profit";
               // 
               // textBox4
               // 
               this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox4.Location = new System.Drawing.Point(48, 379);
               this.textBox4.Name = "textBox4";
               this.textBox4.Size = new System.Drawing.Size(134, 22);
               this.textBox4.TabIndex = 12;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.Teal;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
               this.button1.Location = new System.Drawing.Point(216, 173);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(91, 29);
               this.button1.TabIndex = 14;
               this.button1.Text = "Display";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // cmb_edition
               // 
               this.cmb_edition.FormattingEnabled = true;
               this.cmb_edition.Location = new System.Drawing.Point(186, 127);
               this.cmb_edition.Name = "cmb_edition";
               this.cmb_edition.Size = new System.Drawing.Size(121, 24);
               this.cmb_edition.TabIndex = 15;
               // 
               // Editions
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(341, 527);
               this.Controls.Add(this.cmb_edition);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.textBox4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.pictureBox1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Editions";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Editions";
               this.Load += new System.EventHandler(this.Editions_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_edition;
    }
}