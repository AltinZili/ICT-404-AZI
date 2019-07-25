namespace TestEmail
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
            this.lblverification = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblapres = new System.Windows.Forms.Label();
            this.lblavant = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtavant = new System.Windows.Forms.TextBox();
            this.txtapres = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnverif = new System.Windows.Forms.Button();
            this.chkapresent = new System.Windows.Forms.CheckBox();
            this.chkpointpresent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblverification
            // 
            this.lblverification.AutoSize = true;
            this.lblverification.Location = new System.Drawing.Point(166, 359);
            this.lblverification.Name = "lblverification";
            this.lblverification.Size = new System.Drawing.Size(46, 17);
            this.lblverification.TabIndex = 1;
            this.lblverification.Text = "label2";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(71, 301);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(113, 17);
            this.lblnom.TabIndex = 3;
            this.lblnom.Text = "Nom d\'utilisateur";
            // 
            // lblapres
            // 
            this.lblapres.AutoSize = true;
            this.lblapres.Location = new System.Drawing.Point(198, 223);
            this.lblapres.Name = "lblapres";
            this.lblapres.Size = new System.Drawing.Size(143, 17);
            this.lblapres.TabIndex = 4;
            this.lblapres.Text = "caractère(s) après @";
            // 
            // lblavant
            // 
            this.lblavant.AutoSize = true;
            this.lblavant.Location = new System.Drawing.Point(189, 179);
            this.lblavant.Name = "lblavant";
            this.lblavant.Size = new System.Drawing.Size(142, 17);
            this.lblavant.TabIndex = 5;
            this.lblavant.Text = "caractère(s) avant @";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(145, 35);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(101, 17);
            this.lblemail.TabIndex = 6;
            this.lblemail.Text = "Email à vérifier";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(252, 30);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 1;
            // 
            // txtavant
            // 
            this.txtavant.Location = new System.Drawing.Point(50, 179);
            this.txtavant.Name = "txtavant";
            this.txtavant.Size = new System.Drawing.Size(100, 22);
            this.txtavant.TabIndex = 8;
            // 
            // txtapres
            // 
            this.txtapres.Location = new System.Drawing.Point(50, 218);
            this.txtapres.Name = "txtapres";
            this.txtapres.Size = new System.Drawing.Size(100, 22);
            this.txtapres.TabIndex = 9;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(201, 301);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 22);
            this.txtnom.TabIndex = 10;
            // 
            // btnverif
            // 
            this.btnverif.Location = new System.Drawing.Point(446, 32);
            this.btnverif.Name = "btnverif";
            this.btnverif.Size = new System.Drawing.Size(75, 23);
            this.btnverif.TabIndex = 2;
            this.btnverif.Text = "Vérifier";
            this.btnverif.UseVisualStyleBackColor = true;
            this.btnverif.Click += new System.EventHandler(this.btnverif_Click);
            // 
            // chkapresent
            // 
            this.chkapresent.AutoSize = true;
            this.chkapresent.Location = new System.Drawing.Point(93, 139);
            this.chkapresent.Name = "chkapresent";
            this.chkapresent.Size = new System.Drawing.Size(106, 21);
            this.chkapresent.TabIndex = 13;
            this.chkapresent.Text = "\"@\" présent";
            this.chkapresent.UseVisualStyleBackColor = true;
            // 
            // chkpointpresent
            // 
            this.chkpointpresent.AutoSize = true;
            this.chkpointpresent.Location = new System.Drawing.Point(93, 271);
            this.chkpointpresent.Name = "chkpointpresent";
            this.chkpointpresent.Size = new System.Drawing.Size(154, 21);
            this.chkpointpresent.TabIndex = 14;
            this.chkpointpresent.Text = "\".\" présent après @";
            this.chkpointpresent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkpointpresent);
            this.Controls.Add(this.chkapresent);
            this.Controls.Add(this.btnverif);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtapres);
            this.Controls.Add(this.txtavant);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblavant);
            this.Controls.Add(this.lblapres);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblverification);
            this.Name = "Form1";
            this.Text = "Vérification d\'émail";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblverification;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblapres;
        private System.Windows.Forms.Label lblavant;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtavant;
        private System.Windows.Forms.TextBox txtapres;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnverif;
        private System.Windows.Forms.CheckBox chkapresent;
        private System.Windows.Forms.CheckBox chkpointpresent;
    }
}

