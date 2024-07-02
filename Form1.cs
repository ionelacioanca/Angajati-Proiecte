using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angajati
{
    public partial class Form1 : Form
    {
        //------------------------Angajati---------------------------
        public int AngajatId { get { return Convert.ToInt32(textBoxAngajatId.Text); } }
        public string NumeComplet { get { return textBoxNumeComplet.Text; } }
        public string CNP { get { return textBoxCNP.Text; } }
        public string Functie { get { return textBoxFunctie.Text; } }
        //------------------------Proiecte---------------------------
        public int ProiectId { get { return Convert.ToInt32(textBoxProiectId.Text); } }
        public int AngajatIdProiect { get { return Convert.ToInt32(textBoxAngajatIdProiect.Text); } }
        public string FunctiePeProiect { get { return textBoxFunctiePeProiect.Text; } }
        public int NrOreAlocate { get { return Convert.ToInt32(textBoxNrOreAlocate.Text); } }
        public int PlataPeOra { get { return Convert.ToInt32(textBoxPlataPeOra.Text); } }
        public Form1()
        {
            InitializeComponent();
        }

        private void angajatiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.angajatiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.firmaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'firmaDataSet.Proiecte' table. You can move, or remove it, as needed.
            this.proiecteTableAdapter.Fill(this.firmaDataSet.Proiecte);
            // TODO: This line of code loads data into the 'firmaDataSet.Angajati' table. You can move, or remove it, as needed.
            this.angajatiTableAdapter.Fill(this.firmaDataSet.Angajati);

        }


        private bool ValidareCNP(string cnp)
        {
            if(cnp.Length!=13 || Regex.IsMatch(cnp, @"^\d{12}$"))
            {
                return false;
            }

            int[] verificareCifre = { 2, 7, 9, 1, 4, 6, 3, 5, 8, 2, 7, 9 };
            int sum = 0;
            for(int i = 0; i<12; i++)
            {
                sum += int.Parse(cnp[i].ToString()) * verificareCifre[i];
            }

            int controlCifre = sum % 11;
            if(controlCifre==10)
            {
                controlCifre = 1;
            }

            return controlCifre == int.Parse(cnp[12].ToString());
        }
        private void buttonAdaugareAngajat_Click(object sender, EventArgs e)
        {
            if(!ValidareCNP(CNP))
            {
                MessageBox.Show("CNP-ul este invalid!");
                return;
            }

            try
            {
                angajatiTableAdapter.Insert(AngajatId, NumeComplet, CNP, Functie);
                tableAdapterManager.UpdateAll(firmaDataSet);
                angajatiTableAdapter.Fill(firmaDataSet.Angajati);//adauga automat informatiile despre angajat in tabel

                this.Validate();
                this.angajatiBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.firmaDataSet);

                MessageBox.Show("Angajatul a fost adaugat cu succes!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Angajatul nu a putut fi adaugat!{ex.Message}");
            }

        }

        private void buttonAdaugareProiect_Click(object sender, EventArgs e)
        {
            try
            {
                int angajatIdProiect = (int)((DataRowView)angajatiBindingSource.Current)["AngajatId"];
                textBoxAngajatIdProiect.Text = angajatIdProiect.ToString();
                proiecteTableAdapter.Insert(ProiectId, angajatIdProiect, FunctiePeProiect, NrOreAlocate, PlataPeOra);
                tableAdapterManager.UpdateAll(firmaDataSet);
                proiecteTableAdapter.Fill(firmaDataSet.Proiecte);

                MessageBox.Show("Proiectul a fost adaugat cu succes!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Proiectul nu a putut fi adaugat! {ex.Message}");
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            string angajatCautat = textBoxCautare.Text.Trim();
            if (!string.IsNullOrWhiteSpace(angajatCautat))
            {
                angajatiBindingSource.Filter = $"Nume_complet LIKE '%{angajatCautat}%'";
            }
            else
            {
                angajatiBindingSource.RemoveFilter();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            StreamWriter w = new StreamWriter(dir + "\\Statistici.txt", false);

            foreach(DataRowView angajat in angajatiBindingSource)
            {
                int angajatId = (int)angajat.Row["AngajatId"];
                string nume = (string)angajat.Row["Nume_complet"];
                string cnp = (string)angajat.Row["CNP"];
                string functie = (string)angajat.Row["Functie"];
                w.WriteLine("Id angajat: " + angajatId);
                w.WriteLine("Nume: " + nume);
                w.WriteLine("CNP: " + cnp);
                w.WriteLine("Functie: " + functie);

                foreach (DataRowView proiect in proiecteBindingSource)
                {
                    int nrOreAlocate = (int)proiect.Row["Nr_ore_alocate"];
                    int plataOra = (int)proiect.Row["Plata_pe_ora"];
                    int salariu = nrOreAlocate * plataOra;
                    w.WriteLine("Salariu pe proiect: " + salariu);

                }
            }
            w.Close();
            Process.Start("notepad.exe", dir + "\\Statistici.txt");

        }
    }
}
