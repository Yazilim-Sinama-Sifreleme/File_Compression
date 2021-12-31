
namespace yazılımsınamadeneme2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textDosyaYolu = new System.Windows.Forms.TextBox();
            this.rbsifrelemek = new System.Windows.Forms.RadioButton();
            this.textSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.rbsifrecözme = new System.Windows.Forms.RadioButton();
            this.rbsifrele = new System.Windows.Forms.CheckBox();
            this.DosyaRarla = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DosyaYolu";
            // 
            // textDosyaYolu
            // 
            this.textDosyaYolu.Location = new System.Drawing.Point(138, 45);
            this.textDosyaYolu.Name = "textDosyaYolu";
            this.textDosyaYolu.Size = new System.Drawing.Size(246, 22);
            this.textDosyaYolu.TabIndex = 2;
            this.textDosyaYolu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textDosyaYolu_MouseDoubleClick);
            // 
            // rbsifrelemek
            // 
            this.rbsifrelemek.AutoSize = true;
            this.rbsifrelemek.Location = new System.Drawing.Point(126, 216);
            this.rbsifrelemek.Name = "rbsifrelemek";
            this.rbsifrelemek.Size = new System.Drawing.Size(95, 21);
            this.rbsifrelemek.TabIndex = 3;
            this.rbsifrelemek.TabStop = true;
            this.rbsifrelemek.Text = "Şifrelemek";
            this.rbsifrelemek.UseVisualStyleBackColor = true;
            // 
            // textSifre
            // 
            this.textSifre.Location = new System.Drawing.Point(138, 159);
            this.textSifre.Name = "textSifre";
            this.textSifre.PasswordChar = '*';
            this.textSifre.Size = new System.Drawing.Size(246, 22);
            this.textSifre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "SİFRE";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(138, 258);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(240, 52);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // rbsifrecözme
            // 
            this.rbsifrecözme.AutoSize = true;
            this.rbsifrecözme.Location = new System.Drawing.Point(275, 216);
            this.rbsifrecözme.Name = "rbsifrecözme";
            this.rbsifrecözme.Size = new System.Drawing.Size(109, 21);
            this.rbsifrecözme.TabIndex = 7;
            this.rbsifrecözme.TabStop = true;
            this.rbsifrecözme.Text = "Şifreyiçözme";
            this.rbsifrecözme.UseVisualStyleBackColor = true;
            // 
            // rbsifrele
            // 
            this.rbsifrele.AutoSize = true;
            this.rbsifrele.Location = new System.Drawing.Point(138, 103);
            this.rbsifrele.Name = "rbsifrele";
            this.rbsifrele.Size = new System.Drawing.Size(70, 21);
            this.rbsifrele.TabIndex = 8;
            this.rbsifrele.Text = "Sifrele";
            this.rbsifrele.UseVisualStyleBackColor = true;
            this.rbsifrele.CheckedChanged += new System.EventHandler(this.rbsifrele_CheckedChanged);
            // 
            // DosyaRarla
            // 
            this.DosyaRarla.AutoSize = true;
            this.DosyaRarla.Location = new System.Drawing.Point(275, 103);
            this.DosyaRarla.Name = "DosyaRarla";
            this.DosyaRarla.Size = new System.Drawing.Size(71, 21);
            this.DosyaRarla.TabIndex = 9;
            this.DosyaRarla.Text = "Sıkıştır";
            this.DosyaRarla.UseVisualStyleBackColor = true;
            this.DosyaRarla.CheckedChanged += new System.EventHandler(this.DosyaRarla_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.DosyaRarla);
            this.Controls.Add(this.rbsifrele);
            this.Controls.Add(this.rbsifrecözme);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSifre);
            this.Controls.Add(this.rbsifrelemek);
            this.Controls.Add(this.textDosyaYolu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDosyaYolu;
        private System.Windows.Forms.RadioButton rbsifrelemek;
        private System.Windows.Forms.TextBox textSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.RadioButton rbsifrecözme;
        private System.Windows.Forms.CheckBox rbsifrele;
        private System.Windows.Forms.CheckBox DosyaRarla;
    }
}

