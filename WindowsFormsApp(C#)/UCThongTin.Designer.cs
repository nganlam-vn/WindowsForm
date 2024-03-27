namespace WindowsFormsApp_C__
{
    partial class UCThongTin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblAddress = new Label();
            lblID = new Label();
            lblDOB = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtID = new TextBox();
            dtDOB = new DateTimePicker();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            gvThongTin = new DataGridView();
            lblSDT = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            lblGioiTinh = new Label();
            txtGioiTinh = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvThongTin).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 32);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và Tên :";
            lblName.Click += lblName_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(70, 211);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(99, 32);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Địa chỉ :";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(70, 277);
            lblID.Name = "lblID";
            lblID.Size = new Size(132, 32);
            lblID.TabIndex = 2;
            lblID.Text = "Số CMND :";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(70, 468);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(268, 32);
            lblDOB.TabIndex = 3;
            lblDOB.Text = "Ngày Tháng Năm Sinh :";
            // 
            // txtName
            // 
            txtName.Location = new Point(355, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(436, 39);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(355, 211);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(436, 39);
            txtAddress.TabIndex = 5;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(355, 277);
            txtID.Name = "txtID";
            txtID.Size = new Size(436, 39);
            txtID.TabIndex = 6;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // dtDOB
            // 
            dtDOB.Location = new Point(355, 461);
            dtDOB.Name = "dtDOB";
            dtDOB.Size = new Size(474, 39);
            dtDOB.TabIndex = 7;
            dtDOB.ValueChanged += dtDOB_ValueChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(153, 567);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 46);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(421, 564);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(152, 49);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(707, 567);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(156, 49);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // gvThongTin
            // 
            gvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvThongTin.Location = new Point(954, 38);
            gvThongTin.Name = "gvThongTin";
            gvThongTin.RowHeadersWidth = 82;
            gvThongTin.Size = new Size(466, 431);
            gvThongTin.TabIndex = 11;
            gvThongTin.CellContentClick += gvThongTin_CellContentClick;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(70, 406);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(176, 32);
            lblSDT.TabIndex = 12;
            lblSDT.Text = "Số Điện Thoại :";
            lblSDT.Click += label1_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(70, 344);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(355, 344);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(436, 39);
            txtEmail.TabIndex = 14;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(355, 406);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(436, 39);
            txtSDT.TabIndex = 15;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(70, 148);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(110, 32);
            lblGioiTinh.TabIndex = 16;
            lblGioiTinh.Text = "Giới Tính";
            lblGioiTinh.Click += label1_Click_1;
            // 
            // txtGioiTinh
            // 
            txtGioiTinh.Location = new Point(355, 157);
            txtGioiTinh.Name = "txtGioiTinh";
            txtGioiTinh.Size = new Size(121, 39);
            txtGioiTinh.TabIndex = 17;
            txtGioiTinh.TextChanged += textBox1_TextChanged;
            // 
            // UCThongTin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtGioiTinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(gvThongTin);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dtDOB);
            Controls.Add(txtID);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(lblDOB);
            Controls.Add(lblID);
            Controls.Add(lblAddress);
            Name = "UCThongTin";
            Size = new Size(1662, 707);
            Load += UCThongTin_Load;
            ((System.ComponentModel.ISupportInitialize)gvThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private Label lblID;
        private Label lblDOB;
        public TextBox txtName;
        public TextBox txtAddress;
        public TextBox txtID;
        public DateTimePicker dtDOB;
        public Button btnThem;
        public Button btnXoa;
        public Button btnSua;
        public DataGridView gvThongTin;
        private Label lblSDT;
        private Label lblEmail;
        public TextBox txtEmail;
        public TextBox txtSDT;
        private Label lblGioiTinh;
        public TextBox txtGioiTinh;
    }
}
