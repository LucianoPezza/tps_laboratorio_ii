namespace FormPrincipal
{
    partial class FormVentaDeEntradas2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.cmbEs3dONo = new System.Windows.Forms.ComboBox();
            this.lbl3DoNo = new System.Windows.Forms.Label();
            this.cmbCantidadDeEntradas = new System.Windows.Forms.ComboBox();
            this.lblCantidadDeEntradas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormPrincipal.Properties.Resources.monster_village_neuquen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.Gold;
            this.btnVender.Location = new System.Drawing.Point(12, 356);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(92, 36);
            this.btnVender.TabIndex = 1;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // cmbEs3dONo
            // 
            this.cmbEs3dONo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbEs3dONo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEs3dONo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbEs3dONo.ForeColor = System.Drawing.Color.Gold;
            this.cmbEs3dONo.FormattingEnabled = true;
            this.cmbEs3dONo.Location = new System.Drawing.Point(12, 57);
            this.cmbEs3dONo.Name = "cmbEs3dONo";
            this.cmbEs3dONo.Size = new System.Drawing.Size(121, 28);
            this.cmbEs3dONo.TabIndex = 2;
            // 
            // lbl3DoNo
            // 
            this.lbl3DoNo.AutoSize = true;
            this.lbl3DoNo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl3DoNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3DoNo.ForeColor = System.Drawing.Color.Gold;
            this.lbl3DoNo.Location = new System.Drawing.Point(12, 33);
            this.lbl3DoNo.Name = "lbl3DoNo";
            this.lbl3DoNo.Size = new System.Drawing.Size(162, 21);
            this.lbl3DoNo.TabIndex = 3;
            this.lbl3DoNo.Text = "Seleccionar 3D o 2D";
            // 
            // cmbCantidadDeEntradas
            // 
            this.cmbCantidadDeEntradas.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbCantidadDeEntradas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidadDeEntradas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbCantidadDeEntradas.ForeColor = System.Drawing.Color.Gold;
            this.cmbCantidadDeEntradas.FormattingEnabled = true;
            this.cmbCantidadDeEntradas.Location = new System.Drawing.Point(219, 57);
            this.cmbCantidadDeEntradas.Name = "cmbCantidadDeEntradas";
            this.cmbCantidadDeEntradas.Size = new System.Drawing.Size(121, 28);
            this.cmbCantidadDeEntradas.TabIndex = 4;
            // 
            // lblCantidadDeEntradas
            // 
            this.lblCantidadDeEntradas.AutoSize = true;
            this.lblCantidadDeEntradas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCantidadDeEntradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadDeEntradas.ForeColor = System.Drawing.Color.Gold;
            this.lblCantidadDeEntradas.Location = new System.Drawing.Point(219, 33);
            this.lblCantidadDeEntradas.Name = "lblCantidadDeEntradas";
            this.lblCantidadDeEntradas.Size = new System.Drawing.Size(262, 21);
            this.lblCantidadDeEntradas.TabIndex = 5;
            this.lblCantidadDeEntradas.Text = "Seleccionar cantidad de entradas";
            // 
            // FormVentaDeEntradas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(617, 404);
            this.Controls.Add(this.lblCantidadDeEntradas);
            this.Controls.Add(this.cmbCantidadDeEntradas);
            this.Controls.Add(this.lbl3DoNo);
            this.Controls.Add(this.cmbEs3dONo);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVentaDeEntradas2";
            this.Text = "FormVentaDeEntradas2";
            this.Load += new System.EventHandler(this.FormVentaDeEntradas2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ComboBox cmbEs3dONo;
        private System.Windows.Forms.Label lbl3DoNo;
        private System.Windows.Forms.ComboBox cmbCantidadDeEntradas;
        private System.Windows.Forms.Label lblCantidadDeEntradas;
    }
}