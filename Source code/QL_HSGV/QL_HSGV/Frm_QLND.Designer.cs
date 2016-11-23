namespace QL_HSGV
{
    partial class Frm_QLND
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QLND));
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.btn_RF = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Quyen = new System.Windows.Forms.TextBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.txt_U = new System.Windows.Forms.TextBox();
            this.Uutien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.DTGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Image = ((System.Drawing.Image)(resources.GetObject("btn_Timkiem.Image")));
            this.btn_Timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Timkiem.Location = new System.Drawing.Point(297, 3);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(78, 35);
            this.btn_Timkiem.TabIndex = 47;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // btn_RF
            // 
            this.btn_RF.Image = ((System.Drawing.Image)(resources.GetObject("btn_RF.Image")));
            this.btn_RF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RF.Location = new System.Drawing.Point(213, 3);
            this.btn_RF.Name = "btn_RF";
            this.btn_RF.Size = new System.Drawing.Size(78, 35);
            this.btn_RF.TabIndex = 46;
            this.btn_RF.Text = "Làm mới";
            this.btn_RF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_RF.UseVisualStyleBackColor = true;
            this.btn_RF.Click += new System.EventHandler(this.btn_RF_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Image")));
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(143, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(64, 35);
            this.btn_Xoa.TabIndex = 45;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua.Image")));
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(73, 3);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(64, 35);
            this.btn_Sua.TabIndex = 44;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them.Image")));
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(3, 3);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(64, 35);
            this.btn_Them.TabIndex = 43;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tên";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(421, 64);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(143, 24);
            this.txt_Ten.TabIndex = 41;
            this.txt_Ten.TextChanged += new System.EventHandler(this.txt_Ten_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Quyền";
            // 
            // txt_Quyen
            // 
            this.txt_Quyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quyen.Location = new System.Drawing.Point(641, 64);
            this.txt_Quyen.Name = "txt_Quyen";
            this.txt_Quyen.Size = new System.Drawing.Size(44, 24);
            this.txt_Quyen.TabIndex = 39;
            this.txt_Quyen.TextChanged += new System.EventHandler(this.txt_Quyen_TextChanged_1);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Luu.Location = new System.Drawing.Point(627, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(64, 35);
            this.btn_Luu.TabIndex = 38;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "User";
            // 
            // txt_P
            // 
            this.txt_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P.Location = new System.Drawing.Point(262, 64);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(104, 24);
            this.txt_P.TabIndex = 35;
            this.txt_P.TextChanged += new System.EventHandler(this.txt_P_TextChanged);
            // 
            // txt_U
            // 
            this.txt_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_U.Location = new System.Drawing.Point(61, 68);
            this.txt_U.Name = "txt_U";
            this.txt_U.Size = new System.Drawing.Size(107, 24);
            this.txt_U.TabIndex = 34;
            this.txt_U.TextChanged += new System.EventHandler(this.txt_U_TextChanged);
            // 
            // Uutien
            // 
            this.Uutien.DataPropertyName = "Uutien";
            this.Uutien.FillWeight = 120F;
            this.Uutien.HeaderText = "Quyền truy cập";
            this.Uutien.Name = "Uutien";
            this.Uutien.Width = 120;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Tên";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Pass
            // 
            this.Pass.DataPropertyName = "Pass";
            this.Pass.FillWeight = 150F;
            this.Pass.HeaderText = "Mật khẩu";
            this.Pass.Name = "Pass";
            this.Pass.Width = 150;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.FillWeight = 150F;
            this.Username.HeaderText = "Tài khoản";
            this.Username.Name = "Username";
            this.Username.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Password";
            // 
            // DTGV
            // 
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Pass,
            this.Column1,
            this.Uutien});
            this.DTGV.Location = new System.Drawing.Point(18, 120);
            this.DTGV.Name = "DTGV";
            this.DTGV.Size = new System.Drawing.Size(659, 237);
            this.DTGV.TabIndex = 33;
            this.DTGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CellClick);
            // 
            // Frm_QLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 365);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.btn_RF);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Quyen);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.txt_U);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTGV);
            this.Name = "Frm_QLND";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.Frm_QLND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_RF;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Quyen;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.TextBox txt_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uutien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DTGV;

    }
}