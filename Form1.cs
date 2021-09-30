using Client2_Host_Rest.Models;
using Client2_Host_Rest.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client2_Host_Rest
{
    public partial class Form1 : Form
    {
        private Thread t1;
        delegate void Delegue();
        Delegue unDelegue;

        private void Horloge()
        {
            while (ChBTempsReel.Checked)
            {
                Thread.Sleep(1000);  //1s
                Invoke(unDelegue);

                if (t1 == null) //pour ne pas le démarrer plusieurs fois :
                {
                    t1 = new Thread(new ThreadStart(Horloge));
                    t1.Start();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            unDelegue = new Delegue(TraiterAction);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            TraiterAction();
        }

        private void TraiterAction()
        {
            string MotCle = "tous";
            if (RBtnCeJour.Checked)
                MotCle = "jour";
            DGVdemande.Rows.Clear();
            Demande dem;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<Demande> listing = TraitementSql.RecupererDemandes(MotCle);
                if (listing != null)
                {
                    for (int i = 0; i < listing.Count; i++)
                    {
                        dem = listing.ElementAt(i);
                        DGVdemande.Rows.Insert(i, dem.Host, dem.User, dem.TimeStamp.ToShortDateString(),
                            dem.Time, dem.Year, dem.Message);
                    }
                    DGVdemande.Rows[DGVdemande.Rows.Count - 1].Selected = true;
                    DGVdemande.CurrentCell = DGVdemande.Rows[DGVdemande.Rows.Count - 1].Cells[1];
                }
                Cursor.Current = Cursors.Default;
            }
            catch (EndpointNotFoundException ex)
            {
                MessageBox.Show("Désolé, on n’arrive pas à se connecter au serveur, veuillez réessayer svp.",
                    "Echéc de connexion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine("Plus de détails : \n" + ex.Message);
                ChBTempsReel.Checked = false;
            }
            catch (AggregateException ex)
            {
                MessageBox.Show("Désolé, on n’arrive pas à se connecter au serveur, veuillez réessayer svp.",
                    "Echéc de connexion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine("Plus de détails : \n" + ex.Message);

                ChBTempsReel.Checked = false;
            }
        }

        //Arreter le thread
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t1 != null)
            {
                t1.Abort();
                t1 = null;
            }
        }

        private void ChBTempsReel_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBTempsReel.Checked)
            {
                if (t1 == null) //pour ne pas le démarrer plusieurs fois :
                {
                    t1 = new Thread(new ThreadStart(Horloge));
                    t1.Start();
                }
                lblAttente.Visible = true;
                BtnOK.Enabled = false;
            }
            else
            {
                t1.Abort();
                t1 = null;
                lblAttente.Visible = false;
                BtnOK.Enabled = true;
            }
        }

    }
}
