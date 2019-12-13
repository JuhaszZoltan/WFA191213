namespace WFA191213
{
    partial class FrmMain
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
            this.cbSoforok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHivasok = new System.Windows.Forms.Label();
            this.nko = new System.Windows.Forms.NumericUpDown();
            this.nkp = new System.Windows.Forms.NumericUpDown();
            this.lblIv = new System.Windows.Forms.Label();
            this.nvo = new System.Windows.Forms.NumericUpDown();
            this.nvp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nkp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvp)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSoforok
            // 
            this.cbSoforok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbSoforok.FormattingEnabled = true;
            this.cbSoforok.Location = new System.Drawing.Point(127, 48);
            this.cbSoforok.Name = "cbSoforok";
            this.cbSoforok.Size = new System.Drawing.Size(219, 33);
            this.cbSoforok.TabIndex = 0;
            this.cbSoforok.Text = "válassz a listából!";
            this.cbSoforok.SelectedIndexChanged += new System.EventHandler(this.cbSoforok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sofőr:";
            // 
            // lblHivasok
            // 
            this.lblHivasok.AutoSize = true;
            this.lblHivasok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHivasok.Location = new System.Drawing.Point(378, 51);
            this.lblHivasok.Name = "lblHivasok";
            this.lblHivasok.Size = new System.Drawing.Size(45, 25);
            this.lblHivasok.TabIndex = 2;
            this.lblHivasok.Text = "###";
            // 
            // nko
            // 
            this.nko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nko.Location = new System.Drawing.Point(52, 168);
            this.nko.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nko.Name = "nko";
            this.nko.Size = new System.Drawing.Size(56, 30);
            this.nko.TabIndex = 3;
            // 
            // nkp
            // 
            this.nkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nkp.Location = new System.Drawing.Point(114, 168);
            this.nkp.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nkp.Name = "nkp";
            this.nkp.Size = new System.Drawing.Size(56, 30);
            this.nkp.TabIndex = 3;
            // 
            // lblIv
            // 
            this.lblIv.AutoSize = true;
            this.lblIv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIv.Location = new System.Drawing.Point(390, 170);
            this.lblIv.Name = "lblIv";
            this.lblIv.Size = new System.Drawing.Size(45, 25);
            this.lblIv.TabIndex = 2;
            this.lblIv.Text = "###";
            // 
            // nvo
            // 
            this.nvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nvo.Location = new System.Drawing.Point(223, 168);
            this.nvo.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nvo.Name = "nvo";
            this.nvo.Size = new System.Drawing.Size(56, 30);
            this.nvo.TabIndex = 3;
            this.nvo.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // nvp
            // 
            this.nvp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nvp.Location = new System.Drawing.Point(285, 168);
            this.nvp.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nvp.Name = "nvp";
            this.nvp.Size = new System.Drawing.Size(56, 30);
            this.nvp.TabIndex = 3;
            this.nvp.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nvp);
            this.Controls.Add(this.nvo);
            this.Controls.Add(this.nkp);
            this.Controls.Add(this.nko);
            this.Controls.Add(this.lblIv);
            this.Controls.Add(this.lblHivasok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSoforok);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nkp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSoforok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHivasok;
        private System.Windows.Forms.NumericUpDown nko;
        private System.Windows.Forms.NumericUpDown nkp;
        private System.Windows.Forms.Label lblIv;
        private System.Windows.Forms.NumericUpDown nvo;
        private System.Windows.Forms.NumericUpDown nvp;
    }
}

