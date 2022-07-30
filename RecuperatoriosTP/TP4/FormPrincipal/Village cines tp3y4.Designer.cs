namespace FormPrincipal
{
    partial class FormVillagePrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblTotalRecaudado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGuaradarComo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormPrincipal.Properties.Resources.village_merlo_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1158, 570);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bienvenido a VillageCines";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVender.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.ForeColor = System.Drawing.Color.Gold;
            this.btnVender.Location = new System.Drawing.Point(12, 515);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(321, 67);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender Entradas";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalRecaudado
            // 
            this.lblTotalRecaudado.AutoSize = true;
            this.lblTotalRecaudado.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalRecaudado.ForeColor = System.Drawing.Color.Gold;
            this.lblTotalRecaudado.Location = new System.Drawing.Point(758, 558);
            this.lblTotalRecaudado.Name = "lblTotalRecaudado";
            this.lblTotalRecaudado.Size = new System.Drawing.Size(194, 24);
            this.lblTotalRecaudado.TabIndex = 6;
            this.lblTotalRecaudado.Text = "Total Recaudado: ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.Color.Gold;
            this.btnGuardar.Location = new System.Drawing.Point(12, 375);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(166, 134);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar \r\nEn json o xml\r\n";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnGuaradarComo
            // 
            this.btnGuaradarComo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuaradarComo.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuaradarComo.ForeColor = System.Drawing.Color.Gold;
            this.btnGuaradarComo.Location = new System.Drawing.Point(184, 375);
            this.btnGuaradarComo.Name = "btnGuaradarComo";
            this.btnGuaradarComo.Size = new System.Drawing.Size(149, 134);
            this.btnGuaradarComo.TabIndex = 10;
            this.btnGuaradarComo.Text = "Guardar Como en \r\nxml o json\r\n";
            this.btnGuaradarComo.UseVisualStyleBackColor = false;
            this.btnGuaradarComo.Click += new System.EventHandler(this.btnGuaradarComo_Click);
            // 
            // FormVillagePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1182, 594);
            this.Controls.Add(this.btnGuaradarComo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotalRecaudado);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormVillagePrincipal";
            this.Text = "Village CInes TP4y3";
            this.Load += new System.EventHandler(this.FormVillagePrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblTotalRecaudado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnGuaradarComo;
    }
}
