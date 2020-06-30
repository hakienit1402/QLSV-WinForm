namespace QLSV
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
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.colMalop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMslop = new System.Windows.Forms.Label();
            this.txtMasolop = new System.Windows.Forms.TextBox();
            this.lblTenlop = new System.Windows.Forms.Label();
            this.txtTenlop = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLop
            // 
            this.dgvLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMalop,
            this.colTenlop});
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLop.Location = new System.Drawing.Point(0, 140);
            this.dgvLop.MultiSelect = false;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLop.Size = new System.Drawing.Size(790, 285);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellDoubleClick);
            this.dgvLop.SelectionChanged += new System.EventHandler(this.dgvLop_SelectionChanged);
            // 
            // colMalop
            // 
            this.colMalop.DataPropertyName = "MaLop";
            this.colMalop.HeaderText = "Mã Lớp";
            this.colMalop.Name = "colMalop";
            // 
            // colTenlop
            // 
            this.colTenlop.DataPropertyName = "TenLop";
            this.colTenlop.HeaderText = "Tên Lớp";
            this.colTenlop.Name = "colTenlop";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(99, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(64, 23);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(238, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMslop
            // 
            this.lblMslop.AutoSize = true;
            this.lblMslop.Location = new System.Drawing.Point(30, 24);
            this.lblMslop.Name = "lblMslop";
            this.lblMslop.Size = new System.Drawing.Size(53, 13);
            this.lblMslop.TabIndex = 3;
            this.lblMslop.Text = "Mã số lớp";
            // 
            // txtMasolop
            // 
            this.txtMasolop.Location = new System.Drawing.Point(99, 21);
            this.txtMasolop.Name = "txtMasolop";
            this.txtMasolop.Size = new System.Drawing.Size(203, 20);
            this.txtMasolop.TabIndex = 4;
            // 
            // lblTenlop
            // 
            this.lblTenlop.AutoSize = true;
            this.lblTenlop.Location = new System.Drawing.Point(30, 66);
            this.lblTenlop.Name = "lblTenlop";
            this.lblTenlop.Size = new System.Drawing.Size(43, 13);
            this.lblTenlop.TabIndex = 5;
            this.lblTenlop.Text = "Tên lớp";
            // 
            // txtTenlop
            // 
            this.txtTenlop.Location = new System.Drawing.Point(99, 63);
            this.txtTenlop.Name = "txtTenlop";
            this.txtTenlop.Size = new System.Drawing.Size(203, 20);
            this.txtTenlop.TabIndex = 6;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(169, 98);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(63, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(376, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(308, 98);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(64, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 425);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtTenlop);
            this.Controls.Add(this.lblTenlop);
            this.Controls.Add(this.txtMasolop);
            this.Controls.Add(this.lblMslop);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLop);
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMslop;
        private System.Windows.Forms.TextBox txtMasolop;
        private System.Windows.Forms.Label lblTenlop;
        private System.Windows.Forms.TextBox txtTenlop;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMalop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenlop;
    }
}

