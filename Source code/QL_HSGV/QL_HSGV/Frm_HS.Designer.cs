namespace QL_HSGV
{
    partial class Frm_HS
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
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGV
            // 
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGV.Location = new System.Drawing.Point(0, 0);
            this.DTGV.Name = "DTGV";
            this.DTGV.Size = new System.Drawing.Size(981, 408);
            this.DTGV.TabIndex = 0;
            // 
            // Frm_HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 408);
            this.Controls.Add(this.DTGV);
            this.Name = "Frm_HS";
            this.Text = "Frm_HS";
            this.Load += new System.EventHandler(this.Frm_HS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGV;
    }
}