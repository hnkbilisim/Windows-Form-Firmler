namespace Ornek_Form_Calisma
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
            this.btnFilmEkleForm = new System.Windows.Forms.Button();
            this.btnTumFilmlerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFilmEkleForm
            // 
            this.btnFilmEkleForm.Location = new System.Drawing.Point(41, 36);
            this.btnFilmEkleForm.Name = "btnFilmEkleForm";
            this.btnFilmEkleForm.Size = new System.Drawing.Size(132, 78);
            this.btnFilmEkleForm.TabIndex = 0;
            this.btnFilmEkleForm.Text = "Film Ekle";
            this.btnFilmEkleForm.UseVisualStyleBackColor = true;
            // 
            // btnTumFilmlerForm
            // 
            this.btnTumFilmlerForm.Location = new System.Drawing.Point(41, 141);
            this.btnTumFilmlerForm.Name = "btnTumFilmlerForm";
            this.btnTumFilmlerForm.Size = new System.Drawing.Size(132, 78);
            this.btnTumFilmlerForm.TabIndex = 1;
            this.btnTumFilmlerForm.Text = "Tüm Liste";
            this.btnTumFilmlerForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 307);
            this.Controls.Add(this.btnTumFilmlerForm);
            this.Controls.Add(this.btnFilmEkleForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFilmEkleForm;
        private System.Windows.Forms.Button btnTumFilmlerForm;
    }
}

