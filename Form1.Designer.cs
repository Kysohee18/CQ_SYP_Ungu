namespace PraktikumADO4
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitungdsn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(108, 350);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 29);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(229, 350);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(93, 29);
            this.btnHitungMhs.TabIndex = 1;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click_1);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(351, 350);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(93, 29);
            this.btnHitungMK.TabIndex = 4;
            this.btnHitungMK.Text = "Hitung Mk";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(465, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "HASIL";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(244, 127);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(242, 22);
            this.txtHasil.TabIndex = 8;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // btnHitungdsn
            // 
            this.btnHitungdsn.Location = new System.Drawing.Point(108, 385);
            this.btnHitungdsn.Name = "btnHitungdsn";
            this.btnHitungdsn.Size = new System.Drawing.Size(103, 29);
            this.btnHitungdsn.TabIndex = 9;
            this.btnHitungdsn.Text = "HitungDosen";
            this.btnHitungdsn.UseVisualStyleBackColor = true;
            this.btnHitungdsn.Click += new System.EventHandler(this.btnHitungdsn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btnHitungdsn);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitungdsn;
    }
}

