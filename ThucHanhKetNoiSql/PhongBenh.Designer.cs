namespace ThucHanhKetNoiSql
{
    partial class PhongBenh
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
            this.dgvPhongBenh = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoGiuongMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoGiuongHienTai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLoaiPhongID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoBanGhi = new System.Windows.Forms.Label();
            this.btnLoadDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBenh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhongBenh
            // 
            this.dgvPhongBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBenh.Location = new System.Drawing.Point(12, 214);
            this.dgvPhongBenh.Name = "dgvPhongBenh";
            this.dgvPhongBenh.Size = new System.Drawing.Size(789, 310);
            this.dgvPhongBenh.TabIndex = 0;
            this.dgvPhongBenh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBenh_CellClick);
            this.dgvPhongBenh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBenh_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(818, 250);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(818, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(818, 308);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 23);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(187, 17);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(251, 22);
            this.txtId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "id";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(187, 45);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(251, 22);
            this.txtTenPhong.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên phòng";
            // 
            // txtSoGiuongMax
            // 
            this.txtSoGiuongMax.Location = new System.Drawing.Point(187, 73);
            this.txtSoGiuongMax.Name = "txtSoGiuongMax";
            this.txtSoGiuongMax.Size = new System.Drawing.Size(251, 22);
            this.txtSoGiuongMax.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số giường max";
            // 
            // txtSoGiuongHienTai
            // 
            this.txtSoGiuongHienTai.Location = new System.Drawing.Point(187, 101);
            this.txtSoGiuongHienTai.Name = "txtSoGiuongHienTai";
            this.txtSoGiuongHienTai.Size = new System.Drawing.Size(251, 22);
            this.txtSoGiuongHienTai.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số giường hiện tại";
            // 
            // cbxLoaiPhongID
            // 
            this.cbxLoaiPhongID.FormattingEnabled = true;
            this.cbxLoaiPhongID.Location = new System.Drawing.Point(187, 142);
            this.cbxLoaiPhongID.Name = "cbxLoaiPhongID";
            this.cbxLoaiPhongID.Size = new System.Drawing.Size(251, 24);
            this.cbxLoaiPhongID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Loại phòng id";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(818, 337);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(150, 50);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            // 
            // lbSoBanGhi
            // 
            this.lbSoBanGhi.AutoSize = true;
            this.lbSoBanGhi.Location = new System.Drawing.Point(12, 531);
            this.lbSoBanGhi.Name = "lbSoBanGhi";
            this.lbSoBanGhi.Size = new System.Drawing.Size(81, 16);
            this.lbSoBanGhi.TabIndex = 10;
            this.lbSoBanGhi.Text = "Số bản ghi";
            // 
            // btnLoadDGV
            // 
            this.btnLoadDGV.Location = new System.Drawing.Point(818, 394);
            this.btnLoadDGV.Name = "btnLoadDGV";
            this.btnLoadDGV.Size = new System.Drawing.Size(150, 32);
            this.btnLoadDGV.TabIndex = 11;
            this.btnLoadDGV.Text = "Load Lại dgv";
            this.btnLoadDGV.UseVisualStyleBackColor = true;
            this.btnLoadDGV.Click += new System.EventHandler(this.btnLoadDGV_Click);
            // 
            // PhongBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 569);
            this.Controls.Add(this.btnLoadDGV);
            this.Controls.Add(this.lbSoBanGhi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxLoaiPhongID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoGiuongHienTai);
            this.Controls.Add(this.txtSoGiuongMax);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPhongBenh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhongBenh";
            this.Text = "PhongBenh";
            this.Load += new System.EventHandler(this.PhongBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBenh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoGiuongMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoGiuongHienTai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLoaiPhongID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgvPhongBenh;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoBanGhi;
        private System.Windows.Forms.Button btnLoadDGV;
    }
}