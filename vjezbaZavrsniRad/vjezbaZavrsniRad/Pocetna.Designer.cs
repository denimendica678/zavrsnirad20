
namespace vjezbaZavrsniRad
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.btnUpisBroda = new System.Windows.Forms.Button();
            this.btnUpisAgencije = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxNaslov = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnKalendar);
            this.flowLayoutPanel1.Controls.Add(this.btnUpisBroda);
            this.flowLayoutPanel1.Controls.Add(this.btnUpisAgencije);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 332);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1097, 431);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnKalendar
            // 
            this.btnKalendar.BackColor = System.Drawing.Color.Silver;
            this.btnKalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKalendar.Location = new System.Drawing.Point(3, 2);
            this.btnKalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.Size = new System.Drawing.Size(1093, 142);
            this.btnKalendar.TabIndex = 1;
            this.btnKalendar.Text = "KALENDAR BRODOVA";
            this.btnKalendar.UseVisualStyleBackColor = false;
            this.btnKalendar.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnUpisBroda
            // 
            this.btnUpisBroda.BackColor = System.Drawing.Color.Silver;
            this.btnUpisBroda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpisBroda.Location = new System.Drawing.Point(3, 148);
            this.btnUpisBroda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpisBroda.Name = "btnUpisBroda";
            this.btnUpisBroda.Size = new System.Drawing.Size(1093, 134);
            this.btnUpisBroda.TabIndex = 2;
            this.btnUpisBroda.Text = "UPIS BRODOVA";
            this.btnUpisBroda.UseVisualStyleBackColor = false;
            this.btnUpisBroda.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // btnUpisAgencije
            // 
            this.btnUpisAgencije.BackColor = System.Drawing.Color.Silver;
            this.btnUpisAgencije.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpisAgencije.Location = new System.Drawing.Point(3, 286);
            this.btnUpisAgencije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpisAgencije.Name = "btnUpisAgencije";
            this.btnUpisAgencije.Size = new System.Drawing.Size(1093, 134);
            this.btnUpisAgencije.TabIndex = 3;
            this.btnUpisAgencije.Text = "UPIS AGENCIJE";
            this.btnUpisAgencije.UseVisualStyleBackColor = false;
            this.btnUpisAgencije.Click += new System.EventHandler(this.btnUpisAgencije_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.richTextBoxNaslov);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(405, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1136, 778);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // richTextBoxNaslov
            // 
            this.richTextBoxNaslov.BackColor = System.Drawing.Color.Azure;
            this.richTextBoxNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxNaslov.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxNaslov.Location = new System.Drawing.Point(212, 64);
            this.richTextBoxNaslov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxNaslov.Name = "richTextBoxNaslov";
            this.richTextBoxNaslov.Size = new System.Drawing.Size(747, 78);
            this.richTextBoxNaslov.TabIndex = 2;
            this.richTextBoxNaslov.TabStop = false;
            this.richTextBoxNaslov.Text = "EVIDENCIJA BRODOVA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::vjezbaZavrsniRad.Properties.Resources.naslovna_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(259, 80);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 246);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzlaz.BackColor = System.Drawing.Color.Red;
            this.btnIzlaz.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzlaz.ForeColor = System.Drawing.Color.White;
            this.btnIzlaz.Location = new System.Drawing.Point(929, 107);
            this.btnIzlaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 57);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "X";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evidencija brodova";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnUpisBroda;
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnUpisAgencije;
    }
}

