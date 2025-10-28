using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listaFilm.Add(new Film(Film.IDFilm, "volare", "pietro", 120, false, false));
        }
        public static void carica()
        {
            listaFilm.Add(new Film(Film.IDFilm, "volare", "pietro", 120, false, false));
        }
        static List<Film> listaFilm = new List<Film>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //carica();
            //for (int i = 0; i < listaFilm.Count; i++)
            //for (int i = 0; i < listaFilm.Count; i++)
            //{
            //    lsbTPInserisci.Items.Add(listaFilm[i].ID_Film + " " + listaFilm[i].Titolo + " " + listaFilm[i].Regista + " " + listaFilm[i].durata + " " + listaFilm[i].Tipo + " " + listaFilm[i].Noleggio);
            //}
        }
        private void caricatoolstrip_Click(object sender, EventArgs e)
        {
            carica();
            ////lsbTPInserisci.Items.Clear();
            //for (int i = 0; i < listaFilm.Count; i++)
            //{
            //    lsbTPInserisci.Items.Add(listaFilm[i].ID_Film + " " + listaFilm[i].Titolo + " " + listaFilm[i].Regista + " " + listaFilm[i].durata + " " + listaFilm[i].Tipo + " " + listaFilm[i].Noleggio);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTPInserisciRicerca_Click(object sender, EventArgs e)
        {
            btnTPInserisciRicerca_Click(sender, e, txbTPRicerca);
        }

        private void btnTPInserisciRicerca_Click(object sender, EventArgs e, TextBox txbTPInserisciRicerca)
        {
            bool dvd = false;
            bool trovato = false;
            if (rbTPInserisciDvd.Checked)
            {
                dvd = true;
            }
            if (txbTPRicerca.Text != "")
            {
                for (int i = 0; i < listaFilm.Count; i++)
                {
                    if (txbTPRicerca.Text == listaFilm[i].Titolo && listaFilm[i].Tipo == dvd)
                    {
                        lsbTPInserisci.Items.Add(listaFilm[i].Regista);
                        trovato = true;
                    }
                }
                if (!trovato)
                    MessageBox.Show("film non trovato");
            }
            else
            {
                MessageBox.Show("errore ricerca");
            }

        }
    
             private void txbTPRicerca_TextChanged(object sender, EventArgs e)
             {
            lsbTPInserisci.Items.Clear();

              }
    }

}

