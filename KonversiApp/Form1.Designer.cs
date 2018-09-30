namespace KonversiApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Konversi = new System.Windows.Forms.Button();
            this.inputNominal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hasilKonversi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Terbilang";
            // 
            // btn_Konversi
            // 
            this.btn_Konversi.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Konversi.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Konversi.ForeColor = System.Drawing.Color.Black;
            this.btn_Konversi.Location = new System.Drawing.Point(357, 110);
            this.btn_Konversi.Name = "btn_Konversi";
            this.btn_Konversi.Size = new System.Drawing.Size(117, 23);
            this.btn_Konversi.TabIndex = 1;
            this.btn_Konversi.Text = "Konversi";
            this.btn_Konversi.UseVisualStyleBackColor = false;
            this.btn_Konversi.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNominal
            // 
            this.inputNominal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputNominal.Location = new System.Drawing.Point(116, 112);
            this.inputNominal.Name = "inputNominal";
            this.inputNominal.Size = new System.Drawing.Size(201, 22);
            this.inputNominal.TabIndex = 2;
            this.inputNominal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nama : Anif Prabono";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nim   : 17.11.0931";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // hasilKonversi
            // 
            this.hasilKonversi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasilKonversi.FormattingEnabled = true;
            this.hasilKonversi.ItemHeight = 15;
            this.hasilKonversi.Location = new System.Drawing.Point(116, 144);
            this.hasilKonversi.Name = "hasilKonversi";
            this.hasilKonversi.Size = new System.Drawing.Size(358, 109);
            this.hasilKonversi.TabIndex = 3;
            this.hasilKonversi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 326);
            this.Controls.Add(this.hasilKonversi);
            this.Controls.Add(this.inputNominal);
            this.Controls.Add(this.btn_Konversi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Konversi;
        private System.Windows.Forms.TextBox inputNominal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox hasilKonversi;
    }
}

