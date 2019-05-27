namespace Deductions
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkjeune = new System.Windows.Forms.CheckBox();
            this.chktransport = new System.Windows.Forms.CheckBox();
            this.chkfidelite = new System.Windows.Forms.CheckBox();
            this.btncalcul = new System.Windows.Forms.Button();
            this.lblrevenu = new System.Windows.Forms.Label();
            this.lblcoeff = new System.Windows.Forms.Label();
            this.txtfidelite = new System.Windows.Forms.TextBox();
            this.txttransport = new System.Windows.Forms.TextBox();
            this.txtjeune = new System.Windows.Forms.TextBox();
            this.txtcoeff = new System.Windows.Forms.TextBox();
            this.txtrevenu = new System.Windows.Forms.TextBox();
            this.lblimposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkjeune
            // 
            this.chkjeune.AutoSize = true;
            this.chkjeune.Location = new System.Drawing.Point(101, 184);
            this.chkjeune.Name = "chkjeune";
            this.chkjeune.Size = new System.Drawing.Size(104, 17);
            this.chkjeune.TabIndex = 3;
            this.chkjeune.Text = "Déduction jeune";
            this.chkjeune.UseVisualStyleBackColor = true;
            // 
            // chktransport
            // 
            this.chktransport.AutoSize = true;
            this.chktransport.Location = new System.Drawing.Point(101, 219);
            this.chktransport.Name = "chktransport";
            this.chktransport.Size = new System.Drawing.Size(119, 17);
            this.chktransport.TabIndex = 5;
            this.chktransport.Text = "Déduction transport";
            this.chktransport.UseVisualStyleBackColor = true;
            // 
            // chkfidelite
            // 
            this.chkfidelite.AutoSize = true;
            this.chkfidelite.Location = new System.Drawing.Point(101, 247);
            this.chkfidelite.Name = "chkfidelite";
            this.chkfidelite.Size = new System.Drawing.Size(109, 17);
            this.chkfidelite.TabIndex = 6;
            this.chkfidelite.Text = "Rabais fidélité (%)";
            this.chkfidelite.UseVisualStyleBackColor = true;
            // 
            // btncalcul
            // 
            this.btncalcul.Location = new System.Drawing.Point(135, 295);
            this.btncalcul.Name = "btncalcul";
            this.btncalcul.Size = new System.Drawing.Size(75, 23);
            this.btncalcul.TabIndex = 8;
            this.btncalcul.Text = "Calcul";
            this.btncalcul.UseVisualStyleBackColor = true;
            this.btncalcul.Click += new System.EventHandler(this.btncalcul_Click);
            // 
            // lblrevenu
            // 
            this.lblrevenu.AutoSize = true;
            this.lblrevenu.Location = new System.Drawing.Point(59, 63);
            this.lblrevenu.Name = "lblrevenu";
            this.lblrevenu.Size = new System.Drawing.Size(101, 13);
            this.lblrevenu.TabIndex = 4;
            this.lblrevenu.Text = "Revenu annuel brut";
            // 
            // lblcoeff
            // 
            this.lblcoeff.AutoSize = true;
            this.lblcoeff.Location = new System.Drawing.Point(59, 111);
            this.lblcoeff.Name = "lblcoeff";
            this.lblcoeff.Size = new System.Drawing.Size(85, 13);
            this.lblcoeff.TabIndex = 5;
            this.lblcoeff.Text = "Cofficient familial";
            // 
            // txtfidelite
            // 
            this.txtfidelite.Location = new System.Drawing.Point(279, 247);
            this.txtfidelite.Name = "txtfidelite";
            this.txtfidelite.Size = new System.Drawing.Size(57, 20);
            this.txtfidelite.TabIndex = 7;
            this.txtfidelite.Validated += new System.EventHandler(this.txtfidelite_Validated);
            // 
            // txttransport
            // 
            this.txttransport.Location = new System.Drawing.Point(279, 219);
            this.txttransport.Name = "txttransport";
            this.txttransport.Size = new System.Drawing.Size(57, 20);
            this.txttransport.TabIndex = 6;
            this.txttransport.Validated += new System.EventHandler(this.txttransport_Validated);
            // 
            // txtjeune
            // 
            this.txtjeune.Location = new System.Drawing.Point(279, 184);
            this.txtjeune.Name = "txtjeune";
            this.txtjeune.Size = new System.Drawing.Size(57, 20);
            this.txtjeune.TabIndex = 4;
            this.txtjeune.Validated += new System.EventHandler(this.txtjeune_Validated);
            // 
            // txtcoeff
            // 
            this.txtcoeff.Location = new System.Drawing.Point(279, 104);
            this.txtcoeff.Name = "txtcoeff";
            this.txtcoeff.Size = new System.Drawing.Size(57, 20);
            this.txtcoeff.TabIndex = 2;
            this.txtcoeff.Validated += new System.EventHandler(this.txtcoeff_Validated);
            // 
            // txtrevenu
            // 
            this.txtrevenu.Location = new System.Drawing.Point(218, 63);
            this.txtrevenu.Name = "txtrevenu";
            this.txtrevenu.Size = new System.Drawing.Size(118, 20);
            this.txtrevenu.TabIndex = 1;
            this.txtrevenu.Validated += new System.EventHandler(this.txtrevenu_TextValidated);
            // 
            // lblimposable
            // 
            this.lblimposable.AutoSize = true;
            this.lblimposable.Location = new System.Drawing.Point(215, 361);
            this.lblimposable.Name = "lblimposable";
            this.lblimposable.Size = new System.Drawing.Size(35, 13);
            this.lblimposable.TabIndex = 11;
            this.lblimposable.Text = "label1";
            this.lblimposable.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.lblimposable);
            this.Controls.Add(this.txtrevenu);
            this.Controls.Add(this.txtcoeff);
            this.Controls.Add(this.txtjeune);
            this.Controls.Add(this.txttransport);
            this.Controls.Add(this.txtfidelite);
            this.Controls.Add(this.lblcoeff);
            this.Controls.Add(this.lblrevenu);
            this.Controls.Add(this.btncalcul);
            this.Controls.Add(this.chkfidelite);
            this.Controls.Add(this.chktransport);
            this.Controls.Add(this.chkjeune);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkjeune;
        private System.Windows.Forms.CheckBox chktransport;
        private System.Windows.Forms.CheckBox chkfidelite;
        private System.Windows.Forms.Button btncalcul;
        private System.Windows.Forms.Label lblrevenu;
        private System.Windows.Forms.Label lblcoeff;
        private System.Windows.Forms.TextBox txtfidelite;
        private System.Windows.Forms.TextBox txttransport;
        private System.Windows.Forms.TextBox txtjeune;
        private System.Windows.Forms.TextBox txtcoeff;
        private System.Windows.Forms.TextBox txtrevenu;
        private System.Windows.Forms.Label lblimposable;
    }
}

