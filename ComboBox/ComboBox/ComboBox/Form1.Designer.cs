namespace ComboBox
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.cmbGymnases = new System.Windows.Forms.ComboBox();
            this.lstEcoles = new System.Windows.Forms.ListBox();
            this.lstAjouter = new System.Windows.Forms.ListBox();
            this.cmbEntreprises = new System.Windows.Forms.ComboBox();
            this.lblEcolesSelec = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(186, 59);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(186, 105);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(186, 158);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(186, 209);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // cmbGymnases
            // 
            this.cmbGymnases.FormattingEnabled = true;
            this.cmbGymnases.Location = new System.Drawing.Point(32, 271);
            this.cmbGymnases.Name = "cmbGymnases";
            this.cmbGymnases.Size = new System.Drawing.Size(121, 21);
            this.cmbGymnases.TabIndex = 4;
            this.cmbGymnases.SelectedIndexChanged += new System.EventHandler(this.cmbGymnases_SelectedIndexChanged);
            // 
            // lstEcoles
            // 
            this.lstEcoles.FormattingEnabled = true;
            this.lstEcoles.Location = new System.Drawing.Point(32, 82);
            this.lstEcoles.Name = "lstEcoles";
            this.lstEcoles.Size = new System.Drawing.Size(120, 160);
            this.lstEcoles.TabIndex = 5;
            this.lstEcoles.SelectedIndexChanged += new System.EventHandler(this.lstEcoles_SelectedIndexChanged);
            // 
            // lstAjouter
            // 
            this.lstAjouter.FormattingEnabled = true;
            this.lstAjouter.Location = new System.Drawing.Point(304, 49);
            this.lstAjouter.Name = "lstAjouter";
            this.lstAjouter.Size = new System.Drawing.Size(120, 160);
            this.lstAjouter.TabIndex = 6;
            // 
            // cmbEntreprises
            // 
            this.cmbEntreprises.FormattingEnabled = true;
            this.cmbEntreprises.Location = new System.Drawing.Point(32, 34);
            this.cmbEntreprises.Name = "cmbEntreprises";
            this.cmbEntreprises.Size = new System.Drawing.Size(121, 21);
            this.cmbEntreprises.TabIndex = 1;
            this.cmbEntreprises.SelectedIndexChanged += new System.EventHandler(this.cmbEntreprises_SelectedIndexChanged);
            // 
            // lblEcolesSelec
            // 
            this.lblEcolesSelec.AutoSize = true;
            this.lblEcolesSelec.Location = new System.Drawing.Point(348, 241);
            this.lblEcolesSelec.Name = "lblEcolesSelec";
            this.lblEcolesSelec.Size = new System.Drawing.Size(106, 13);
            this.lblEcolesSelec.TabIndex = 8;
            this.lblEcolesSelec.Text = "écoles sélectionnées";
            // 
            // lblCount
            // 
            this.lblCount.Location = new System.Drawing.Point(348, 272);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(92, 20);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "label2";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblEcolesSelec);
            this.Controls.Add(this.cmbEntreprises);
            this.Controls.Add(this.lstAjouter);
            this.Controls.Add(this.lstEcoles);
            this.Controls.Add(this.cmbGymnases);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnAjouter);
            this.Name = "Form1";
            this.Text = "ListBox et ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox cmbGymnases;
        private System.Windows.Forms.ListBox lstEcoles;
        private System.Windows.Forms.ListBox lstAjouter;
        private System.Windows.Forms.ComboBox cmbEntreprises;
        private System.Windows.Forms.Label lblEcolesSelec;
        private System.Windows.Forms.Label lblCount;
    }
}

