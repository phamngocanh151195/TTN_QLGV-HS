namespace QL_HSGV
{
    partial class Frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DangNhap));
            this.txtU = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.btn_DN = new System.Windows.Forms.Button();
            this.btn_RF = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtU
            // 
            this.txtU.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtU.Location = new System.Drawing.Point(144, 158);
            this.txtU.Multiline = true;
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(279, 43);
            this.txtU.TabIndex = 0;
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(144, 212);
            this.txtP.Multiline = true;
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(279, 43);
            this.txtP.TabIndex = 1;
            // 
            // btn_DN
            // 
            this.btn_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DN.Location = new System.Drawing.Point(142, 262);
            this.btn_DN.Name = "btn_DN";
            this.btn_DN.Size = new System.Drawing.Size(94, 41);
            this.btn_DN.TabIndex = 2;
            this.btn_DN.Text = "Đăng nhập";
            this.btn_DN.UseVisualStyleBackColor = true;
            this.btn_DN.Click += new System.EventHandler(this.btn_DN_Click);
            // 
            // btn_RF
            // 
            this.btn_RF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RF.Location = new System.Drawing.Point(242, 262);
            this.btn_RF.Name = "btn_RF";
            this.btn_RF.Size = new System.Drawing.Size(81, 41);
            this.btn_RF.TabIndex = 3;
            this.btn_RF.Text = "Refresh";
            this.btn_RF.UseVisualStyleBackColor = true;
            this.btn_RF.Click += new System.EventHandler(this.btn_RF_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(329, 262);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(95, 41);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.OrangeRed;
            this.label.Location = new System.Drawing.Point(176, 306);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(215, 28);
            this.label.TabIndex = 5;
            // 
            // Frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(628, 395);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_RF);
            this.Controls.Add(this.btn_DN);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtU);
            this.Name = "Frm_DangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Frm_DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtU;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button btn_DN;
        private System.Windows.Forms.Button btn_RF;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label;
    }
}