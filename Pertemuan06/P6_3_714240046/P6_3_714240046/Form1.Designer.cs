namespace P6_3_714240046
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHuruf = new System.Windows.Forms.Label();
            this.txtAngka = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtAngka1 = new System.Windows.Forms.Label();
            this.txtAngka2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbHuruf = new System.Windows.Forms.TextBox();
            this.tbAngka = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAngka1 = new System.Windows.Forms.TextBox();
            this.tbAngka2 = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHuruf
            // 
            this.txtHuruf.AutoSize = true;
            this.txtHuruf.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuruf.Location = new System.Drawing.Point(157, 90);
            this.txtHuruf.Name = "txtHuruf";
            this.txtHuruf.Size = new System.Drawing.Size(50, 19);
            this.txtHuruf.TabIndex = 0;
            this.txtHuruf.Text = "Huruf";
            // 
            // txtAngka
            // 
            this.txtAngka.AutoSize = true;
            this.txtAngka.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAngka.Location = new System.Drawing.Point(157, 133);
            this.txtAngka.Name = "txtAngka";
            this.txtAngka.Size = new System.Drawing.Size(54, 19);
            this.txtAngka.TabIndex = 1;
            this.txtAngka.Text = "Angka";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(157, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(47, 19);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email";
            // 
            // txtAngka1
            // 
            this.txtAngka1.AutoSize = true;
            this.txtAngka1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.txtAngka1.Location = new System.Drawing.Point(157, 270);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(67, 19);
            this.txtAngka1.TabIndex = 3;
            this.txtAngka1.Text = "Angka 1";
            // 
            // txtAngka2
            // 
            this.txtAngka2.AutoSize = true;
            this.txtAngka2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.txtAngka2.Location = new System.Drawing.Point(157, 309);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(67, 19);
            this.txtAngka2.TabIndex = 4;
            this.txtAngka2.Text = "Angka 2";
            this.txtAngka2.Click += new System.EventHandler(this.txtAngka2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(157, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Angka 1 > Angka 2";
            // 
            // tbHuruf
            // 
            this.tbHuruf.Location = new System.Drawing.Point(325, 86);
            this.tbHuruf.Name = "tbHuruf";
            this.tbHuruf.Size = new System.Drawing.Size(302, 22);
            this.tbHuruf.TabIndex = 6;
            this.tbHuruf.Leave += new System.EventHandler(this.tbHuruf_Leave);
            // 
            // tbAngka
            // 
            this.tbAngka.Location = new System.Drawing.Point(325, 129);
            this.tbAngka.Name = "tbAngka";
            this.tbAngka.Size = new System.Drawing.Size(302, 22);
            this.tbAngka.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(325, 173);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(302, 22);
            this.tbEmail.TabIndex = 8;
            // 
            // tbAngka1
            // 
            this.tbAngka1.Location = new System.Drawing.Point(325, 266);
            this.tbAngka1.Name = "tbAngka1";
            this.tbAngka1.Size = new System.Drawing.Size(302, 22);
            this.tbAngka1.TabIndex = 9;
            // 
            // tbAngka2
            // 
            this.tbAngka2.Location = new System.Drawing.Point(325, 305);
            this.tbAngka2.Name = "tbAngka2";
            this.tbAngka2.Size = new System.Drawing.Size(302, 22);
            this.tbAngka2.TabIndex = 10;
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAngka2);
            this.Controls.Add(this.tbAngka1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbAngka);
            this.Controls.Add(this.tbHuruf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAngka);
            this.Controls.Add(this.txtHuruf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtHuruf;
        private System.Windows.Forms.Label txtAngka;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtAngka1;
        private System.Windows.Forms.Label txtAngka2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbHuruf;
        private System.Windows.Forms.TextBox tbAngka;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAngka1;
        private System.Windows.Forms.TextBox tbAngka2;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
    }
}

