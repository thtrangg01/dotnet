
namespace CSDL_Test
{
    partial class FrmPhongBan
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
            this.lblMaPB = new System.Windows.Forms.Label();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.DataGrid_PhongBan = new System.Windows.Forms.DataGridView();
            this.maPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienthoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONGBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNS_QLLUONGDataSet = new CSDL_Test.QLNS_QLLUONGDataSet();
            this.pHONGBANTableAdapter = new CSDL_Test.QLNS_QLLUONGDataSetTableAdapters.PHONGBANTableAdapter();
            this.txtMaPB = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.btn_Taomoi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_PhongBan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_PhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPB.Location = new System.Drawing.Point(36, 96);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(138, 24);
            this.lblMaPB.TabIndex = 0;
            this.lblMaPB.Text = "Mã phòng ban:";
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenPB.Location = new System.Drawing.Point(36, 130);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(146, 24);
            this.lblTenPB.TabIndex = 0;
            this.lblTenPB.Text = "Tên phòng ban:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.Location = new System.Drawing.Point(36, 165);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(99, 24);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Điện thoại:";
            // 
            // DataGrid_PhongBan
            // 
            this.DataGrid_PhongBan.AutoGenerateColumns = false;
            this.DataGrid_PhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_PhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPBDataGridViewTextBoxColumn,
            this.tenPBDataGridViewTextBoxColumn,
            this.dienthoaiDataGridViewTextBoxColumn});
            this.DataGrid_PhongBan.DataSource = this.pHONGBANBindingSource;
            this.DataGrid_PhongBan.Location = new System.Drawing.Point(40, 212);
            this.DataGrid_PhongBan.Name = "DataGrid_PhongBan";
            this.DataGrid_PhongBan.Size = new System.Drawing.Size(503, 216);
            this.DataGrid_PhongBan.TabIndex = 1;
            this.DataGrid_PhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_PhongBan_CellContentClick);
            // 
            // maPBDataGridViewTextBoxColumn
            // 
            this.maPBDataGridViewTextBoxColumn.DataPropertyName = "ma_PB";
            this.maPBDataGridViewTextBoxColumn.HeaderText = "ma_PB";
            this.maPBDataGridViewTextBoxColumn.Name = "maPBDataGridViewTextBoxColumn";
            // 
            // tenPBDataGridViewTextBoxColumn
            // 
            this.tenPBDataGridViewTextBoxColumn.DataPropertyName = "ten_PB";
            this.tenPBDataGridViewTextBoxColumn.HeaderText = "ten_PB";
            this.tenPBDataGridViewTextBoxColumn.Name = "tenPBDataGridViewTextBoxColumn";
            // 
            // dienthoaiDataGridViewTextBoxColumn
            // 
            this.dienthoaiDataGridViewTextBoxColumn.DataPropertyName = "dien_thoai";
            this.dienthoaiDataGridViewTextBoxColumn.HeaderText = "dien_thoai";
            this.dienthoaiDataGridViewTextBoxColumn.Name = "dienthoaiDataGridViewTextBoxColumn";
            // 
            // pHONGBANBindingSource
            // 
            this.pHONGBANBindingSource.DataMember = "PHONGBAN";
            this.pHONGBANBindingSource.DataSource = this.qLNS_QLLUONGDataSet;
            // 
            // qLNS_QLLUONGDataSet
            // 
            this.qLNS_QLLUONGDataSet.DataSetName = "QLNS_QLLUONGDataSet";
            this.qLNS_QLLUONGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBANTableAdapter
            // 
            this.pHONGBANTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaPB
            // 
            this.txtMaPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPB.Location = new System.Drawing.Point(188, 96);
            this.txtMaPB.Name = "txtMaPB";
            this.txtMaPB.Size = new System.Drawing.Size(289, 22);
            this.txtMaPB.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSDT.Location = new System.Drawing.Point(188, 167);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(289, 22);
            this.txtSDT.TabIndex = 2;
            // 
            // txtTenPB
            // 
            this.txtTenPB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPB.Location = new System.Drawing.Point(188, 130);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(289, 22);
            this.txtTenPB.TabIndex = 2;
            // 
            // btn_Taomoi
            // 
            this.btn_Taomoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Taomoi.Location = new System.Drawing.Point(607, 96);
            this.btn_Taomoi.Name = "btn_Taomoi";
            this.btn_Taomoi.Size = new System.Drawing.Size(107, 45);
            this.btn_Taomoi.TabIndex = 3;
            this.btn_Taomoi.Text = "Tạo mới";
            this.btn_Taomoi.UseVisualStyleBackColor = true;
            this.btn_Taomoi.Click += new System.EventHandler(this.btn_Taomoi_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Location = new System.Drawing.Point(607, 155);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(107, 42);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Location = new System.Drawing.Point(607, 212);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 42);
            this.btn_Sua.TabIndex = 4;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(607, 275);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 42);
            this.btn_Xoa.TabIndex = 4;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.Location = new System.Drawing.Point(607, 334);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 42);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lbl_PhongBan
            // 
            this.lbl_PhongBan.AutoSize = true;
            this.lbl_PhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_PhongBan.Location = new System.Drawing.Point(208, 18);
            this.lbl_PhongBan.Name = "lbl_PhongBan";
            this.lbl_PhongBan.Size = new System.Drawing.Size(335, 31);
            this.lbl_PhongBan.TabIndex = 5;
            this.lbl_PhongBan.Text = "THÔNG TIN PHÒNG BAN";
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PhongBan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Taomoi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.txtMaPB);
            this.Controls.Add(this.DataGrid_PhongBan);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblTenPB);
            this.Controls.Add(this.lblMaPB);
            this.Name = "FrmPhongBan";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.FrmTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_PhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNS_QLLUONGDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.DataGridView DataGrid_PhongBan;
        private QLNS_QLLUONGDataSet qLNS_QLLUONGDataSet;
        private System.Windows.Forms.BindingSource pHONGBANBindingSource;
        private QLNS_QLLUONGDataSetTableAdapters.PHONGBANTableAdapter pHONGBANTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtMaPB;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Button btn_Taomoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_PhongBan;
    }
}