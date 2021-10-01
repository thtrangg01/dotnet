
namespace CSDL_Test
{
    partial class FrmTimKiem
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
            this.lblTK = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.GridTimKiem = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.optNhapMa = new System.Windows.Forms.RadioButton();
            this.optNhapTen = new System.Windows.Forms.RadioButton();
            this.optNhapMa1 = new System.Windows.Forms.RadioButton();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cboMa = new System.Windows.Forms.ComboBox();
            this.optNhapMaCV = new System.Windows.Forms.RadioButton();
            this.cboMaCV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTK.Location = new System.Drawing.Point(170, 27);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(312, 33);
            this.lblTK.TabIndex = 0;
            this.lblTK.Text = "TÌM KIẾM THÔNG TIN";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMa.Location = new System.Drawing.Point(128, 121);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(0, 25);
            this.lblMa.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMa.Location = new System.Drawing.Point(279, 68);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(321, 31);
            this.txtMa.TabIndex = 2;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // GridTimKiem
            // 
            this.GridTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTimKiem.Location = new System.Drawing.Point(93, 244);
            this.GridTimKiem.Name = "GridTimKiem";
            this.GridTimKiem.Size = new System.Drawing.Size(527, 194);
            this.GridTimKiem.TabIndex = 3;
            this.GridTimKiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridTimKiem_CellContentClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(639, 88);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 46);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(639, 156);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // optNhapMa
            // 
            this.optNhapMa.AutoSize = true;
            this.optNhapMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMa.Location = new System.Drawing.Point(102, 70);
            this.optNhapMa.Name = "optNhapMa";
            this.optNhapMa.Size = new System.Drawing.Size(122, 29);
            this.optNhapMa.TabIndex = 5;
            this.optNhapMa.TabStop = true;
            this.optNhapMa.Text = "Nhập mã:";
            this.optNhapMa.UseVisualStyleBackColor = true;
            this.optNhapMa.CheckedChanged += new System.EventHandler(this.optNhapMa_CheckedChanged);
            // 
            // optNhapTen
            // 
            this.optNhapTen.AutoSize = true;
            this.optNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapTen.Location = new System.Drawing.Point(101, 115);
            this.optNhapTen.Name = "optNhapTen";
            this.optNhapTen.Size = new System.Drawing.Size(123, 29);
            this.optNhapTen.TabIndex = 5;
            this.optNhapTen.TabStop = true;
            this.optNhapTen.Text = "Nhập tên:";
            this.optNhapTen.UseVisualStyleBackColor = true;
            this.optNhapTen.CheckedChanged += new System.EventHandler(this.optNhapTen_CheckedChanged);
            // 
            // optNhapMa1
            // 
            this.optNhapMa1.AutoSize = true;
            this.optNhapMa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMa1.Location = new System.Drawing.Point(102, 160);
            this.optNhapMa1.Name = "optNhapMa1";
            this.optNhapMa1.Size = new System.Drawing.Size(156, 29);
            this.optNhapMa1.TabIndex = 5;
            this.optNhapMa1.TabStop = true;
            this.optNhapMa1.Text = "Nhập mã PB:";
            this.optNhapMa1.UseVisualStyleBackColor = true;
            this.optNhapMa1.CheckedChanged += new System.EventHandler(this.optNhapMa1_CheckedChanged);
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTen.Location = new System.Drawing.Point(279, 115);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(321, 31);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // cboMa
            // 
            this.cboMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMa.FormattingEnabled = true;
            this.cboMa.Location = new System.Drawing.Point(279, 156);
            this.cboMa.Name = "cboMa";
            this.cboMa.Size = new System.Drawing.Size(321, 33);
            this.cboMa.TabIndex = 6;
            // 
            // optNhapMaCV
            // 
            this.optNhapMaCV.AutoSize = true;
            this.optNhapMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.optNhapMaCV.Location = new System.Drawing.Point(102, 203);
            this.optNhapMaCV.Name = "optNhapMaCV";
            this.optNhapMaCV.Size = new System.Drawing.Size(157, 29);
            this.optNhapMaCV.TabIndex = 7;
            this.optNhapMaCV.TabStop = true;
            this.optNhapMaCV.Text = "Nhập mã CV:";
            this.optNhapMaCV.UseVisualStyleBackColor = true;
            this.optNhapMaCV.CheckedChanged += new System.EventHandler(this.optNhapMaCV_CheckedChanged);
            // 
            // cboMaCV
            // 
            this.cboMaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMaCV.FormattingEnabled = true;
            this.cboMaCV.Location = new System.Drawing.Point(279, 202);
            this.cboMaCV.Name = "cboMaCV";
            this.cboMaCV.Size = new System.Drawing.Size(321, 33);
            this.cboMaCV.TabIndex = 8;
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboMaCV);
            this.Controls.Add(this.optNhapMaCV);
            this.Controls.Add(this.cboMa);
            this.Controls.Add(this.optNhapMa1);
            this.Controls.Add(this.optNhapTen);
            this.Controls.Add(this.optNhapMa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.GridTimKiem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTK);
            this.Name = "FrmTimKiem";
            this.Text = " Tìm Kiếm";
            this.Load += new System.EventHandler(this.FrmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView GridTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton optNhapMa;
        private System.Windows.Forms.RadioButton optNhapTen;
        private System.Windows.Forms.RadioButton optNhapMa1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cboMa;
        private System.Windows.Forms.RadioButton optNhapMaCV;
        private System.Windows.Forms.ComboBox cboMaCV;
    }
}