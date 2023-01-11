using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFinalWinCSElkharrak_Otmane
{
    public partial class FrmGestiondesemploes : Form
    {
        public FrmGestiondesemploes()
        {
            InitializeComponent();
        }
        public struct Microsoft
        {
            public string Numero;
            public string Nom;
            public string Fonction;
            public string Salaire;

        }
        //declaration des variables globale a la forme
        List<Microsoft> Listemployes = new List<Microsoft>();
        Int16 index = 0, NbEmploye;
        string mode;
        private void FrmEvaluation_Load(object sender, EventArgs e)
        {
            //ouvrire le fichier infoemployes pour lire les etudiants et les mettre dans le tableau
            StreamReader Monfichier = new StreamReader("infoemployes.txt");
            Int16 I = 0;

            //conteneur temporaire
            Microsoft tmp = new Microsoft();
            while (Monfichier.EndOfStream == false)
            {
                tmp.Numero = Monfichier.ReadLine();
                tmp.Nom = Monfichier.ReadLine();
                tmp.Fonction = Monfichier.ReadLine();
                tmp.Salaire = Monfichier.ReadLine();
                Listemployes.Add(tmp);
                
            }
            Monfichier.Close();

            //remplire les texte box avec les info
            index = 0;
            Afficher();

            //remplire la listbox avec les numeros de employés
            for (Int16 j = 0; j < Listemployes.Count; j++)
            {
                lstNumero.Items.Add(Listemployes[j].Numero);
            }

        }
        private void Afficher()
        {
            txtNumero.Text = Listemployes[index].Numero;
            txtNom.Text = Listemployes[index].Nom;
            txtFonction.Text = Listemployes[index].Fonction;
            txtSalaire.Text = Listemployes[index].Salaire;
            lblAfficher.Text= "Etudiant " + (index + 1) + " sur un total de " + Listemployes.Count;
        }

        //afficher 1er employé
        private void btnPremier_Click(object sender, EventArgs e)
        {
            index = 0;
            Afficher();
        }
        //afficher employé par employé
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (index < Listemployes.Count - 1)
            {
                index++;
                Afficher();
            }
        }
        //afficher dernier employé
        private void btnDernier_Click(object sender, EventArgs e)
        {
            index = Convert.ToInt16(Listemployes.Count - 1);
            Afficher();
        }
        //afficher l'employé précident
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Afficher();
            }
        }
        //ajouter un employé
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtNom.Text = "";
            txtFonction.Text = "";
            txtSalaire.Text = "";
            txtNumero.Focus();
            mode = "ajout";
            lblAfficher.Text = "En mode ajout";
        }
        //modifier un employé
        private void btnModifier_Click(object sender, EventArgs e)
        {
            txtNumero.Focus();
            mode = "modif";
            lblAfficher.Text = "En mode Modif";
        }
        //supprimer un employé
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur de vouloir supprimer cet Employé", "Avertissement de Supppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (Int16 i = index; i < (Listemployes.Count - 1); i++)
                {
                    Listemployes[i] = Listemployes[i + 1];
                }
                Listemployes.RemoveAt(index);

                //afficher le premier etudiant apres la suppression
                index = 0;
                Afficher();
            }
        }

        //annuler
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            index = 0;
            Afficher();
        }

        //sauvgarder 
        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            Microsoft tmp = new Microsoft();

            if (mode == "modif")
            {
                tmp.Numero = txtNumero.Text;
                tmp.Nom = txtNom.Text;
                tmp.Fonction = txtFonction.Text;
                tmp.Salaire = txtSalaire.Text;
                
                Listemployes.Insert(index, tmp);
                
            }
            else if (mode == "ajout")
            {
                tmp.Numero = txtNumero.Text;
                tmp.Nom = txtNom.Text;
                tmp.Fonction = txtFonction.Text;
                tmp.Salaire = txtSalaire.Text;
                Listemployes.Add(tmp);
                index++;
                lstNumero.Items.Add(txtNumero.Text);

            }
        }

        //afficher les info des employé dans les labels
        private void lstNumero_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (Int16 g = 0; g < Listemployes.Count; g++)
            {
                if (lstNumero.SelectedItem.ToString() == Listemployes[g].Numero)
                {
                    lblNum.Text = Listemployes[g].Numero;
                    lblNm.Text = Listemployes[g].Nom;
                    lblFonc.Text = Listemployes[g].Fonction;
                    lblSal.Text = Listemployes[g].Salaire;
                }
            }
        }

        private void FrmGestiondesemploes_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter Monfichier = new StreamWriter("infoemployes.txt");
            for (Int16 i = 0; i < Listemployes.Count; i++)
            {
                Monfichier.WriteLine(Listemployes[i].Numero);
                Monfichier.WriteLine(Listemployes[i].Nom);
                Monfichier.WriteLine(Listemployes[i].Fonction);

                if (i == (Listemployes.Count - 1))
                {
                    Monfichier.Write(Listemployes[i].Salaire.ToString());
                }
                else
                {
                    Monfichier.WriteLine(Listemployes[i].Salaire.ToString());
                }
            }
            Monfichier.Close();

        }
    }
}
