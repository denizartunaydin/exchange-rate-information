namespace Exchange_Rate_Information
{
    partial class frm_currency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_currency));
            this.cmb_currencies = new System.Windows.Forms.ComboBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_selling = new System.Windows.Forms.Label();
            this.lbl_buying = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_currencies
            // 
            this.cmb_currencies.FormattingEnabled = true;
            this.cmb_currencies.Location = new System.Drawing.Point(71, 15);
            this.cmb_currencies.Name = "cmb_currencies";
            this.cmb_currencies.Size = new System.Drawing.Size(139, 21);
            this.cmb_currencies.TabIndex = 1;
            this.cmb_currencies.SelectedIndexChanged += new System.EventHandler(this.cmb_currencies_SelectedIndexChanged);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(71, 50);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(139, 20);
            this.datetime.TabIndex = 3;
            this.datetime.ValueChanged += new System.EventHandler(this.datetime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kur Bilgisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kur Tarihi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(327, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Satış Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alış Fiyatı";
            // 
            // lbl_selling
            // 
            this.lbl_selling.AutoSize = true;
            this.lbl_selling.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_selling.ForeColor = System.Drawing.Color.Red;
            this.lbl_selling.Location = new System.Drawing.Point(327, 55);
            this.lbl_selling.Name = "lbl_selling";
            this.lbl_selling.Size = new System.Drawing.Size(31, 15);
            this.lbl_selling.TabIndex = 9;
            this.lbl_selling.Text = "0 TL";
            // 
            // lbl_buying
            // 
            this.lbl_buying.AutoSize = true;
            this.lbl_buying.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_buying.ForeColor = System.Drawing.Color.Red;
            this.lbl_buying.Location = new System.Drawing.Point(233, 55);
            this.lbl_buying.Name = "lbl_buying";
            this.lbl_buying.Size = new System.Drawing.Size(31, 15);
            this.lbl_buying.TabIndex = 10;
            this.lbl_buying.Text = "0 TL";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(12, 121);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(41, 15);
            this.lbl_error.TabIndex = 13;
            this.lbl_error.Text = "label5";
            this.lbl_error.Visible = false;
            // 
            // frm_currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 163);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_selling);
            this.Controls.Add(this.lbl_buying);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.cmb_currencies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_currency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Kuru Bilgileri";
            this.Load += new System.EventHandler(this.frm_currency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_currencies;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_selling;
        private System.Windows.Forms.Label lbl_buying;
        private System.Windows.Forms.Label lbl_error;
    }
}

