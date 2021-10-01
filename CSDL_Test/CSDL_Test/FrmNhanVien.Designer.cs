
namespace CSDL_Test
{
    partial class FrmNhanVien
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
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.lbl_NV = new System.Windows.Forms.Label();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.lbl_CV = new System.Windows.Forms.Label();
            this.lbl_PB = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.num_hsl = new System.Windows.Forms.NumericUpDown();
            this.Grid_NhanVien = new System.Windows.Forms.DataGridView();
            this.qLNS_QLLUONGDataSet2 = new CSDL_Test.QLNS_QLLUONGDataSet2();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new CSDL_Test.QLNS_QLLUONGDataSet2TableAdapters.NHANVIENTableAdapter();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesoluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Taomoi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cbBox_Chucvu = new System.Windows.Forms.ComboBox();
            this.cbBox_PB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_hsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_NhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanVien.Location = new System.Drawing.Point(175, 17);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(475, 31);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "THÔNG TIN DANH MỤC NHÂN VIÊN";
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaNV.Location = new System.Drawing.Point(53, 82);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(129, 24);
            this.lbl_MaNV.TabIndex = 1;
            this.lbl_MaNV.Text = "Mã nhân viên:";
            // 
            // lbl_NV
            // 
            this.lbl_NV.AutoSize = true;
            this.lbl_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_NV.Location = new System.Drawing.Point(53, 117);
            this.lbl_NV.Name = "lbl_NV";
            this.lbl_NV.Size = new System.Drawing.Size(71, 24);
            this.lbl_NV.TabIndex = 1;
            this.lbl_NV.Text = "Họ tên:";
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_Luong.Location = new System.Drawing.Point(53, 156);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(118, 24);
            this.lbl_Luong.TabIndex = 1;
            this.lbl_Luong.Text = "Hệ số lương:";
            // 
            // lbl_CV
            // 
            this.lbl_CV.AutoSize = true;
            this.lbl_CV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_CV.Location = new System.Drawing.Point(53, 198);
            this.lbl_CV.Name = "lbl_CV";
            this.lbl_CV.Size = new System.Drawing.Size(85, 24);
            this.lbl_CV.TabIndex = 1;
            this.lbl_CV.Text = "Chức vụ:";
            // 
            // lbl_PB
            // 
            this.lbl_PB.AutoSize = true;
            this.lbl_PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_PB.Location = new System.Drawing.Point(53, 238);
            this.lbl_PB.Name = "lbl_PB";
            this.lbl_PB.Size = new System.Drawing.Size(108, 24);
            this.lbl_PB.TabIndex = 1;
            this.lbl_PB.Text = "Phòng ban:";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaNV.Location = new System.Drawing.Point(238, 79);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(281, 29);
            this.txt_MaNV.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_hoten.Location = new System.Drawing.Point(238, 114);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(281, 29);
            this.txt_hoten.TabIndex = 2;
            // 
            // num_hsl
            // 
            this.num_hsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.num_hsl.Location = new System.Drawing.Point(240, 154);
            this.num_hsl.Name = "num_hsl";
            this.num_hsl.Size = new System.Drawing.Size(278, 29);
            this.num_hsl.TabIndex = 3;
            // 
            // Grid_NhanVien
            // 
            this.Grid_NhanVien.AutoGenerateColumns = false;
            this.Grid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.hesoluongDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.maPBDataGridViewTextBoxColumn});
            this.Grid_NhanVien.DataSource = this.nHANVIENBindingSource;
            this.Grid_NhanVien.Location = new System.Drawing.Point(47, 297);
            this.Grid_NhanVien.Name = "Grid_NhanVien";
            this.Grid_NhanVien.Size = new System.Drawing.Size(542, 182);
            this.Grid_NhanVien.TabIndex = 4;
            // 
            // qLNS_QLLUONGDataSet2
            // 
            this.qLNS_QLLUONGDataSet2.DataSetName = "QLNS_QLLUONGDataSet2";
            this.qLNS_QLLUONGDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qLNS_QLLUONGDataSet2;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "ma_NV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "ma_NV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "ten_NV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "ten_NV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // hesoluongDataGridViewTextBoxColumn
            // 
            this.hesoluongDataGridViewTextBoxColumn.DataPropertyName = "he_so_luong";
            this.hesoluongDataGridViewTextBoxColumn.HeaderText = "he_so_luong";
            this.hesoluongDataGridViewTextBoxColumn.Name = "hesoluongDataGridViewTextBoxColumn";
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "ma_CV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "ma_CV";
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "ma_PB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "ma_PB";
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            // 
            // btn_Taomoi
            // 
            this.btn_Taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Taomoi.Location = new System.Drawing.Point(673, 100);
            this.btn_Taomoi.Name = "btn_Taomoi";
            this.btn_Taomoi.Size = new System.Drawing.Size(104, 35);
            this.btn_Taomoi.TabIndex = 5;
            this.btn_Taomoi.Text = "Tạo mới";
            this.btn_Taomoi.UseVisualStyleBackColor = true;
            this.btn_Taomoi.Click += new System.EventHandler(this.btn_Taomoi_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(673, 151);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(104, 35);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(673, 202);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(104, 35);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(673, 252);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(104, 35);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(673, 306);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(104, 35);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cbBox_Chucvu
            // 
            this.cbBox_Chucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_Chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbBox_Chucvu.FormattingEnabled = true;
            this.cbBox_Chucvu.Location = new System.Drawing.Point(238, 198);
            this.cbBox_Chucvu.Name = "cbBox_Chucvu";
            this.cbBox_Chucvu.Size = new System.Drawing.Size(281, 32);
            this.cbBox_Chucvu.TabIndex = 6;
            // 
            // cbBox_PB
            // 
            this.cbBox_PB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_PB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbBox_PB.FormattingEnabled = true;
            this.cbBox_PB.Location = new System.Drawing.Point(238, 238);
            this.cbBox_PB.Name = "cbBox_PB";
            this.cbBox_PB.Size = new System.Drawing.Size(281, 32);
            this.cbBox_PB.TabIndex = 6;
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.cbBox_PB);
            this.Controls.Add(this.cbBox_Chucvu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Taomoi);
            this.Controls.Add(this.Grid_NhanVien);
            this.Controls.Add(this.num_hsl);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.lbl_PB);
            this.Controls.Add(this.lbl_CV);
            this.Controls.Add(this.lbl_Luong);
            this.Controls.Add(this.lbl_NV);
            this.Controls.Add(this.lbl_MaNV);
            this.Controls.Add(this.lblNhanVien);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_hsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_NhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Label lbl_NV;
        private System.Windows.Forms.Label lbl_Luong;
        private System.Windows.Forms.Label lbl_CV;
        private System.Windows.Forms.Label lbl_PB;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.NumericUpDown num_hsl;
        private System.Windows.Forms.DataGridView Grid_NhanVien;
        private QLNS_QLLUONGDataSet2 qLNS_QLLUONGDataSet2;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QLNS_QLLUONGDataSet2TableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesoluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Taomoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ComboBox cbBox_Chucvu;
        private System.Windows.Forms.ComboBox cbBox_PB;
    }
}