namespace QuanLyRapPhim
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
            this.InDoanhThuPhim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboTenbophim = new System.Windows.Forms.ComboBox();
            this.gridviewDoanhthubanhang = new System.Windows.Forms.DataGridView();
            this.Tenbophim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenrapphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTenrapphim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDTPhim = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDTRap = new System.Windows.Forms.TextBox();
            this.InDoanhThuRap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDoanhthubanhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bộ phim:";
            // 
            // InDoanhThuPhim
            // 
            this.InDoanhThuPhim.Location = new System.Drawing.Point(140, 325);
            this.InDoanhThuPhim.Name = "InDoanhThuPhim";
            this.InDoanhThuPhim.Size = new System.Drawing.Size(150, 55);
            this.InDoanhThuPhim.TabIndex = 2;
            this.InDoanhThuPhim.Text = "In Doanh Thu Phim";
            this.InDoanhThuPhim.UseVisualStyleBackColor = true;
            this.InDoanhThuPhim.Click += new System.EventHandler(this.indoanhthu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doanh Thu Bán Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên rạp phim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tháng:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // cboTenbophim
            // 
            this.cboTenbophim.FormattingEnabled = true;
            this.cboTenbophim.Location = new System.Drawing.Point(119, 49);
            this.cboTenbophim.Name = "cboTenbophim";
            this.cboTenbophim.Size = new System.Drawing.Size(473, 21);
            this.cboTenbophim.TabIndex = 8;
            // 
            // gridviewDoanhthubanhang
            // 
            this.gridviewDoanhthubanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDoanhthubanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenbophim,
            this.tenrapphim});
            this.gridviewDoanhthubanhang.Location = new System.Drawing.Point(76, 156);
            this.gridviewDoanhthubanhang.Name = "gridviewDoanhthubanhang";
            this.gridviewDoanhthubanhang.Size = new System.Drawing.Size(648, 150);
            this.gridviewDoanhthubanhang.TabIndex = 9;
            // 
            // Tenbophim
            // 
            this.Tenbophim.DataPropertyName = "TenPhim";
            this.Tenbophim.HeaderText = "Tên bộ phim";
            this.Tenbophim.Name = "Tenbophim";
            // 
            // tenrapphim
            // 
            this.tenrapphim.DataPropertyName = "TenRap";
            this.tenrapphim.HeaderText = "Tên rạp phim";
            this.tenrapphim.Name = "tenrapphim";
            // 
            // cboTenrapphim
            // 
            this.cboTenrapphim.FormattingEnabled = true;
            this.cboTenrapphim.Location = new System.Drawing.Point(119, 90);
            this.cboTenrapphim.Name = "cboTenrapphim";
            this.cboTenrapphim.Size = new System.Drawing.Size(473, 21);
            this.cboTenrapphim.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doanh thu rạp";
            // 
            // txtDTPhim
            // 
            this.txtDTPhim.Location = new System.Drawing.Point(537, 325);
            this.txtDTPhim.Name = "txtDTPhim";
            this.txtDTPhim.Size = new System.Drawing.Size(100, 20);
            this.txtDTPhim.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doanh thu phim";
            // 
            // txtDTRap
            // 
            this.txtDTRap.Location = new System.Drawing.Point(537, 364);
            this.txtDTRap.Name = "txtDTRap";
            this.txtDTRap.Size = new System.Drawing.Size(100, 20);
            this.txtDTRap.TabIndex = 13;
            // 
            // InDoanhThuRap
            // 
            this.InDoanhThuRap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InDoanhThuRap.Location = new System.Drawing.Point(140, 386);
            this.InDoanhThuRap.Name = "InDoanhThuRap";
            this.InDoanhThuRap.Size = new System.Drawing.Size(150, 55);
            this.InDoanhThuRap.TabIndex = 14;
            this.InDoanhThuRap.Text = "In Doanh Thu Rạp";
            this.InDoanhThuRap.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InDoanhThuRap);
            this.Controls.Add(this.txtDTRap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDTPhim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridviewDoanhthubanhang);
            this.Controls.Add(this.cboTenrapphim);
            this.Controls.Add(this.cboTenbophim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InDoanhThuPhim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDoanhthubanhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InDoanhThuPhim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboTenbophim;
        private System.Windows.Forms.DataGridView gridviewDoanhthubanhang;
        private System.Windows.Forms.ComboBox cboTenrapphim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDTPhim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDTRap;
        private System.Windows.Forms.Button InDoanhThuRap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbophim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenrapphim;
        private System.Windows.Forms.Button button1;
    }
}

