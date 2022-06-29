
namespace vjezbaZavrsniRad
{
    partial class UpisUKalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpisUKalendar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStanje = new System.Windows.Forms.ComboBox();
            this.btnUnesiBrodUKalendar = new System.Windows.Forms.Button();
            this.comboBoxVez = new System.Windows.Forms.ComboBox();
            this.comboBoxAgencija = new System.Windows.Forms.ComboBox();
            this.comboBoxImeBroda = new System.Windows.Forms.ComboBox();
            this.dateTimePickerOdlazak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDolazak = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxNaslov = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNatragUUKKB = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBoxStanje);
            this.groupBox2.Controls.Add(this.btnUnesiBrodUKalendar);
            this.groupBox2.Controls.Add(this.comboBoxVez);
            this.groupBox2.Controls.Add(this.comboBoxAgencija);
            this.groupBox2.Controls.Add(this.comboBoxImeBroda);
            this.groupBox2.Controls.Add(this.dateTimePickerOdlazak);
            this.groupBox2.Controls.Add(this.dateTimePickerDolazak);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.richTextBoxNaslov);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnNatragUUKKB);
            this.groupBox2.Location = new System.Drawing.Point(405, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1107, 779);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "STANJE";
            // 
            // comboBoxStanje
            // 
            this.comboBoxStanje.FormattingEnabled = true;
            this.comboBoxStanje.Items.AddRange(new object[] {
            "Najava",
            "Boravak",
            "Storno"});
            this.comboBoxStanje.Location = new System.Drawing.Point(203, 564);
            this.comboBoxStanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxStanje.Name = "comboBoxStanje";
            this.comboBoxStanje.Size = new System.Drawing.Size(223, 24);
            this.comboBoxStanje.TabIndex = 5;
            this.comboBoxStanje.SelectedIndexChanged += new System.EventHandler(this.comboBoxStanje_SelectedIndexChanged);
            // 
            // btnUnesiBrodUKalendar
            // 
            this.btnUnesiBrodUKalendar.BackColor = System.Drawing.Color.Silver;
            this.btnUnesiBrodUKalendar.Location = new System.Drawing.Point(53, 710);
            this.btnUnesiBrodUKalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnesiBrodUKalendar.Name = "btnUnesiBrodUKalendar";
            this.btnUnesiBrodUKalendar.Size = new System.Drawing.Size(231, 46);
            this.btnUnesiBrodUKalendar.TabIndex = 7;
            this.btnUnesiBrodUKalendar.Text = "UNESI";
            this.btnUnesiBrodUKalendar.UseVisualStyleBackColor = false;
            this.btnUnesiBrodUKalendar.Click += new System.EventHandler(this.btnUnesiBrodUKalendar_Click);
            // 
            // comboBoxVez
            // 
            this.comboBoxVez.FormattingEnabled = true;
            this.comboBoxVez.Items.AddRange(new object[] {
            "V1",
            "V2",
            "V3",
            "V4",
            "V5",
            "V6",
            "V7",
            "V8",
            "V9",
            "V10"});
            this.comboBoxVez.Location = new System.Drawing.Point(203, 614);
            this.comboBoxVez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxVez.Name = "comboBoxVez";
            this.comboBoxVez.Size = new System.Drawing.Size(223, 24);
            this.comboBoxVez.TabIndex = 6;
            // 
            // comboBoxAgencija
            // 
            this.comboBoxAgencija.FormattingEnabled = true;
            this.comboBoxAgencija.Items.AddRange(new object[] {
            "Sunny Way",
            "Simmor",
            "BWA",
            "Bez agencije"});
            this.comboBoxAgencija.Location = new System.Drawing.Point(204, 513);
            this.comboBoxAgencija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxAgencija.Name = "comboBoxAgencija";
            this.comboBoxAgencija.Size = new System.Drawing.Size(223, 24);
            this.comboBoxAgencija.TabIndex = 4;
            // 
            // comboBoxImeBroda
            // 
            this.comboBoxImeBroda.FormattingEnabled = true;
            this.comboBoxImeBroda.Location = new System.Drawing.Point(204, 354);
            this.comboBoxImeBroda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxImeBroda.Name = "comboBoxImeBroda";
            this.comboBoxImeBroda.Size = new System.Drawing.Size(223, 24);
            this.comboBoxImeBroda.TabIndex = 1;
            // 
            // dateTimePickerOdlazak
            // 
            this.dateTimePickerOdlazak.Location = new System.Drawing.Point(204, 457);
            this.dateTimePickerOdlazak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerOdlazak.Name = "dateTimePickerOdlazak";
            this.dateTimePickerOdlazak.Size = new System.Drawing.Size(223, 22);
            this.dateTimePickerOdlazak.TabIndex = 3;
            // 
            // dateTimePickerDolazak
            // 
            this.dateTimePickerDolazak.Location = new System.Drawing.Point(204, 404);
            this.dateTimePickerDolazak.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDolazak.Name = "dateTimePickerDolazak";
            this.dateTimePickerDolazak.Size = new System.Drawing.Size(223, 22);
            this.dateTimePickerDolazak.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "AGENCIJA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 567);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "VEZ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ODLAZAK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "DOLAZAK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "BROD";
            // 
            // richTextBoxNaslov
            // 
            this.richTextBoxNaslov.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxNaslov.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxNaslov.Location = new System.Drawing.Point(359, 32);
            this.richTextBoxNaslov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxNaslov.Name = "richTextBoxNaslov";
            this.richTextBoxNaslov.Size = new System.Drawing.Size(741, 78);
            this.richTextBoxNaslov.TabIndex = 1;
            this.richTextBoxNaslov.TabStop = false;
            this.richTextBoxNaslov.Text = "UPIS U KALENDAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::vjezbaZavrsniRad.Properties.Resources.naslovna_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(333, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 246);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnNatragUUKKB
            // 
            this.btnNatragUUKKB.BackColor = System.Drawing.Color.Silver;
            this.btnNatragUUKKB.Location = new System.Drawing.Point(53, 42);
            this.btnNatragUUKKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatragUUKKB.Name = "btnNatragUUKKB";
            this.btnNatragUUKKB.Size = new System.Drawing.Size(187, 89);
            this.btnNatragUUKKB.TabIndex = 8;
            this.btnNatragUUKKB.Text = "NATRAG";
            this.btnNatragUUKKB.UseVisualStyleBackColor = false;
            this.btnNatragUUKKB.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // UpisUKalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpisUKalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upis broda u kalendar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpisUKalendar_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNatragUUKKB;
        private System.Windows.Forms.DateTimePicker dateTimePickerOdlazak;
        private System.Windows.Forms.DateTimePicker dateTimePickerDolazak;
        private System.Windows.Forms.ComboBox comboBoxImeBroda;
        private System.Windows.Forms.ComboBox comboBoxVez;
        private System.Windows.Forms.ComboBox comboBoxAgencija;
        private System.Windows.Forms.Button btnUnesiBrodUKalendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStanje;
    }
}