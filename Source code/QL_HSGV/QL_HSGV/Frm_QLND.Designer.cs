﻿namespace QL_HSGV
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
            this.DTGV = new System.Windows.Forms.DataGridView();
            this.RdB_Them = new System.Windows.Forms.RadioButton();
            this.RdB_Sua = new System.Windows.Forms.RadioButton();
            this.RdB_Xoa = new System.Windows.Forms.RadioButton();
            this.RdB_TK = new System.Windows.Forms.RadioButton();
            this.txt_U = new System.Windows.Forms.TextBox();
            this.txt_P = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV
            // 
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Location = new System.Drawing.Point(32, 94);
            this.DTGV.Name = "DTGV";
            this.DTGV.Size = new System.Drawing.Size(459, 177);
            this.DTGV.TabIndex = 0;
            this.DTGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGV_CellClick);
            // 
            // RdB_Them
            // 
            this.RdB_Them.AutoSize = true;
            this.RdB_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdB_Them.Location = new System.Drawing.Point(4, 16);
            this.RdB_Them.Name = "RdB_Them";
            this.RdB_Them.Size = new System.Drawing.Size(64, 22);
            this.RdB_Them.TabIndex = 1;
            this.RdB_Them.TabStop = true;
            this.RdB_Them.Text = "Thêm";
            this.RdB_Them.UseVisualStyleBackColor = true;
            this.RdB_Them.Click += new System.EventHandler(this.RdB_Them_Click);
            // 
            // RdB_Sua
            // 
            this.RdB_Sua.AutoSize = true;
            this.RdB_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdB_Sua.Location = new System.Drawing.Point(74, 16);
            this.RdB_Sua.Name = "RdB_Sua";
            this.RdB_Sua.Size = new System.Drawing.Size(52, 22);
            this.RdB_Sua.TabIndex = 2;
            this.RdB_Sua.TabStop = true;
            this.RdB_Sua.Text = "Sửa";
            this.RdB_Sua.UseVisualStyleBackColor = true;
            this.RdB_Sua.Click += new System.EventHandler(this.RdB_Sua_Click);
            // 
            // RdB_Xoa
            // 
            this.RdB_Xoa.AutoSize = true;
            this.RdB_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdB_Xoa.Location = new System.Drawing.Point(132, 16);
            this.RdB_Xoa.Name = "RdB_Xoa";
            this.RdB_Xoa.Size = new System.Drawing.Size(53, 22);
            this.RdB_Xoa.TabIndex = 3;
            this.RdB_Xoa.TabStop = true;
            this.RdB_Xoa.Text = "Xóa";
            this.RdB_Xoa.UseVisualStyleBackColor = true;
            this.RdB_Xoa.Click += new System.EventHandler(this.RdB_Xoa_Click);
            // 
            // RdB_TK
            // 
            this.RdB_TK.AutoSize = true;
            this.RdB_TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdB_TK.Location = new System.Drawing.Point(191, 16);
            this.RdB_TK.Name = "RdB_TK";
            this.RdB_TK.Size = new System.Drawing.Size(87, 22);
            this.RdB_TK.TabIndex = 4;
            this.RdB_TK.TabStop = true;
            this.RdB_TK.Text = "Tìm kiếm";
            this.RdB_TK.UseVisualStyleBackColor = true;
            this.RdB_TK.Click += new System.EventHandler(this.RdB_TK_Click);
            // 
            // txt_U
            // 
            this.txt_U.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_U.Location = new System.Drawing.Point(58, 48);
            this.txt_U.Name = "txt_U";
            this.txt_U.Size = new System.Drawing.Size(143, 24);
            this.txt_U.TabIndex = 5;
            this.txt_U.TextChanged += new System.EventHandler(this.txt_U_TextChanged);
            // 
            // txt_P
            // 
            this.txt_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_P.Location = new System.Drawing.Point(286, 44);
            this.txt_P.Name = "txt_P";
            this.txt_P.Size = new System.Drawing.Size(149, 24);
            this.txt_P.TabIndex = 6;
            this.txt_P.TextChanged += new System.EventHandler(this.txt_P_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(441, 42);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(67, 26);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // Frm_QLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 283);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_P);
            this.Controls.Add(this.txt_U);
            this.Controls.Add(this.RdB_TK);
            this.Controls.Add(this.RdB_Xoa);
            this.Controls.Add(this.RdB_Sua);
            this.Controls.Add(this.RdB_Them);
            this.Controls.Add(this.DTGV);
            this.Name = "Frm_QLND";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.Frm_QLND_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV;
        private System.Windows.Forms.RadioButton RdB_Them;
        private System.Windows.Forms.RadioButton RdB_Sua;
        private System.Windows.Forms.RadioButton RdB_Xoa;
        private System.Windows.Forms.RadioButton RdB_TK;
        private System.Windows.Forms.TextBox txt_U;
        private System.Windows.Forms.TextBox txt_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Luu;
    }
}