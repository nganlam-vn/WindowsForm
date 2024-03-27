namespace WindowsFormsApp_C__
{
    partial class FHocSinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSwitchGV = new Button();
            ucThongTin1 = new UCThongTin();
            SuspendLayout();
            // 
            // btnSwitchGV
            // 
            btnSwitchGV.Location = new Point(1054, 578);
            btnSwitchGV.Name = "btnSwitchGV";
            btnSwitchGV.Size = new Size(324, 48);
            btnSwitchGV.TabIndex = 1;
            btnSwitchGV.Text = "Nhập cho Giáo Viên";
            btnSwitchGV.UseVisualStyleBackColor = true;
            btnSwitchGV.Click += btnSwitchGV_Click;
            // 
            // ucThongTin1
            // 
            ucThongTin1.Location = new Point(12, 12);
            ucThongTin1.Name = "ucThongTin1";
            ucThongTin1.Size = new Size(1544, 650);
            ucThongTin1.TabIndex = 0;
            ucThongTin1.Load += ucThongTin1_Load;
            // 
            // FHocSinh
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 668);
            Controls.Add(btnSwitchGV);
            Controls.Add(ucThongTin1);
            Name = "FHocSinh";
            Text = "HocSinh";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnSwitchGV;
        private UCThongTin ucThongTin1;
    }
}
