namespace Deductions
{
    partial class lblcoefficient
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
            this.lblRevenu = new System.Windows.Forms.Label();
            this.lblcoeff = new System.Windows.Forms.Label();
            this.chkjeune = new System.Windows.Forms.CheckBox();
            this.chktransport = new System.Windows.Forms.CheckBox();
            this.chkfidelite = new System.Windows.Forms.CheckBox();
            this.txtRabais = new System.Windows.Forms.TextBox();
            this.txttransport = new System.Windows.Forms.TextBox();
            this.txtjeune = new System.Windows.Forms.TextBox();
            this.txtcoeff = new System.Windows.Forms.TextBox();
            this.txtrevenu = new System.Windows.Forms.TextBox();
            this.cmdcalcul = new System.Windows.Forms.Button();
            this.lblimposable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRevenu
            // 
            this.lblRevenu.AutoSize = true;
            this.lblRevenu.Location = new System.Drawing.Point(111, 73);
            this.lblRevenu.Name = "lblRevenu";
            this.lblRevenu.Size = new System.Drawing.Size(101, 13);
            this.lblRevenu.TabIndex = 0;
            this.lblRevenu.Text = "Revenu annuel brut";
            // 
            // lblcoeff
            // 
            this.lblcoeff.AutoSize = true;
            this.lblcoeff.Location = new System.Drawing.Point(111, 142);
            this.lblcoeff.Name = "lblcoeff";
            this.lblcoeff.Size = new System.Drawing.Size(91, 13);
            this.lblcoeff.TabIndex = 1;
            this.lblcoeff.Text = "Coefficient familial";
            // 
            // chkjeune
            // 
            this.chkjeune.AutoSize = true;
            this.chkjeune.Location = new System.Drawing.Point(184, 207);
            this.chkjeune.Name = "chkjeune";
            this.chkjeune.Size = new System.Drawing.Size(104, 17);
            this.chkjeune.TabIndex = 3;
            this.chkjeune.Text = "Déduction jeune";
            this.chkjeune.UseVisualStyleBackColor = true;
            // 
            // chktransport
            // 
            this.chktransport.AutoSize = true;
            this.chktransport.Location = new System.Drawing.Point(184, 249);
            this.chktransport.Name = "chktransport";
            this.chktransport.Size = new System.Drawing.Size(119, 17);
            this.chktransport.TabIndex = 5;
            this.chktransport.Text = "Déduction transport";
            this.chktransport.UseVisualStyleBackColor = true;
            // 
            // chkfidelite
            // 
            this.chkfidelite.AutoSize = true;
            this.chkfidelite.Location = new System.Drawing.Point(184, 285);
            this.chkfidelite.Name = "chkfidelite";
            this.chkfidelite.Size = new System.Drawing.Size(109, 17);
            this.chkfidelite.TabIndex = 7;
            this.chkfidelite.Text = "Rabais fidélité (%)";
            this.chkfidelite.UseVisualStyleBackColor = true;
            // 
            // txtRabais
            // 
            this.txtRabais.Location = new System.Drawing.Point(388, 285);
            this.txtRabais.Name = "txtRabais";
            this.txtRabais.Size = new System.Drawing.Size(100, 20);
            this.txtRabais.TabIndex = 8;
            // 
            // txttransport
            // 
            this.txttransport.Location = new System.Drawing.Point(388, 246);
            this.txttransport.Name = "txttransport";
            this.txttransport.Size = new System.Drawing.Size(100, 20);
            this.txttransport.TabIndex = 6;
            // 
            // txtjeune
            // 
            this.txtjeune.Location = new System.Drawing.Point(388, 204);
            this.txtjeune.Name = "txtjeune";
            this.txtjeune.Size = new System.Drawing.Size(100, 20);
            this.txtjeune.TabIndex = 4;
            // 
            // txtcoeff
            // 
            this.txtcoeff.Location = new System.Drawing.Point(388, 135);
            this.txtcoeff.Name = "txtcoeff";
            this.txtcoeff.Size = new System.Drawing.Size(100, 20);
            this.txtcoeff.TabIndex = 2;
            // 
            // txtrevenu
            // 
            this.txtrevenu.Location = new System.Drawing.Point(388, 66);
            this.txtrevenu.Name = "txtrevenu";
            this.txtrevenu.Size = new System.Drawing.Size(100, 20);
            this.txtrevenu.TabIndex = 1;
            // 
            // cmdcalcul
            // 
            this.cmdcalcul.Location = new System.Drawing.Point(256, 325);
            this.cmdcalcul.Name = "cmdcalcul";
            this.cmdcalcul.Size = new System.Drawing.Size(75, 23);
            this.cmdcalcul.TabIndex = 9;
            this.cmdcalcul.Text = "Calcul";
            this.cmdcalcul.UseVisualStyleBackColor = true;
            // 
            // lblimposable
            // 
            this.lblimposable.AutoSize = true;
            this.lblimposable.Location = new System.Drawing.Point(469, 374);
            this.lblimposable.Name = "lblimposable";
            this.lblimposable.Size = new System.Drawing.Size(0, 13);
            this.lblimposable.TabIndex = 10;
            // 
            // lblcoefficient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblimposable);
            this.Controls.Add(this.cmdcalcul);
            this.Controls.Add(this.txtrevenu);
            this.Controls.Add(this.txtcoeff);
            this.Controls.Add(this.txtjeune);
            this.Controls.Add(this.txttransport);
            this.Controls.Add(this.txtRabais);
            this.Controls.Add(this.chkfidelite);
            this.Controls.Add(this.chktransport);
            this.Controls.Add(this.chkjeune);
            this.Controls.Add(this.lblcoeff);
            this.Controls.Add(this.lblRevenu);
            this.Name = "lblcoefficient";
            this.Text = "Déductions";
            this.Load += new System.EventHandler(this.lblcoefficient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevenu;
        private System.Windows.Forms.Label lblcoeff;
        private System.Windows.Forms.CheckBox chkjeune;
        private System.Windows.Forms.CheckBox chktransport;
        private System.Windows.Forms.CheckBox chkfidelite;
        private System.Windows.Forms.TextBox txtRabais;
        private System.Windows.Forms.TextBox txttransport;
        private System.Windows.Forms.TextBox txtjeune;
        private System.Windows.Forms.TextBox txtcoeff;
        private System.Windows.Forms.TextBox txtrevenu;
        private System.Windows.Forms.Button cmdcalcul;
        private System.Windows.Forms.Label lblimposable;
    }
}

