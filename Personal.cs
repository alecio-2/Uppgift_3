using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    // En Klass som heter Person.
    public class Person
    {
        // Egenskaper som förnamn, efternamn och personnummer
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Personnummer { get; set; }
    
        // Metod för att kontrollera personnummer
        public bool KontrolleraPersonnummer()
        {
            int total = 0; // Variabel för att räkna den totala summan
            int tempB = 0;// Temporär variabel för att lagra beräkningar
            int j = 0;// Variabel för att hantera multiplikator
            
            // Loopa genom personnumret
            for (int i = 2; i < Personnummer.Length+2; i++)
            {
                // Kontrollera om positionen i personnumret (i) är jämn eller udda
                if (i % 2 == 0)
                {
                    // Om positionen är jämn, sätt multiplikatorn (j) till 2.
                    j = 2;
                }
                else
                {
                    // Om positionen är udda, sätt multiplikatorn (j) till 1.
                    j = 1;
                }

                char c = Personnummer[i-2];// Hämta ett tecken från personnumret
                string charAsString = c.ToString();// Konvertera tecknet till en sträng
                int a = int.Parse(charAsString);// Konvertera strängen till ett heltal
                tempB = a * j;// Beräkna tempB genom att multiplicera a med j

                if (tempB >= 10)
                {
                    // Om tempB är större eller lika med 10, bryt ned det i enskilda siffror.
                    string tempBString = tempB.ToString();
                    int sumOfDigits = 0;

                    // Loopa igenom varje siffra i tempBString för att bryta ned det i enskilda siffror.
                    foreach (char d in tempBString)
                    {
                        int digit = int.Parse(d.ToString());
                        sumOfDigits += digit;// Lägg till varje siffra till summan av siffror.
                    }                   
                    tempB = sumOfDigits; // Lägg till tempB i den totala summan
                }
            total += tempB; // Lägg till varje siffra till summan av siffror.
            }
             
            if (total % 10 == 0)
            {
                // Om totalen är jämnt delbar med 10 är personnumret giltigt.
                return true;
            }
            else
            {
                // Annars är personnumret ogiltigt.
                return false;
            }
        }
        
        // Metod för att avgöra kön baserat på näst sista tecken.
        /* De enda uppgifter som kan utläsas ur ett personnummer är födelsetid och kön. Könet framgår av näst sista siffran i personnumret och är udda för män och jämn för kvinnor. INFORMATION TAGEN FRÅN SCB  */
        public string AvgörKön()
        {
            // Hämta det näst sista tecknet i personnumret (siffran som representerar kön)
            char könTecken = Personnummer[Personnummer.Length - 2]; // Beroende på personnumrets struktur

            // Om tecknet representerar en udda siffra (1, 3, 5, 7, 9) är det man, annars kvinna
            return (könTecken == '1' || könTecken == '3' || könTecken == '5' || könTecken == '7' || könTecken == '9') ? "Man" : "Kvinna";
        }
    }
}
    

