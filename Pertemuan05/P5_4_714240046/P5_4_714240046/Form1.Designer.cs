namespace P5_4_714240046
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJK = new System.Windows.Forms.Label();
            this.labelTL = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxJK = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTgl = new System.Windows.Forms.DateTimePicker();
            this.groupBoxKelas = new System.Windows.Forms.GroupBox();
            this.checkBoxPanahan = new System.Windows.Forms.CheckBox();
            this.checkBoxYoga = new System.Windows.Forms.CheckBox();
            this.checkBasket = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTenis = new System.Windows.Forms.CheckBox();
            this.checBoxBulu = new System.Windows.Forms.CheckBox();
            this.checkBoxVoli = new System.Windows.Forms.CheckBox();
            this.checkBoxRenang = new System.Windows.Forms.CheckBox();
            this.groupBoxJadwal = new System.Windows.Forms.GroupBox();
            this.radioMinggu = new System.Windows.Forms.RadioButton();
            this.radioSabtu = new System.Windows.Forms.RadioButton();
            this.radioSelasa = new System.Windows.Forms.RadioButton();
            this.radioSenin = new System.Windows.Forms.RadioButton();
            this.btnsimpan = new System.Windows.Forms.Button();
            this.btnbatal = new System.Windows.Forms.Button();
            this.groupBoxKelas.SuspendLayout();
            this.groupBoxJadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(253, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "FORM PENDAFTARAN";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelNama.Location = new System.Drawing.Point(150, 96);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(53, 20);
            this.labelNama.TabIndex = 1;
            this.labelNama.Text = "Nama";
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelJK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelJK.Location = new System.Drawing.Point(150, 141);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(114, 20);
            this.labelJK.TabIndex = 2;
            this.labelJK.Text = "Jenis Kelamin";
            // 
            // labelTL
            // 
            this.labelTL.AutoSize = true;
            this.labelTL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelTL.Location = new System.Drawing.Point(150, 181);
            this.labelTL.Name = "labelTL";
            this.labelTL.Size = new System.Drawing.Size(111, 20);
            this.labelTL.TabIndex = 3;
            this.labelTL.Text = "Tanggal Lahir";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(319, 96);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(314, 22);
            this.textBoxNama.TabIndex = 4;
            // 
            // comboBoxJK
            // 
            this.comboBoxJK.FormattingEnabled = true;
            this.comboBoxJK.Items.AddRange(new object[] {
            "--Pilih Jenis Kelamin--",
            "Laki-laki",
            "Perempuan"});
            this.comboBoxJK.Location = new System.Drawing.Point(319, 137);
            this.comboBoxJK.Name = "comboBoxJK";
            this.comboBoxJK.Size = new System.Drawing.Size(314, 24);
            this.comboBoxJK.TabIndex = 5;
            // 
            // dateTimePickerTgl
            // 
            this.dateTimePickerTgl.Location = new System.Drawing.Point(319, 181);
            this.dateTimePickerTgl.Name = "dateTimePickerTgl";
            this.dateTimePickerTgl.Size = new System.Drawing.Size(314, 22);
            this.dateTimePickerTgl.TabIndex = 6;
            // 
            // groupBoxKelas
            // 
            this.groupBoxKelas.Controls.Add(this.checkBoxPanahan);
            this.groupBoxKelas.Controls.Add(this.checkBoxYoga);
            this.groupBoxKelas.Controls.Add(this.checkBasket);
            this.groupBoxKelas.Controls.Add(this.checkBox1);
            this.groupBoxKelas.Controls.Add(this.checkBoxTenis);
            this.groupBoxKelas.Controls.Add(this.checBoxBulu);
            this.groupBoxKelas.Controls.Add(this.checkBoxVoli);
            this.groupBoxKelas.Controls.Add(this.checkBoxRenang);
            this.groupBoxKelas.Location = new System.Drawing.Point(91, 232);
            this.groupBoxKelas.Name = "groupBoxKelas";
            this.groupBoxKelas.Size = new System.Drawing.Size(297, 180);
            this.groupBoxKelas.TabIndex = 7;
            this.groupBoxKelas.TabStop = false;
            this.groupBoxKelas.Text = "Pilihan Kelas";
            // 
            // checkBoxPanahan
            // 
            this.checkBoxPanahan.AutoSize = true;
            this.checkBoxPanahan.Location = new System.Drawing.Point(180, 144);
            this.checkBoxPanahan.Name = "checkBoxPanahan";
            this.checkBoxPanahan.Size = new System.Drawing.Size(83, 20);
            this.checkBoxPanahan.TabIndex = 7;
            this.checkBoxPanahan.Text = "Panahan";
            this.checkBoxPanahan.UseVisualStyleBackColor = true;
            // 
            // checkBoxYoga
            // 
            this.checkBoxYoga.AutoSize = true;
            this.checkBoxYoga.Location = new System.Drawing.Point(19, 144);
            this.checkBoxYoga.Name = "checkBoxYoga";
            this.checkBoxYoga.Size = new System.Drawing.Size(62, 20);
            this.checkBoxYoga.TabIndex = 6;
            this.checkBoxYoga.Text = "Yoga";
            this.checkBoxYoga.UseVisualStyleBackColor = true;
            // 
            // checkBasket
            // 
            this.checkBasket.AutoSize = true;
            this.checkBasket.Location = new System.Drawing.Point(180, 36);
            this.checkBasket.Name = "checkBasket";
            this.checkBasket.Size = new System.Drawing.Size(71, 20);
            this.checkBasket.TabIndex = 2;
            this.checkBasket.Text = "Basket";
            this.checkBasket.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Sepak Bola";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxTenis
            // 
            this.checkBoxTenis.AutoSize = true;
            this.checkBoxTenis.Location = new System.Drawing.Point(180, 73);
            this.checkBoxTenis.Name = "checkBoxTenis";
            this.checkBoxTenis.Size = new System.Drawing.Size(63, 20);
            this.checkBoxTenis.TabIndex = 4;
            this.checkBoxTenis.Text = "Tenis";
            this.checkBoxTenis.UseVisualStyleBackColor = true;
            // 
            // checBoxBulu
            // 
            this.checBoxBulu.AutoSize = true;
            this.checBoxBulu.Location = new System.Drawing.Point(19, 73);
            this.checBoxBulu.Name = "checBoxBulu";
            this.checBoxBulu.Size = new System.Drawing.Size(107, 20);
            this.checBoxBulu.TabIndex = 3;
            this.checBoxBulu.Text = "Bulu Tangkis";
            this.checBoxBulu.UseVisualStyleBackColor = true;
            // 
            // checkBoxVoli
            // 
            this.checkBoxVoli.AutoSize = true;
            this.checkBoxVoli.Location = new System.Drawing.Point(180, 107);
            this.checkBoxVoli.Name = "checkBoxVoli";
            this.checkBoxVoli.Size = new System.Drawing.Size(52, 20);
            this.checkBoxVoli.TabIndex = 5;
            this.checkBoxVoli.Text = "Voli";
            this.checkBoxVoli.UseVisualStyleBackColor = true;
            // 
            // checkBoxRenang
            // 
            this.checkBoxRenang.AutoSize = true;
            this.checkBoxRenang.Location = new System.Drawing.Point(19, 108);
            this.checkBoxRenang.Name = "checkBoxRenang";
            this.checkBoxRenang.Size = new System.Drawing.Size(77, 20);
            this.checkBoxRenang.TabIndex = 1;
            this.checkBoxRenang.Text = "Renang";
            this.checkBoxRenang.UseVisualStyleBackColor = true;
            // 
            // groupBoxJadwal
            // 
            this.groupBoxJadwal.Controls.Add(this.radioMinggu);
            this.groupBoxJadwal.Controls.Add(this.radioSabtu);
            this.groupBoxJadwal.Controls.Add(this.radioSelasa);
            this.groupBoxJadwal.Controls.Add(this.radioSenin);
            this.groupBoxJadwal.Location = new System.Drawing.Point(462, 232);
            this.groupBoxJadwal.Name = "groupBoxJadwal";
            this.groupBoxJadwal.Size = new System.Drawing.Size(275, 180);
            this.groupBoxJadwal.TabIndex = 8;
            this.groupBoxJadwal.TabStop = false;
            this.groupBoxJadwal.Text = "Pilihan Jadwal";
            // 
            // radioMinggu
            // 
            this.radioMinggu.AutoSize = true;
            this.radioMinggu.Location = new System.Drawing.Point(17, 144);
            this.radioMinggu.Name = "radioMinggu";
            this.radioMinggu.Size = new System.Drawing.Size(145, 20);
            this.radioMinggu.TabIndex = 3;
            this.radioMinggu.TabStop = true;
            this.radioMinggu.Text = "Minggu, 13.00–20.00";
            this.radioMinggu.UseVisualStyleBackColor = true;
            // 
            // radioSabtu
            // 
            this.radioSabtu.AutoSize = true;
            this.radioSabtu.Location = new System.Drawing.Point(17, 108);
            this.radioSabtu.Name = "radioSabtu";
            this.radioSabtu.Size = new System.Drawing.Size(205, 20);
            this.radioSabtu.TabIndex = 2;
            this.radioSabtu.TabStop = true;
            this.radioSabtu.Text = "Sabtu s/d Minggu, 09.00–11.00";
            this.radioSabtu.UseVisualStyleBackColor = true;
            // 
            // radioSelasa
            // 
            this.radioSelasa.AutoSize = true;
            this.radioSelasa.Location = new System.Drawing.Point(17, 73);
            this.radioSelasa.Name = "radioSelasa";
            this.radioSelasa.Size = new System.Drawing.Size(206, 20);
            this.radioSelasa.TabIndex = 1;
            this.radioSelasa.TabStop = true;
            this.radioSelasa.Text = "Selasa s/d Kamis, 14.00–16.00";
            this.radioSelasa.UseVisualStyleBackColor = true;
            // 
            // radioSenin
            // 
            this.radioSenin.AutoSize = true;
            this.radioSenin.Location = new System.Drawing.Point(17, 36);
            this.radioSenin.Name = "radioSenin";
            this.radioSenin.Size = new System.Drawing.Size(193, 20);
            this.radioSenin.TabIndex = 0;
            this.radioSenin.TabStop = true;
            this.radioSenin.Text = "Senin s/d Rabu, 14.00–16.00";
            this.radioSenin.UseVisualStyleBackColor = true;
            // 
            // btnsimpan
            // 
            this.btnsimpan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsimpan.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnsimpan.ForeColor = System.Drawing.Color.White;
            this.btnsimpan.Location = new System.Drawing.Point(295, 428);
            this.btnsimpan.Name = "btnsimpan";
            this.btnsimpan.Size = new System.Drawing.Size(93, 35);
            this.btnsimpan.TabIndex = 9;
            this.btnsimpan.Text = "Simpan";
            this.btnsimpan.UseVisualStyleBackColor = false;
            // 
            // btnbatal
            // 
            this.btnbatal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnbatal.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnbatal.ForeColor = System.Drawing.Color.White;
            this.btnbatal.Location = new System.Drawing.Point(479, 428);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(96, 35);
            this.btnbatal.TabIndex = 10;
            this.btnbatal.Text = "Batal";
            this.btnbatal.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(833, 485);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnsimpan);
            this.Controls.Add(this.groupBoxJadwal);
            this.Controls.Add(this.groupBoxKelas);
            this.Controls.Add(this.dateTimePickerTgl);
            this.Controls.Add(this.comboBoxJK);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelTL);
            this.Controls.Add(this.labelJK);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "FORM PENDAFTARAN";
            this.groupBoxKelas.ResumeLayout(false);
            this.groupBoxKelas.PerformLayout();
            this.groupBoxJadwal.ResumeLayout(false);
            this.groupBoxJadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.Label labelTL;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxJK;
        private System.Windows.Forms.DateTimePicker dateTimePickerTgl;
        private System.Windows.Forms.GroupBox groupBoxKelas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checBoxBulu;
        private System.Windows.Forms.CheckBox checkBasket;
        private System.Windows.Forms.CheckBox checkBoxRenang;
        private System.Windows.Forms.CheckBox checkBoxTenis;
        private System.Windows.Forms.CheckBox checkBoxVoli;
        private System.Windows.Forms.CheckBox checkBoxYoga;
        private System.Windows.Forms.CheckBox checkBoxPanahan;
        private System.Windows.Forms.GroupBox groupBoxJadwal;
        private System.Windows.Forms.RadioButton radioMinggu;
        private System.Windows.Forms.RadioButton radioSabtu;
        private System.Windows.Forms.RadioButton radioSelasa;
        private System.Windows.Forms.RadioButton radioSenin;
        private System.Windows.Forms.Button btnsimpan;
        private System.Windows.Forms.Button btnbatal;
    }
}