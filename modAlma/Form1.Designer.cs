
namespace modAlma
{
    partial class Form1
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
            this.Hesapla = new System.Windows.Forms.Button();
            this.Sayı = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Hesapla
            // 
            this.Hesapla.Location = new System.Drawing.Point(170, 14);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(75, 23);
            this.Hesapla.TabIndex = 0;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = true;
            this.Hesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sayı
            // 
            this.Sayı.AutoSize = true;
            this.Sayı.Location = new System.Drawing.Point(12, 20);
            this.Sayı.Name = "Sayı";
            this.Sayı.Size = new System.Drawing.Size(27, 13);
            this.Sayı.TabIndex = 1;
            this.Sayı.Text = "Sayi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "0";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(247, 171);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 239);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sayı);
            this.Controls.Add(this.Hesapla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mod Alma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label Sayı;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

