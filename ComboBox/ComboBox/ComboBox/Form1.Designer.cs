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
            this.btnAjouter.Location = new System.Drawing.Point(248, 73);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 28);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(248, 129);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(100, 28);
            this.btnEffacer.TabIndex = 1;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(248, 194);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(248, 257);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 28);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // cmbGymnases
            // 
            this.cmbGymnases.FormattingEnabled = true;
            this.cmbGymnases.Location = new System.Drawing.Point(43, 334);
            this.cmbGymnases.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGymnases.Name = "cmbGymnases";
            this.cmbGymnases.Size = new System.Drawing.Size(160, 24);
            this.cmbGymnases.TabIndex = 4;
            this.cmbGymnases.SelectedIndexChanged += new System.EventHandler(this.cmbGymnases_SelectedIndexChanged);
            // 
            // lstEcoles
            // 
            this.lstEcoles.FormattingEnabled = true;
            this.lstEcoles.ItemHeight = 16;
            this.lstEcoles.Location = new System.Drawing.Point(43, 101);
            this.lstEcoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEcoles.Name = "lstEcoles";
            this.lstEcoles.Size = new System.Drawing.Size(159, 196);
            this.lstEcoles.TabIndex = 5;
            this.lstEcoles.SelectedIndexChanged += new System.EventHandler(this.lstEcoles_SelectedIndexChanged);
            // 
            // lstAjouter
            // 
            this.lstAjouter.FormattingEnabled = true;
            this.lstAjouter.ItemHeight = 16;
            this.lstAjouter.Location = new System.Drawing.Point(405, 60);
            this.lstAjouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAjouter.Name = "lstAjouter";
            this.lstAjouter.Size = new System.Drawing.Size(159, 196);
            this.lstAjouter.TabIndex = 6;
            // 
            // cmbEntreprises
            // 
            this.cmbEntreprises.FormattingEnabled = true;
            this.cmbEntreprises.Location = new System.Drawing.Point(43, 42);
            this.cmbEntreprises.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEntreprises.Name = "cmbEntreprises";
            this.cmbEntreprises.Size = new System.Drawing.Size(160, 24);
            this.cmbEntreprises.TabIndex = 1;
            this.cmbEntreprises.SelectedIndexChanged += new System.EventHandler(this.cmbEntreprises_SelectedIndexChanged);
            // 
            // lblEcolesSelec
            // 
            this.lblEcolesSelec.AutoSize = true;
            this.lblEcolesSelec.Location = new System.Drawing.Point(464, 297);
            this.lblEcolesSelec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEcolesSelec.Name = "lblEcolesSelec";
            this.lblEcolesSelec.Size = new System.Drawing.Size(140, 17);
            this.lblEcolesSelec.TabIndex = 8;
            this.lblEcolesSelec.Text = "écoles sélectionnées";
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(464, 335);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(123, 25);
            this.lblCount.TabIndex = 9;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

