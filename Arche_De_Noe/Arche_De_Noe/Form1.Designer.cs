namespace Arche_De_Noe
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
            this.lblATerre = new System.Windows.Forms.Label();
            this.lblABord = new System.Windows.Forms.Label();
            this.lstABord = new System.Windows.Forms.ListBox();
            this.lstATerre = new System.Windows.Forms.ListBox();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnGauche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblATerre
            // 
            this.lblATerre.AutoSize = true;
            this.lblATerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATerre.Location = new System.Drawing.Point(22, 35);
            this.lblATerre.Name = "lblATerre";
            this.lblATerre.Size = new System.Drawing.Size(144, 24);
            this.lblATerre.TabIndex = 0;
            this.lblATerre.Text = "Encore à terre";
            // 
            // lblABord
            // 
            this.lblABord.AutoSize = true;
            this.lblABord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABord.Location = new System.Drawing.Point(285, 35);
            this.lblABord.Name = "lblABord";
            this.lblABord.Size = new System.Drawing.Size(73, 24);
            this.lblABord.TabIndex = 1;
            this.lblABord.Text = "A bord";
            // 
            // lstABord
            // 
            this.lstABord.FormattingEnabled = true;
            this.lstABord.Location = new System.Drawing.Point(289, 62);
            this.lstABord.Name = "lstABord";
            this.lstABord.Size = new System.Drawing.Size(170, 251);
            this.lstABord.TabIndex = 2;
            // 
            // lstATerre
            // 
            this.lstATerre.FormattingEnabled = true;
            this.lstATerre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.lstATerre.Location = new System.Drawing.Point(12, 62);
            this.lstATerre.Name = "lstATerre";
            this.lstATerre.Size = new System.Drawing.Size(190, 251);
            this.lstATerre.Sorted = true;
            this.lstATerre.TabIndex = 3;
            // 
            // btnDroite
            // 
            this.btnDroite.Location = new System.Drawing.Point(208, 118);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(75, 23);
            this.btnDroite.TabIndex = 4;
            this.btnDroite.Text = "===>";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // btnGauche
            // 
            this.btnGauche.Location = new System.Drawing.Point(208, 187);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(75, 23);
            this.btnGauche.TabIndex = 5;
            this.btnGauche.Text = "<===";
            this.btnGauche.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 371);
            this.Controls.Add(this.btnGauche);
            this.Controls.Add(this.btnDroite);
            this.Controls.Add(this.lstATerre);
            this.Controls.Add(this.lstABord);
            this.Controls.Add(this.lblABord);
            this.Controls.Add(this.lblATerre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblATerre;
        private System.Windows.Forms.Label lblABord;
        private System.Windows.Forms.ListBox lstABord;
        private System.Windows.Forms.ListBox lstATerre;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnGauche;
    }
}

