using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Altin Zili
//Exercice TestEmail
//Date: 25/07/2019

namespace TestEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialisation du formulaire au démarage de l'application
            //vider le texte de l'email à taper
            txtemail.Text = "";
            //désactiver les checkboxs
            chkapresent.Checked = false;
            chkpointpresent.Checked = false;
            //mettre des chiffre pour avant et après l'@
            txtavant.Text = "2";
            txtapres.Text = "4";
            //Pour le champ utilisateur, vider, désactiver mettre le fond en blanc et le texte en noir
            txtnom.Text = "";
            txtnom.Enabled = false;
            txtnom.ForeColor = Color.Black;
            txtnom.BackColor = Color.White;

        }

        private void btnverif_Click(object sender, EventArgs e)
        {
            int nbcondverif = 0; 
            //nombre de condition remplies pour que l'adresse soient correctes, il faut remplir 4 conditions
            //si le champ de l'émail à vérifier est vide mettre le label émail à vérifier en rouge et afficher un message d'erreur 
            //sinon procéder aux vérifications
            if (txtemail.Text=="")
            {
                lblemail.ForeColor = Color.Red;
                MessageBox.Show("Veuillez remplir le champ Email afin de procéder à sa vérification, svp", "Champ Email Vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //placer dans une variable la position du "@" dans l'email
                int indexarobase = txtemail.Text.IndexOf("@");
                //vérifier qu'il y a un "@" donc pas d'index -1(aucune position), si c'est le cas cocher la case du "@" présent et augementer de 1 nbcondverif
                if(indexarobase != -1)
                {
                    nbcondverif++;
                    chkapresent.Checked = true;
                }
                //sinon ne pas cocher la case du "@" présent
                else
                {
                    chkapresent.Checked = false;
                }
                //vérifier qu'il y a des caractères avant "@" en demandant un index supérieur à 0(position du 1er carac)
                //et si c'est le cas augementer de 1 nbcondverif et afficher cet index, en le transformant en texte, dans le champ à cet effet
                //car vu que l'index équivaut à la position -1(car la position 1 = index 0) alors afficher le nombre de lettres avant la position du "@"
                //peut se faire en affichant l'index
                if(indexarobase > 0)
                {
                    nbcondverif++;
                    txtavant.Text = indexarobase.ToString();

                }
                //sinon afficher qu'il n'y aucun caractère avant le "@"
                else
                {
                    txtavant.Text = "0";
                }

                //sauvegarder dans une variable le nombre de caractères de l'email
                int emailtextlength = txtemail.Text.Length;


                if (indexarobase != -1)//s'il n'y a pas de "@" ne pas procéder aux calculs 
                {
                    //si l'index de "@" + 1(donc la position) est inférieure à la longeur du mail(donc il y a des carac après le "@")
                    //Afficher dans le champ à cet effet, en transformant en texte, le nombre de carac après le "@"
                    //ce qui équivaut au nombre de lettres totales moins le nombre de lettres(position) jusqu'au "@" 
                    //donc vu que l'index est de 1 plus petit que la position, il faut aussi soustraire 1 à l'index pour arriver à soustraire la position
                    if(indexarobase + 1 < emailtextlength)
                    {
                        txtapres.Text = (emailtextlength - indexarobase - 1).ToString();
                    }
                    // s'il n'y a pas de "@" aussi afficher "0"(aucun caractères après)
                    else
                    {
                        txtapres.Text = "0";
                    }
                }
                //s'il n'y a pas de "@" aussi afficher "0"
                else
                {
                    txtapres.Text = "0";
                }

                
                if (indexarobase != -1)//s'il n'y a pas de "@" ne pas procéder aux calculs 
                {
                    //Si le nombre de carac après le "@" est au moins de 4 (pour calculer le nombre de caractère après le "@" se référer au code au-dessus)
                    //Et qu'il y a un point après le "@" (en faisant en sorte que l'index du point soit supérieur à celui du "@")
                    //alors augementer de 1 nbcondverif et cocher la case du "." présent après le "@"
                    if (emailtextlength - indexarobase - 1 >= 4 && txtemail.Text.LastIndexOf(".") > indexarobase)
                    {
                        nbcondverif++;
                        chkpointpresent.Checked = true;
                    }
                    //sinon ne pas cocher la case du "." présent après le "@"
                    else
                    {
                        chkpointpresent.Checked = false;
                    }
                }
                //s'il n'y a pas de @, ne pas cocher aussi la case du "." présent après le "@"
                else
                {
                    chkpointpresent.Checked = false;
                }

                //placer dans une variable la position de l'espace dans l'email
                int indexespace = txtemail.Text.IndexOf(" ");

                //si l'espace est à l'index -1(donc absent) alors augementer de 1 nbcondverif
                if(indexespace == -1)
                {
                    nbcondverif++;
                }



                //Vérifier si les les 4 conditions nécessaires à un email correct sont remplies(donc que condverif est égal à 4)
                //Si c'est le cas, écrire le nom d'utilisateur dans le champ à cet effete en récupérant cette partie dans l'émail donné et activer le champ
                //il faut donc extraire les lettres de l'index 0(pos 1) et jusqu'au nombre de lettre avant "@", donc son index, car il équivaut à sa pos-1
                //Puis écrire dans le label tout en bas que l'adresse est correctement formée
                if (nbcondverif == 4)
                {
                    txtnom.Text = txtemail.Text.Substring(0, indexarobase);
                    lblverification.Text = "L'adresse est correctement formée";
                    txtnom.Enabled = true;
                }
                //Sinon ne rien écrire dans le champ du nom de l'utilisateur et le maintenir désactivé
                //Puis écrire dans le label tout en bas que l'adresse n'est pas correctement formée
                else
                {
                    txtnom.Text = "";
                    lblverification.Text = "L'adresse n'est pas correctement formée";
                    txtnom.Enabled = false;
                }
            }
        }
    }
}
