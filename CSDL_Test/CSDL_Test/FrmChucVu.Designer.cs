
namespace CSDL_Test
{
    partial class FrmChucVu
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
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lbl_TenCV = new System.Windows.Forms.Label();
            this.lbl_MaCV = new System.Windows.Forms.Label();
            this.lbl_PhuCap = new System.Windows.Forms.Label();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.txt_MaCV = new System.Windows.Forms.TextBox();
            this.num_PhuCap = new System.Windows.Forms.NumericUpDown();
            this.GridChucVu = new System.Windows.Forms.DataGridView();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cHUCVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNS_QLLUONGDataSet1 = new CSDL_Test.QLNS_QLLUONGDataSet1();
            this.qLNS_QLLUONGDataSet = new CSDL_Test.QLNS_QLLUONGDataSet();
            this.qLNSQLLUONGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHUCVUTableAdapter = new CSDL_Test.QLNS_QLLUONGDataSet1TableAdapters.CHUCVUTableAdapter();
            this.btn_Taomoi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhuCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSQLLUONGDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChucVu.Location = new System.Drawing.Point(171, 17);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(297, 31);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "THÔNG TIN CHỨC VỤ";
            // 
            // lbl_TenCV
            // 
            this.lbl_TenCV.AutoSize = true;
            this.lbl_TenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_TenCV.Location = new System.Drawing.Point(68, 88);
            this.lbl_TenCV.Name = "lbl_TenCV";
            this.lbl_TenCV.Size = new System.Drawing.Size(143, 25);
            this.lbl_TenCV.TabIndex = 1;
            this.lbl_TenCV.Text = "Tên Chức Vụ:";
            // 
            // lbl_MaCV
            // 
            this.lbl_MaCV.AutoSize = true;
            this.lbl_MaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_MaCV.Location = new System.Drawing.Point(68, 125);
            this.lbl_MaCV.Name = "lbl_MaCV";
            this.lbl_MaCV.Size = new System.Drawing.Size(136, 25);
            this.lbl_MaCV.TabIndex = 1;
            this.lbl_MaCV.Text = "Mã Chức Vụ:";
            // 
            // lbl_PhuCap
            // 
            this.lbl_PhuCap.AutoSize = true;
            this.lbl_PhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_PhuCap.Location = new System.Drawing.Point(68, 169);
            this.lbl_PhuCap.Name = "lbl_PhuCap";
            this.lbl_PhuCap.Size = new System.Drawing.Size(101, 25);
            this.lbl_PhuCap.TabIndex = 1;
            this.lbl_PhuCap.Text = "Phụ Cấp:";
            // 
            // txt_TenCV
            // 
            this.txt_TenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenCV.Location = new System.Drawing.Point(224, 88);
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(270, 31);
            this.txt_TenCV.TabIndex = 2;
            // 
            // txt_MaCV
            // 
            this.txt_MaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaCV.Location = new System.Drawing.Point(224, 125);
            this.txt_MaCV.Name = "txt_MaCV";
            this.txt_MaCV.Size = new System.Drawing.Size(270, 31);
            this.txt_MaCV.TabIndex = 2;
            // 
            // num_PhuCap
            // 
            this.num_PhuCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.num_PhuCap.Location = new System.Drawing.Point(225, 167);
            this.num_PhuCap.Name = "num_PhuCap";
            this.num_PhuCap.Size = new System.Drawing.Size(269, 31);
            this.num_PhuCap.TabIndex = 3;
            // 
            // GridChucVu
            // 
            this.GridChucVu.AutoGenerateColumns = false;
            this.GridChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maCVDataGridViewTextBoxColumn,
            this.tenCVDataGridViewTextBoxColumn,
            this.phucapDataGridViewTextBoxColumn});
            this.GridChucVu.DataSource = this.cHUCVUBindingSource;
            this.GridChucVu.Location = new System.Drawing.Point(74, 225);
            this.GridChucVu.Name = "GridChucVu";
            this.GridChucVu.Size = new System.Drawing.Size(419, 190);
            this.GridChucVu.TabIndex = 4;
            this.GridChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridChucVu_CellContentClick);
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "ma_CV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "ma_CV";
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            // 
            // tenCVDataGridViewTextBoxColumn
            // 
            this.tenCVDataGridViewTextBoxColumn.DataPropertyName = "ten_CV";
            this.tenCVDataGridViewTextBoxColumn.HeaderText = "ten_CV";
            this.tenCVDataGridViewTextBoxColumn.Name = "tenCVDataGridViewTextBoxColumn";
            // 
            // phucapDataGridViewTextBoxColumn
            // 
            this.phucapDataGridViewTextBoxColumn.DataPropertyName = "phu_cap";
            this.phucapDataGridViewTextBoxColumn.HeaderText = "phu_cap";
            this.phucapDataGridViewTextBoxColumn.Name = "phucapDataGridViewTextBoxColumn";
            // 
            // cHUCVUBindingSource
            // 
            this.cHUCVUBindingSource.DataMember = "CHUCVU";
            this.cHUCVUBindingSource.DataSource = this.qLNS_QLLUONGDataSet1;
            // 
            // qLNS_QLLUONGDataSet1
            // 
            this.qLNS_QLLUONGDataSet1.DataSetName = "QLNS_QLLUONGDataSet1";
            this.qLNS_QLLUONGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNS_QLLUONGDataSet
            // 
            this.qLNS_QLLUONGDataSet.DataSetName = "QLNS_QLLUONGDataSet";
            this.qLNS_QLLUONGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLNSQLLUONGDataSetBindingSource
            // 
            this.qLNSQLLUONGDataSetBindingSource.DataSource = this.qLNS_QLLUONGDataSet;
            this.qLNSQLLUONGDataSetBindingSource.Position = 0;
            // 
            // cHUCVUTableAdapter
            // 
            this.cHUCVUTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Taomoi
            // 
            this.btn_Taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Taomoi.Location = new System.Drawing.Point(586, 98);
            this.btn_Taomoi.Name = "btn_Taomoi";
            this.btn_Taomoi.Size = new System.Drawing.Size(103, 37);
            this.btn_Taomoi.TabIndex = 5;
            this.btn_Taomoi.Text = "Tạo mới";
            this.btn_Taomoi.UseVisualStyleBackColor = true;
            this.btn_Taomoi.Click += new System.EventHandler(this.btn_Taomoi_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(586, 157);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(103, 37);
            this.btn_Luu.TabIndex = 5;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(586, 216);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 37);
            this.btn_Sua.TabIndex = 5;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(586, 276);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 37);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(586, 342);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(103, 37);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // FrmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Taomoi);
            this.Controls.Add(this.GridChucVu);
            this.Controls.Add(this.num_PhuCap);
            this.Controls.Add(this.txt_MaCV);
            this.Controls.Add(this.txt_TenCV);
            this.Controls.Add(this.lbl_PhuCap);
            this.Controls.Add(this.lbl_MaCV);
            this.Controls.Add(this.lbl_TenCV);
            this.Controls.Add(this.lblChucVu);
            this.Name = "FrmChucVu";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.FrmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_PhuCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHUCVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNSQLLUONGDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lbl_TenCV;
        private System.Windows.Forms.Label lbl_MaCV;
        private System.Windows.Forms.Label lbl_PhuCap;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.TextBox txt_MaCV;
        private System.Windows.Forms.NumericUpDown num_PhuCap;
        private System.Windows.Forms.DataGridView GridChucVu;
        private System.Windows.Forms.BindingSource qLNSQLLUONGDataSetBindingSource;
        private QLNS_QLLUONGDataSet qLNS_QLLUONGDataSet;
        private QLNS_QLLUONGDataSet1 qLNS_QLLUONGDataSet1;
        private System.Windows.Forms.BindingSource cHUCVUBindingSource;
        private QLNS_QLLUONGDataSet1TableAdapters.CHUCVUTableAdapter cHUCVUTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucapDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Taomoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
    }
}