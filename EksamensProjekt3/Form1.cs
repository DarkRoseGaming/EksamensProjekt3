using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EksamensProjekt3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //da winform er baseret på events laver vi et event der er baseret på ticks
            //disse events opdatere vores 2 "områder" den på 5 min(sat til 5 sek) og den på 1 sek(sat til 0.5 sek atm)
            Timer urUpdate = new Timer();
            urUpdate.Interval = (500); // 0,5 sec
            urUpdate.Tick += new EventHandler(urUpdate_Tick);
            urUpdate.Start();

            Timer lagerUpdate = new Timer();
            lagerUpdate.Interval = (5000); //5 sek
            lagerUpdate.Tick += new EventHandler(lagerUpdate_Tick);
            lagerUpdate.Start();

            //for god ordens skyld starter vi med at kalde den så når vi starter programmet at der kommer noget op med det samme og ikke efter 5 sek mv

            updateUr();
            updateLager();
        }


        private void lagerUpdate_Tick(object sender, EventArgs e)
        {
            //kalder vores updateLager
            updateLager();
        }

        private void urUpdate_Tick(object sender, EventArgs e)
        {
            //kalder vores urUpdate
            updateUr();
        }

        private void updateLager()
        {
            //import af reference
            Monitor.monitorSoapClient los = new Monitor.monitorSoapClient();

            //fortæller LagerTemp at texten skal opdateres 
            LagerTemp.Text = $"{los.StockTemp().ToString("N2") + "°C"}";
            //same
            LagerFugt.Text = $"{los.StockHumidity().ToString("N2") + "%"}";
            //same
            UdenforTemp.Text = $"{los.OutdoorTemp().ToString("N2") + "°C"}";
            //same
            UdenforFugt.Text = $"{los.OutdoorHumidity().ToString("N2") + "%"}";

            //laver nrofitems for at den kan finde ud af at den ikke skal smide output i vores foreach oven i hindanden
            int nrOfItems = 0;

            //gør det samme som den foreach vi fik udleveret, laver en linje pr "line" i stockitemsundermin
            foreach (string line in los.StockItemsUnderMin())
            {
                Label newLabel = new Label(); //laver en ny label hver gang
                newLabel.Text = line; //deffinere hvor vi skal ændre (dette tilfælde text)
                VarerMinGroup.Controls.Add(newLabel); //tilføler newlabel til group container VarerMinGroup
                newLabel.Size = new Size(300, 20); //hvor stor skal boxen hvor output kommer være
                newLabel.Location = new Point(20, 20 + 22 * nrOfItems); //hvor skal output placeres
                nrOfItems++; //tæller nrofitems op

            }

            //samme som forrige foreach
            nrOfItems = 0;
            foreach (string line in los.StockItemsOverMax())
            {
                Label newLabel = new Label();
                newLabel.Text = line;
                VarerMaksGroup.Controls.Add(newLabel);
                newLabel.Size = new Size(300, 20);
                newLabel.Location = new Point(20, 20 + 22 * nrOfItems);
                nrOfItems++;

            }

            //samme som forrige foreach
            nrOfItems = 0;
            foreach (string line in los.StockItemsMostSold())
            {
                Label newLabel = new Label();
                newLabel.Text = line;
                SolgtIDagGroup.Controls.Add(newLabel);
                newLabel.Size = new Size(300, 20);
                newLabel.Location = new Point(20, 20 + 22 * nrOfItems);
                nrOfItems++;

            }

;

        }

        private void updateUr() //her ligger vores kode angående ur
        {
            //importere vores nuværende tid
            DateTime danmark = DateTime.Now;

            TimeZoneInfo centralAmericazone, chinazone; //laver cinazone og ca så vi kan kalde dem senere
            DateTime china, USA; //laver usa og china så vi kan kalde dem senere

            chinazone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time"); //går ind og finder chinas tid ud fra dens id
            centralAmericazone = TimeZoneInfo.FindSystemTimeZoneById("Central America Standard Time"); //går ind og finder ca ud fra dens id

            USA = TimeZoneInfo.ConvertTime(DateTime.Now, centralAmericazone); //konvertere den værdi du har fået oppe i ca til noget der kan bruges
            china = TimeZoneInfo.ConvertTime(DateTime.Now, chinazone); //same as before


            KøbenhavnTime.Text = $"{danmark}"; //opdatere text i københavntime
            ChinaTime.Text = china.ToString(); //opdatere text i china time
            USATime.Text = USA.ToString(); //opdatere text i usatime


        }




    }
}
