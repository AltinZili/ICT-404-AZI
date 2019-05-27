namespace WindowsFormsApp1
{
    partial class Fenetre
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
            this.btnHG = new System.Windows.Forms.Button();
            this.btnquitter = new System.Windows.Forms.Button();
            this.btnstats = new System.Windows.Forms.Button();
            this.btnrouge = new System.Windows.Forms.Button();
            this.btnbleu = new System.Windows.Forms.Button();
            this.btnBG = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHG
            // 
            this.btnHG.Location = new System.Drawing.Point(0, 0);
            this.btnHG.Name = "btnHG";
            this.btnHG.Size = new System.Drawing.Size(84, 23);
            this.btnHG.TabIndex = 0;
            this.btnHG.Text = "Haut/Gauche";
            this.btnHG.UseVisualStyleBackColor = true;
            this.btnHG.Click += new System.EventHandler(this.btnHG_Click);
            // 
            // btnquitter
            // 
            this.btnquitter.Location = new System.Drawing.Point(351, 330);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(75, 23);
            this.btnquitter.TabIndex = 1;
            this.btnquitter.Text = "Quitter";
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // btnstats
            // 
            this.btnstats.Location = new System.Drawing.Point(351, 235);
            this.btnstats.Name = "btnstats";
            this.btnstats.Size = new System.Drawing.Size(75, 23);
            this.btnstats.TabIndex = 2;
            this.btnstats.Text = "Stats";
            this.btnstats.UseVisualStyleBackColor = true;
            this.btnstats.Click += new System.EventHandler(this.btnstats_Click);
            // 
            // btnrouge
            // 
            this.btnrouge.Location = new System.Drawing.Point(351, 163);
            this.btnrouge.Name = "btnrouge";
            this.btnrouge.Size = new System.Drawing.Size(75, 23);
            this.btnrouge.TabIndex = 3;
            this.btnrouge.Text = "Rouge";
            this.btnrouge.UseVisualStyleBackColor = true;
            this.btnrouge.Click += new System.EventHandler(this.btnrouge_Click);
            // 
            // btnbleu
            // 
            this.btnbleu.Location = new System.Drawing.Point(351, 80);
            this.btnbleu.Name = "btnbleu";
            this.btnbleu.Size = new System.Drawing.Size(75, 23);
            this.btnbleu.TabIndex = 4;
            this.btnbleu.Text = "Bleu";
            this.btnbleu.UseVisualStyleBackColor = true;
            this.btnbleu.Click += new System.EventHandler(this.btnbleu_Click);
            // 
            // btnBG
            // 
            this.btnBG.Location = new System.Drawing.Point(0, 430);
            this.btnBG.Name = "btnBG";
            this.btnBG.Size = new System.Drawing.Size(84, 23);
            this.btnBG.TabIndex = 5;
            this.btnBG.Text = "Bas/Gauche";
            this.btnBG.UseVisualStyleBackColor = true;
            this.btnBG.Click += new System.EventHandler(this.btnBG_Click);
            // 
            // btnBD
            // 
            this.btnBD.Location = new System.Drawing.Point(725, 430);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 6;
            this.btnBD.Text = "Bas/Droite";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // btnHD
            // 
            this.btnHD.Location = new System.Drawing.Point(725, 0);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(75, 23);
            this.btnHD.TabIndex = 7;
            this.btnHD.Text = "Haut/Droite";
            this.btnHD.UseVisualStyleBackColor = true;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.btnBG);
            this.Controls.Add(this.btnbleu);
            this.Controls.Add(this.btnrouge);
            this.Controls.Add(this.btnstats);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.btnHG);
            this.Name = "Fenetre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenêtre";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHG;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Button btnstats;
        private System.Windows.Forms.Button btnrouge;
        private System.Windows.Forms.Button btnbleu;
        private System.Windows.Forms.Button btnBG;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Button btnHD;
    }
}

