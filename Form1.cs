using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
      // Metod för att köra registrera
      private void btnRegistrera_Click(object sender, EventArgs e)
{
    // Hämta inmatad information från textboxar tbxFörnamn, tbxEfternamn, tbxPersonnummer
    string förnamn = tbxFörnamn.Text;
    string efternamn = tbxEfternamn.Text;
    string personnummer = tbxPersonnummer.Text;


    // Skapa ett objekt av klassen person som har egenskaper förnamn, efternamn och personnummer
    Person nyPerson = new Person()
    {
        Förnamn = förnamn,
        Efternamn = efternamn,
        Personnummer = personnummer
    };

      // Kontrollera om personnumret är giltigt
      // Säkerställer att användaren får ett meddelande om personnummer är för kort eller i fel format
      if (!nyPerson.KontrolleraPersonnummer())
       {
       MessageBox.Show("Ogiltigt personnummer. Kontrollera längd och format.");
       return; // Avbryt registreringen om personnumret inte är giltigt
       }
                   
            // Anropa metod för att avgöra kön
            string kön = nyPerson.AvgörKön();

            // Skapa ett resultatmeddelande baserat på svaren och kontrollerna som utförts
            string resultatMeddelande = $"Förnamn: {förnamn}\nEfternamn: {efternamn}\nPersonnummer är giltigt: {nyPerson.KontrolleraPersonnummer()}\nKön: {kön}";


            // Visa resultatet i multiline textbox
            tbxResultat.Text = resultatMeddelande;

        }

        // Metod för att avsluta program
        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxPersonnummer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
