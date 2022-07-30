namespace FormPrincipal
{
    partial class FormVentaDeEntradas_
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
            this.dtgEntradas = new System.Windows.Forms.DataGridView();
            this.btnVenderEntradas = new System.Windows.Forms.Button();
            this.lblValorDeEntradas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReponedorDeEntradas = new System.Windows.Forms.Label();
            this.btnReponerManualmente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEntradas
            // 
            this.dtgEntradas.AllowUserToAddRows = false;
            this.dtgEntradas.AllowUserToDeleteRows = false;
            this.dtgEntradas.AllowUserToResizeColumns = false;
            this.dtgEntradas.AllowUserToResizeRows = false;
            this.dtgEntradas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEntradas.GridColor = System.Drawing.Color.Gold;
            this.dtgEntradas.Location = new System.Drawing.Point(14, 12);
            this.dtgEntradas.Name = "dtgEntradas";
            this.dtgEntradas.ReadOnly = true;
            this.dtgEntradas.RowTemplate.Height = 25;
            this.dtgEntradas.Size = new System.Drawing.Size(774, 427);
            this.dtgEntradas.TabIndex = 0;
            // 
            // btnVenderEntradas
            // 
            this.btnVenderEntradas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVenderEntradas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenderEntradas.ForeColor = System.Drawing.Color.Gold;
            this.btnVenderEntradas.Location = new System.Drawing.Point(632, 405);
            this.btnVenderEntradas.Name = "btnVenderEntradas";
            this.btnVenderEntradas.Size = new System.Drawing.Size(156, 34);
            this.btnVenderEntradas.TabIndex = 1;
            this.btnVenderEntradas.Text = "Vender Entradas";
            this.btnVenderEntradas.UseVisualStyleBackColor = false;
            this.btnVenderEntradas.Click += new System.EventHandler(this.btnVenderEntradas_Click);
            // 
            // lblValorDeEntradas
            // 
            this.lblValorDeEntradas.AutoSize = true;
            this.lblValorDeEntradas.BackColor = System.Drawing.Color.Black;
            this.lblValorDeEntradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorDeEntradas.ForeColor = System.Drawing.Color.Gold;
            this.lblValorDeEntradas.Location = new System.Drawing.Point(678, 12);
            this.lblValorDeEntradas.Name = "lblValorDeEntradas";
            this.lblValorDeEntradas.Size = new System.Drawing.Size(110, 21);
            this.lblValorDeEntradas.TabIndex = 2;
            this.lblValorDeEntradas.Text = "500$ Entradas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(678, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "700$ Entradas\r\n3D\r\n";
            // 
            // lblReponedorDeEntradas
            // 
            this.lblReponedorDeEntradas.AutoSize = true;
            this.lblReponedorDeEntradas.BackColor = System.Drawing.Color.Black;
            this.lblReponedorDeEntradas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReponedorDeEntradas.ForeColor = System.Drawing.Color.Gold;
            this.lblReponedorDeEntradas.Location = new System.Drawing.Point(619, 126);
            this.lblReponedorDeEntradas.Name = "lblReponedorDeEntradas";
            this.lblReponedorDeEntradas.Size = new System.Drawing.Size(0, 21);
            this.lblReponedorDeEntradas.TabIndex = 4;
            // 
            // btnReponerManualmente
            // 
            this.btnReponerManualmente.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReponerManualmente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReponerManualmente.ForeColor = System.Drawing.Color.Gold;
            this.btnReponerManualmente.Location = new System.Drawing.Point(14, 384);
            this.btnReponerManualmente.Name = "btnReponerManualmente";
            this.btnReponerManualmente.Size = new System.Drawing.Size(156, 55);
            this.btnReponerManualmente.TabIndex = 5;
            this.btnReponerManualmente.Text = "Reponer entradas manualmente";
            this.btnReponerManualmente.UseVisualStyleBackColor = false;
            this.btnReponerManualmente.Click += new System.EventHandler(this.btnReponerManualmente_Click);
            // 
            // FormVentaDeEntradas_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(798, 451);
            this.Controls.Add(this.btnReponerManualmente);
            this.Controls.Add(this.lblReponedorDeEntradas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValorDeEntradas);
            this.Controls.Add(this.btnVenderEntradas);
            this.Controls.Add(this.dtgEntradas);
            this.Name = "FormVentaDeEntradas_";
            this.Text = "FormVentaDeEntradas_";
            this.Load += new System.EventHandler(this.FormVentaDeEntradas__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEntradas;
        private System.Windows.Forms.Button btnVenderEntradas;
        private System.Windows.Forms.Label lblValorDeEntradas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReponedorDeEntradas;
        private System.Windows.Forms.Button btnReponerManualmente;
    }
}