namespace _13102023_odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbPoliklinik = new ComboBox();
            btnRandevuOlustur = new Button();
            groupBox2 = new GroupBox();
            rbSaat12 = new RadioButton();
            rbSaat15 = new RadioButton();
            rbSaat13 = new RadioButton();
            rbSaat14 = new RadioButton();
            dtTarih = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            mtxtTelefon = new MaskedTextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lbRandevular = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(822, 509);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cbPoliklinik);
            tabPage1.Controls.Add(btnRandevuOlustur);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(dtTarih);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(mtxtTelefon);
            tabPage1.Controls.Add(txtAdSoyad);
            tabPage1.Controls.Add(txtTC);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(814, 476);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Randevu Oluştur";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbPoliklinik
            // 
            cbPoliklinik.FormattingEnabled = true;
            cbPoliklinik.Items.AddRange(new object[] { "Göz", "Dahiliye", "Diş" });
            cbPoliklinik.Location = new Point(95, 215);
            cbPoliklinik.Name = "cbPoliklinik";
            cbPoliklinik.Size = new Size(250, 28);
            cbPoliklinik.TabIndex = 19;
            cbPoliklinik.Text = "Poliklinik Seçiniz";
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(71, 398);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(184, 29);
            btnRandevuOlustur.TabIndex = 18;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbSaat12);
            groupBox2.Controls.Add(rbSaat15);
            groupBox2.Controls.Add(rbSaat13);
            groupBox2.Controls.Add(rbSaat14);
            groupBox2.Location = new Point(8, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(337, 94);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Saatleri";
            // 
            // rbSaat12
            // 
            rbSaat12.AutoSize = true;
            rbSaat12.Location = new Point(6, 26);
            rbSaat12.Name = "rbSaat12";
            rbSaat12.Size = new Size(65, 24);
            rbSaat12.TabIndex = 13;
            rbSaat12.TabStop = true;
            rbSaat12.Text = "12:00";
            rbSaat12.UseVisualStyleBackColor = true;
            // 
            // rbSaat15
            // 
            rbSaat15.AutoSize = true;
            rbSaat15.Location = new Point(146, 56);
            rbSaat15.Name = "rbSaat15";
            rbSaat15.Size = new Size(65, 24);
            rbSaat15.TabIndex = 16;
            rbSaat15.TabStop = true;
            rbSaat15.Text = "15:00";
            rbSaat15.UseVisualStyleBackColor = true;
            // 
            // rbSaat13
            // 
            rbSaat13.AutoSize = true;
            rbSaat13.Location = new Point(146, 26);
            rbSaat13.Name = "rbSaat13";
            rbSaat13.Size = new Size(65, 24);
            rbSaat13.TabIndex = 14;
            rbSaat13.TabStop = true;
            rbSaat13.Text = "13:00";
            rbSaat13.UseVisualStyleBackColor = true;
            // 
            // rbSaat14
            // 
            rbSaat14.AutoSize = true;
            rbSaat14.Location = new Point(6, 56);
            rbSaat14.Name = "rbSaat14";
            rbSaat14.Size = new Size(65, 24);
            rbSaat14.TabIndex = 15;
            rbSaat14.TabStop = true;
            rbSaat14.Text = "14:00";
            rbSaat14.UseVisualStyleBackColor = true;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(95, 258);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(250, 27);
            dtTarih.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 263);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 11;
            label7.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 193);
            label6.Name = "label6";
            label6.Size = new Size(121, 20);
            label6.TabIndex = 9;
            label6.Text = "Randevu Bilgileri";
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Location = new Point(109, 97);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(236, 27);
            mtxtTelefon.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(109, 59);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(238, 27);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(109, 25);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(238, 27);
            txtTC.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 223);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 5;
            label5.Text = "Poliklinik";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Controls.Add(rbKadin);
            groupBox1.Location = new Point(3, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 60);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(180, 26);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(65, 24);
            rbErkek.TabIndex = 0;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(62, 26);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(68, 24);
            rbKadin.TabIndex = 0;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 97);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 3;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 66);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "TC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Hasta Bilgileri";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbRandevular);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(814, 476);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Randevular";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbRandevular
            // 
            lbRandevular.FormattingEnabled = true;
            lbRandevular.ItemHeight = 20;
            lbRandevular.Location = new Point(8, 6);
            lbRandevular.Name = "lbRandevular";
            lbRandevular.Size = new Size(787, 464);
            lbRandevular.TabIndex = 0;
            lbRandevular.DoubleClick += lbRandevular_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 509);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "MainMenu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtxtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label5;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private DateTimePicker dtTarih;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private RadioButton rbSaat12;
        private RadioButton rbSaat15;
        private RadioButton rbSaat13;
        private RadioButton rbSaat14;
        private Button btnRandevuOlustur;
        private ComboBox cbPoliklinik;
        private ListBox lbRandevular;
    }
}