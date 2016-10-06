namespace QL_HSGV
{
    partial class Frm_GV
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
            this.DTGV_GV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_GV)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV_GV
            // 
            this.DTGV_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_GV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGV_GV.Location = new System.Drawing.Point(0, 0);
            this.DTGV_GV.Name = "DTGV_GV";
            this.DTGV_GV.Size = new System.Drawing.Size(949, 407);
            this.DTGV_GV.TabIndex = 0;
            // 
            // Frm_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 407);
            this.Controls.Add(this.DTGV_GV);
            this.Name = "Frm_GV";
            this.Text = "Frm_GV";
            this.Load += new System.EventHandler(this.Frm_GV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_GV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV_GV;
    }
}