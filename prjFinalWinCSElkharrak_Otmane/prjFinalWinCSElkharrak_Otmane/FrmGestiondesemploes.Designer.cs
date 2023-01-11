namespace prjFinalWinCSElkharrak_Otmane
{
    partial class FrmGestiondesemploes
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAfficher = new System.Windows.Forms.Label();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnSauvgarder = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFonction = new System.Windows.Forms.TextBox();
            this.txtSalaire = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSal = new System.Windows.Forms.Label();
            this.lblFonc = new System.Windows.Forms.Label();
            this.lblNm = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lstNumero = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÉVALUATION SOMMATIVE DE FIN DE SESSION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAfficher);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.btnAnnuler);
            this.groupBox1.Controls.Add(this.btnModifier);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.btnSauvgarder);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtFonction);
            this.groupBox1.Controls.Add(this.txtSalaire);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 281);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion Des Employés De Microsoft";
            // 
            // lblAfficher
            // 
            this.lblAfficher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAfficher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAfficher.ForeColor = System.Drawing.Color.Black;
            this.lblAfficher.Location = new System.Drawing.Point(138, 229);
            this.lblAfficher.Name = "lblAfficher";
            this.lblAfficher.Size = new System.Drawing.Size(340, 35);
            this.lblAfficher.TabIndex = 17;
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(64, 173);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(103, 32);
            this.btnPremier.TabIndex = 16;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(173, 173);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(102, 32);
            this.btnPrecedent.TabIndex = 15;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(281, 173);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(113, 32);
            this.btnSuivant.TabIndex = 14;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(400, 173);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(111, 32);
            this.btnDernier.TabIndex = 13;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(572, 202);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(103, 32);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(572, 81);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(103, 32);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(572, 119);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(103, 34);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnSauvgarder
            // 
            this.btnSauvgarder.Location = new System.Drawing.Point(572, 159);
            this.btnSauvgarder.Name = "btnSauvgarder";
            this.btnSauvgarder.Size = new System.Drawing.Size(103, 37);
            this.btnSauvgarder.TabIndex = 9;
            this.btnSauvgarder.Text = "Sauvgarder";
            this.btnSauvgarder.UseVisualStyleBackColor = true;
            this.btnSauvgarder.Click += new System.EventHandler(this.btnSauvgarder_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(572, 40);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 35);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(138, 70);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(340, 24);
            this.txtNom.TabIndex = 7;
            // 
            // txtFonction
            // 
            this.txtFonction.Location = new System.Drawing.Point(138, 100);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.Size = new System.Drawing.Size(340, 24);
            this.txtFonction.TabIndex = 6;
            // 
            // txtSalaire
            // 
            this.txtSalaire.Location = new System.Drawing.Point(138, 130);
            this.txtSalaire.Name = "txtSalaire";
            this.txtSalaire.Size = new System.Drawing.Size(340, 24);
            this.txtSalaire.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(138, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(340, 24);
            this.txtNumero.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fonction:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salaire:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lstNumero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(57, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(701, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche Employé Par Son Numero";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSal);
            this.groupBox3.Controls.Add(this.lblFonc);
            this.groupBox3.Controls.Add(this.lblNm);
            this.groupBox3.Controls.Add(this.lblNum);
            this.groupBox3.Location = new System.Drawing.Point(260, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information de Employé Selectionné";
            // 
            // lblSal
            // 
            this.lblSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSal.Location = new System.Drawing.Point(30, 153);
            this.lblSal.Name = "lblSal";
            this.lblSal.Size = new System.Drawing.Size(274, 28);
            this.lblSal.TabIndex = 6;
            // 
            // lblFonc
            // 
            this.lblFonc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFonc.Location = new System.Drawing.Point(30, 110);
            this.lblFonc.Name = "lblFonc";
            this.lblFonc.Size = new System.Drawing.Size(274, 28);
            this.lblFonc.TabIndex = 5;
            // 
            // lblNm
            // 
            this.lblNm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNm.Location = new System.Drawing.Point(30, 70);
            this.lblNm.Name = "lblNm";
            this.lblNm.Size = new System.Drawing.Size(274, 28);
            this.lblNm.TabIndex = 4;
            // 
            // lblNum
            // 
            this.lblNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNum.Location = new System.Drawing.Point(30, 33);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(274, 28);
            this.lblNum.TabIndex = 0;
            // 
            // lstNumero
            // 
            this.lstNumero.FormattingEnabled = true;
            this.lstNumero.ItemHeight = 18;
            this.lstNumero.Location = new System.Drawing.Point(31, 68);
            this.lstNumero.Name = "lstNumero";
            this.lstNumero.Size = new System.Drawing.Size(146, 148);
            this.lstNumero.TabIndex = 1;
            this.lstNumero.SelectedIndexChanged += new System.EventHandler(this.lstNumero_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Choisir un numero";
            // 
            // FrmGestiondesemploes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 696);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestiondesemploes";
            this.Text = "Gestion des Employés de Microsoft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGestiondesemploes_FormClosing);
            this.Load += new System.EventHandler(this.FrmEvaluation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAfficher;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnSauvgarder;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFonction;
        private System.Windows.Forms.TextBox txtSalaire;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSal;
        private System.Windows.Forms.Label lblFonc;
        private System.Windows.Forms.Label lblNm;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.ListBox lstNumero;
        private System.Windows.Forms.Label label6;
    }
}

