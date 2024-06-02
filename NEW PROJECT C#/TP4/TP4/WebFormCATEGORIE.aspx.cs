using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP4
{
    public partial class WebFormCATEGORIE : System.Web.UI.Page
    {   // Instanciation d'un objet ClassDB pour gérer les opérations de base de données
        ClassDB cdb = new ClassDB();
        protected void Page_Load(object sender, EventArgs e)
        {   if (!IsPostBack)//inserer la modification //avant el affiche ensiens
            {
                cdb.remplirGV(GridView2, "select * from categorie");
            }
            
        }

        protected void BtnInsereCat_Click(object sender, EventArgs e)
        {    //pour insere les info
            string req = "insert into categorie values('" + tbIdCat.Text + "','" + tbNomCat.Text + "')";
            cdb.insertRow(req);
            //Response.Write("<script language='javascript'>alert('La catégorie " + tbNomCat.Text +
            //" (Id=" + tbIdCat.Text + ") a été bien ajoutée.');</script>"); takhraj plaka
            
            //afficher apres l' insertion

            cdb.remplirGV(GridView2, "select * from categorie");
            //label AFICHAGE
            Label1.Text = "La categorie " + tbNomCat.Text +
                " (id=" + tbIdCat.Text + ") a ete bien ajoutee.";

            //VIDER
            tbIdCat.Text = "";
            tbNomCat.Text = "";

        }
        //SUPP
        //SUPP
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {    //propreite dataKeyNames tu pu pas suppremier
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value);
            //supp delete
            string req = "delete from categorie where idcat=' " + id + "'";
            cdb.deleteRow(req);
            //mis à jour actualise
            cdb.remplirGV(GridView2, "select * from categorie");
        }

        protected void GridView2_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView2.Rows[e.NewSelectedIndex].BackColor = System.Drawing.Color.Red;
            //3 col TXB
            tbIdCat.Text = GridView2.Rows[e.NewSelectedIndex].Cells[3].Text;
            //4coll  TXB
            tbNomCat.Text = GridView2.Rows[e.NewSelectedIndex].Cells[4].Text;
        }
        //modefier
        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Elle récupère l'index de la ligne à éditer à partir de l'argument e.
            //Elle affecte cet index à la propriété EditIndex du GridView2.
            GridView2.EditIndex = e.NewEditIndex;
        }
        //modefier
        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {   //tu Bpu pas modifier
            int idcat = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value);
            //gridview > textbox v// Récupérer le nouveau nom de la catégorie à partir du TextBox dans la GridView
            string nomcat = ((TextBox)GridView2.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            //req pour moudefier "select* from"// Construction de la requête SQL pour mettre à jour la catégorie
            string req = "update categorie set nomcat='" + nomcat + "'Where idcat='" + idcat + "'";
            // Exécuter la requête de mise à jour
            cdb.updateRow(req);
            //COMMENTAIR v
            Response.Write(req);
            // Réinitialiser l'index d'édition et recharger GridView
            GridView2.EditIndex = -1;
            cdb.remplirGV(GridView2, "select * from categorie");
        }
        //annuler
        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            cdb.remplirGV(GridView2, "select * from categorie");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cdb.remplirGV(GridView2, "select * from categorie  where nomcat like '%"+TextBox1.Text+"%'");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
} 