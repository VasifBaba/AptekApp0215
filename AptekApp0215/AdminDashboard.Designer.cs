namespace AptekApp0215
{
    partial class AdminDashboard
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rccdescription = new System.Windows.Forms.RichTextBox();
            this.txtmedicinename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmprice = new System.Windows.Forms.NumericUpDown();
            this.ckWithReceipt = new System.Windows.Forms.CheckBox();
            this.dtproductiondate = new System.Windows.Forms.DateTimePicker();
            this.dtedlineddate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbfirm = new System.Windows.Forms.ComboBox();
            this.nmcount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbtags = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.taggroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtvzdv = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Teal;
            this.lblWelcome.Location = new System.Drawing.Point(49, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 37);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "Dərman";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(49, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Haqqında";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rccdescription
            // 
            this.rccdescription.Location = new System.Drawing.Point(56, 367);
            this.rccdescription.Name = "rccdescription";
            this.rccdescription.Size = new System.Drawing.Size(217, 119);
            this.rccdescription.TabIndex = 9;
            this.rccdescription.Text = "";
            // 
            // txtmedicinename
            // 
            this.txtmedicinename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedicinename.Location = new System.Drawing.Point(56, 62);
            this.txtmedicinename.Name = "txtmedicinename";
            this.txtmedicinename.Size = new System.Drawing.Size(174, 26);
            this.txtmedicinename.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(385, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Qiymət";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nmprice
            // 
            this.nmprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmprice.Location = new System.Drawing.Point(392, 62);
            this.nmprice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmprice.Name = "nmprice";
            this.nmprice.Size = new System.Drawing.Size(154, 26);
            this.nmprice.TabIndex = 12;
            this.nmprice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ckWithReceipt
            // 
            this.ckWithReceipt.AutoSize = true;
            this.ckWithReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckWithReceipt.Location = new System.Drawing.Point(56, 510);
            this.ckWithReceipt.Name = "ckWithReceipt";
            this.ckWithReceipt.Size = new System.Drawing.Size(99, 24);
            this.ckWithReceipt.TabIndex = 13;
            this.ckWithReceipt.Text = "Resept ilə";
            this.ckWithReceipt.UseVisualStyleBackColor = true;
            // 
            // dtproductiondate
            // 
            this.dtproductiondate.CalendarForeColor = System.Drawing.Color.Teal;
            this.dtproductiondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtproductiondate.Location = new System.Drawing.Point(382, 416);
            this.dtproductiondate.Name = "dtproductiondate";
            this.dtproductiondate.Size = new System.Drawing.Size(278, 26);
            this.dtproductiondate.TabIndex = 14;
            // 
            // dtedlineddate
            // 
            this.dtedlineddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtedlineddate.Location = new System.Drawing.Point(750, 416);
            this.dtedlineddate.Name = "dtedlineddate";
            this.dtedlineddate.Size = new System.Drawing.Size(278, 26);
            this.dtedlineddate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(385, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 37);
            this.label3.TabIndex = 16;
            this.label3.Text = "İstehsal tarixi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(743, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Son istifadə tarixi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(743, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 37);
            this.label12.TabIndex = 18;
            this.label12.Text = "Firma";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbfirm
            // 
            this.cmbfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfirm.FormattingEnabled = true;
            this.cmbfirm.Location = new System.Drawing.Point(750, 60);
            this.cmbfirm.Name = "cmbfirm";
            this.cmbfirm.Size = new System.Drawing.Size(121, 28);
            this.cmbfirm.TabIndex = 19;
            // 
            // nmcount
            // 
            this.nmcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcount.Location = new System.Drawing.Point(392, 218);
            this.nmcount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmcount.Name = "nmcount";
            this.nmcount.Size = new System.Drawing.Size(154, 26);
            this.nmcount.TabIndex = 21;
            this.nmcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(385, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Say";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbtags
            // 
            this.cmbtags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtags.FormattingEnabled = true;
            this.cmbtags.Location = new System.Drawing.Point(750, 216);
            this.cmbtags.Name = "cmbtags";
            this.cmbtags.Size = new System.Drawing.Size(121, 28);
            this.cmbtags.TabIndex = 23;
            this.cmbtags.SelectedIndexChanged += new System.EventHandler(this.Cmbtags_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(743, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tağ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // taggroup
            // 
            this.taggroup.Location = new System.Drawing.Point(956, 166);
            this.taggroup.Name = "taggroup";
            this.taggroup.Size = new System.Drawing.Size(320, 130);
            this.taggroup.TabIndex = 24;
            this.taggroup.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(56, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Dərmanı daxil et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(56, 216);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(174, 26);
            this.txtbarcode.TabIndex = 27;
            // 
            // txtvzdv
            // 
            this.txtvzdv.AutoSize = true;
            this.txtvzdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvzdv.ForeColor = System.Drawing.Color.Teal;
            this.txtvzdv.Location = new System.Drawing.Point(49, 164);
            this.txtvzdv.Name = "txtvzdv";
            this.txtvzdv.Size = new System.Drawing.Size(119, 37);
            this.txtvzdv.TabIndex = 26;
            this.txtvzdv.Text = "Barkod";
            this.txtvzdv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(453, 555);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(136, 37);
            this.lblError.TabIndex = 28;
            this.lblError.Text = "Barcode";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblError.Visible = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 627);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtvzdv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taggroup);
            this.Controls.Add(this.cmbtags);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nmcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbfirm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtedlineddate);
            this.Controls.Add(this.dtproductiondate);
            this.Controls.Add(this.ckWithReceipt);
            this.Controls.Add(this.nmprice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmedicinename);
            this.Controls.Add(this.rccdescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rccdescription;
        private System.Windows.Forms.TextBox txtmedicinename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmprice;
        private System.Windows.Forms.CheckBox ckWithReceipt;
        private System.Windows.Forms.DateTimePicker dtproductiondate;
        private System.Windows.Forms.DateTimePicker dtedlineddate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbfirm;
        private System.Windows.Forms.NumericUpDown nmcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbtags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox taggroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label txtvzdv;
        private System.Windows.Forms.Label lblError;
    }
}