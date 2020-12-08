namespace HarcosokApplication
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_harcosNeve = new System.Windows.Forms.TextBox();
            this.textBox_kepessegNeve = new System.Windows.Forms.TextBox();
            this.richTextBox_leiras = new System.Windows.Forms.RichTextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.listBox_harcosok = new System.Windows.Forms.ListBox();
            this.kepessegLeirasaTextBox = new System.Windows.Forms.RichTextBox();
            this.listBox_kepessegek = new System.Windows.Forms.ListBox();
            this.comboBox_hasznalo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcos létrehozása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Leírás";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "név:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "használó:";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(123, 283);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(237, 37);
            this.button_Add.TabIndex = 6;
            this.button_Add.Text = "Hozzáad";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(1135, 633);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(294, 59);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "Módosít";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(343, 836);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(212, 62);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Tőrlés";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "képesség leírása";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(338, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Képességei:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "harcosok:";
            // 
            // textBox_harcosNeve
            // 
            this.textBox_harcosNeve.Location = new System.Drawing.Point(123, 50);
            this.textBox_harcosNeve.Name = "textBox_harcosNeve";
            this.textBox_harcosNeve.Size = new System.Drawing.Size(355, 29);
            this.textBox_harcosNeve.TabIndex = 12;
            // 
            // textBox_kepessegNeve
            // 
            this.textBox_kepessegNeve.Location = new System.Drawing.Point(123, 230);
            this.textBox_kepessegNeve.Name = "textBox_kepessegNeve";
            this.textBox_kepessegNeve.Size = new System.Drawing.Size(355, 29);
            this.textBox_kepessegNeve.TabIndex = 13;
            // 
            // richTextBox_leiras
            // 
            this.richTextBox_leiras.Location = new System.Drawing.Point(817, 155);
            this.richTextBox_leiras.Name = "richTextBox_leiras";
            this.richTextBox_leiras.Size = new System.Drawing.Size(612, 103);
            this.richTextBox_leiras.TabIndex = 15;
            this.richTextBox_leiras.Text = "";
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(519, 40);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(229, 41);
            this.button_create.TabIndex = 17;
            this.button_create.Text = "Létrehozás";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // listBox_harcosok
            // 
            this.listBox_harcosok.FormattingEnabled = true;
            this.listBox_harcosok.ItemHeight = 24;
            this.listBox_harcosok.Location = new System.Drawing.Point(36, 453);
            this.listBox_harcosok.Name = "listBox_harcosok";
            this.listBox_harcosok.Size = new System.Drawing.Size(212, 364);
            this.listBox_harcosok.TabIndex = 18;
            // 
            // kepessegLeirasaTextBox
            // 
            this.kepessegLeirasaTextBox.Location = new System.Drawing.Point(817, 453);
            this.kepessegLeirasaTextBox.Name = "kepessegLeirasaTextBox";
            this.kepessegLeirasaTextBox.Size = new System.Drawing.Size(612, 142);
            this.kepessegLeirasaTextBox.TabIndex = 19;
            this.kepessegLeirasaTextBox.Text = "";
            // 
            // listBox_kepessegek
            // 
            this.listBox_kepessegek.FormattingEnabled = true;
            this.listBox_kepessegek.ItemHeight = 24;
            this.listBox_kepessegek.Location = new System.Drawing.Point(343, 453);
            this.listBox_kepessegek.Name = "listBox_kepessegek";
            this.listBox_kepessegek.Size = new System.Drawing.Size(212, 364);
            this.listBox_kepessegek.TabIndex = 20;
            // 
            // comboBox_hasznalo
            // 
            this.comboBox_hasznalo.FormattingEnabled = true;
            this.comboBox_hasznalo.Location = new System.Drawing.Point(123, 155);
            this.comboBox_hasznalo.Name = "comboBox_hasznalo";
            this.comboBox_hasznalo.Size = new System.Drawing.Size(355, 32);
            this.comboBox_hasznalo.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 932);
            this.Controls.Add(this.comboBox_hasznalo);
            this.Controls.Add(this.listBox_kepessegek);
            this.Controls.Add(this.kepessegLeirasaTextBox);
            this.Controls.Add(this.listBox_harcosok);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.richTextBox_leiras);
            this.Controls.Add(this.textBox_kepessegNeve);
            this.Controls.Add(this.textBox_harcosNeve);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "HarcosokApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_harcosNeve;
        private System.Windows.Forms.TextBox textBox_kepessegNeve;
        private System.Windows.Forms.RichTextBox richTextBox_leiras;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.ListBox listBox_harcosok;
        private System.Windows.Forms.RichTextBox kepessegLeirasaTextBox;
        private System.Windows.Forms.ListBox listBox_kepessegek;
        private System.Windows.Forms.ComboBox comboBox_hasznalo;
    }
}

