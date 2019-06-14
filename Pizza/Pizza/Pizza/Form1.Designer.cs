namespace Pizza
{
    partial class Pizza
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
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.rdoExtra = new System.Windows.Forms.RadioButton();
            this.rdoFine = new System.Windows.Forms.RadioButton();
            this.rdoNormale = new System.Windows.Forms.RadioButton();
            this.rdoEpaisse = new System.Windows.Forms.RadioButton();
            this.btnCommander = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.grpPate = new System.Windows.Forms.GroupBox();
            this.lblCommande = new System.Windows.Forms.Label();
            this.lblComChoisie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(255, 129);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(69, 19);
            this.chkAnchois.TabIndex = 0;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(255, 164);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(65, 19);
            this.chkCapres.TabIndex = 1;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(255, 195);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(71, 19);
            this.chkJambon.TabIndex = 2;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(255, 228);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(76, 19);
            this.chkCrevettes.TabIndex = 3;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // rdoExtra
            // 
            this.rdoExtra.AutoSize = true;
            this.rdoExtra.Location = new System.Drawing.Point(89, 129);
            this.rdoExtra.Name = "rdoExtra";
            this.rdoExtra.Size = new System.Drawing.Size(77, 19);
            this.rdoExtra.TabIndex = 4;
            this.rdoExtra.TabStop = true;
            this.rdoExtra.Text = "Extra-fine";
            this.rdoExtra.UseVisualStyleBackColor = true;
            // 
            // rdoFine
            // 
            this.rdoFine.AutoSize = true;
            this.rdoFine.Location = new System.Drawing.Point(89, 164);
            this.rdoFine.Name = "rdoFine";
            this.rdoFine.Size = new System.Drawing.Size(49, 19);
            this.rdoFine.TabIndex = 5;
            this.rdoFine.TabStop = true;
            this.rdoFine.Text = "Fine";
            this.rdoFine.UseVisualStyleBackColor = true;
            // 
            // rdoNormale
            // 
            this.rdoNormale.AutoSize = true;
            this.rdoNormale.Location = new System.Drawing.Point(89, 195);
            this.rdoNormale.Name = "rdoNormale";
            this.rdoNormale.Size = new System.Drawing.Size(73, 19);
            this.rdoNormale.TabIndex = 6;
            this.rdoNormale.TabStop = true;
            this.rdoNormale.Text = "Normale";
            this.rdoNormale.UseVisualStyleBackColor = true;
            // 
            // rdoEpaisse
            // 
            this.rdoEpaisse.AutoSize = true;
            this.rdoEpaisse.Location = new System.Drawing.Point(89, 228);
            this.rdoEpaisse.Name = "rdoEpaisse";
            this.rdoEpaisse.Size = new System.Drawing.Size(69, 19);
            this.rdoEpaisse.TabIndex = 7;
            this.rdoEpaisse.TabStop = true;
            this.rdoEpaisse.Text = "Epaisse";
            this.rdoEpaisse.UseVisualStyleBackColor = true;
            // 
            // btnCommander
            // 
            this.btnCommander.Location = new System.Drawing.Point(292, 315);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(87, 23);
            this.btnCommander.TabIndex = 8;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = true;
            this.btnCommander.Click += new System.EventHandler(this.btnCommander_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(66, 79);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(38, 15);
            this.lblTable.TabIndex = 9;
            this.lblTable.Text = "Table";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(109, 76);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(25, 20);
            this.txtTable.TabIndex = 10;
            // 
            // grpPate
            // 
            this.grpPate.Location = new System.Drawing.Point(69, 102);
            this.grpPate.Name = "grpPate";
            this.grpPate.Size = new System.Drawing.Size(129, 164);
            this.grpPate.TabIndex = 11;
            this.grpPate.TabStop = false;
            this.grpPate.Text = "Pâte";
            // 
            // lblCommande
            // 
            this.lblCommande.AutoSize = true;
            this.lblCommande.Location = new System.Drawing.Point(66, 325);
            this.lblCommande.Name = "lblCommande";
            this.lblCommande.Size = new System.Drawing.Size(72, 15);
            this.lblCommande.TabIndex = 12;
            this.lblCommande.Text = "Commande";
            // 
            // lblComChoisie
            // 
            this.lblComChoisie.BackColor = System.Drawing.Color.Yellow;
            this.lblComChoisie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComChoisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComChoisie.Location = new System.Drawing.Point(116, 363);
            this.lblComChoisie.Name = "lblComChoisie";
            this.lblComChoisie.Size = new System.Drawing.Size(310, 64);
            this.lblComChoisie.TabIndex = 13;
            this.lblComChoisie.Text = "label1";
            this.lblComChoisie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.lblComChoisie);
            this.Controls.Add(this.lblCommande);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.rdoEpaisse);
            this.Controls.Add(this.rdoNormale);
            this.Controls.Add(this.rdoFine);
            this.Controls.Add(this.rdoExtra);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.grpPate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Pizza";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.RadioButton rdoExtra;
        private System.Windows.Forms.RadioButton rdoFine;
        private System.Windows.Forms.RadioButton rdoNormale;
        private System.Windows.Forms.RadioButton rdoEpaisse;
        private System.Windows.Forms.Button btnCommander;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.GroupBox grpPate;
        private System.Windows.Forms.Label lblCommande;
        private System.Windows.Forms.Label lblComChoisie;
    }
}

