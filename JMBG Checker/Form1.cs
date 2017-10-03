using System;
using System.Windows.Forms;


/*
 * Poznati bagovi: Ne radi sa osobama koje su rodjene nakon 31.12.2000
 * Developed by: nef0s
 * Credits: Pavlex4
 * Date: 09.10.2017
 */


namespace JMBG_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int dan, mesec, godina;
        private string drzava;
        private int muski_pol = 0, zenski_pol = 0;
        private int A, B, V, G, D, Đ, E, Ž, Z, I, J, K, L;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            pictureBox1.Image = null;
            label3.Text = "";
            label4.Text = "";
            label8.Text = "";
            label10.Text = "";
            label11.Text = "";
            button1.Enabled = false;
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (drzava.StartsWith("7"))
            {
                if (drzava == "71")
                    MessageBox.Show("Grad Beograd: Stari Grad, Savski Venac, Voždovac, Vračar, Palilula, Zvezdara, Rakovica, Čukarica, Novi Beograd, Zemun, Mladenovac, Barajevo, Grocka, Obrenovac, Sopot, Lazarevac", "Region Beograd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "72")
                    MessageBox.Show("Šumadijski okrug: Aranđelovac, Batočina, Knić, Kragujevac, Rača, Lapovo, Topola), (Pomoravski okrug: Despotovac, Paraćin, Rekovac, Jagodina, Svilajnac, Ćuprija", "Region Šumadija i Pomoravlje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "73")
                    MessageBox.Show("Nišavski okrug: Aleksinac, Svrljig, Niš, Gadžin Han, Doljevac, Merošina, Ražanj), (Pirotski okrug: Babušnica, Bela Palanka, Dimitrovgrad, Pirot), (Toplički okrug: Blace, Žitorađa, Prokuplje, Kuršumlija", "Region Niš", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "74")
                    MessageBox.Show("Jablanički okrug: Leskovac, Vlasotince, Medveđa, Lebane, Bojnik, Crna Trava), (Pčinjski okrug: Vranje, Bujanovac, Surdulica, Bosilegrad, Preševo, Trgovište, Vladičin Han", "Južna Morava region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "75")
                    MessageBox.Show("Zaječarski okrug: Zaječar, Boljevac, Knjaževac, Sokobanja), (Borski okrug: Bor, Majdanpek, Kladovo, Negotin", "Zaječar region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "76")
                    MessageBox.Show("Podunavski okrug: Smederevska Palanka, Velika Plana, Smederevo), (Braničevski okrug: Veliko Gradište, Kučevo, Petrovac na Mlavi, Požarevac, Žagubica, Golubac, Žabari, Malo Crniće", "Podunavlje region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "77")
                    MessageBox.Show("Mačvanski okrug: Loznica, Krupanj, Ljubovija, Šabac, Bogatić, Koceljeva, Vladimirci, Mali Zvornik), (Kolubarski okrug: Valjevo, Lajkovac, Ljig, Ub, Osečina, Mionoca", "Podrinje i Kolubara region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "78")
                    MessageBox.Show("Raški okrug: Kraljevo, Vrnjačka Banja, Novi Pazar, Raška, Tutin), (Moravički okrug: Gornji Milanovac, Čačak, Ivanjica, Lučani), (Rasinski okrug: Aleksandrovac, Brus, Kruševac, Trstenik, Varvarin, Ćićevac", "Kraljevo region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "79")
                    MessageBox.Show("Zlatiborski okrug: Arilje, Bajina Bašta, Kosjerić, Nova Varoš, Požega, Priboj, Prijepolje, Sjenica, Užice, Čajetina", "Užice region", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (drzava.StartsWith("8"))
            {
                if (drzava == "80")
                    MessageBox.Show("Južnobački okrug: Bač, Bačka Palanka, Bački Petrovac, Vrbas, Žabalj, Novi Sad, Srbobran, Sremski Karlovci, Temerin, Titel, Bečej, Beočin", "Novi Sad region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "81")
                    MessageBox.Show("Zapadnobački okrug: Apatin, Kula, Odžaci, Sombor", "Sombor region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "82")
                    MessageBox.Show("Severnobački okrug: Bačka Topola, Subotica, Mali Iđoš", "Subotica region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "85")
                    MessageBox.Show("Srednjebanatski okrug: Zrenjanin, Nova Crnja, Novi Bečej, Sečanj, Žitište", "Zrenjanin region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "86")
                    MessageBox.Show("Južnobanatski okrug: Alibunar, Bela Crkva, Vršac, Kovačica, Kovin, Pančevo, Opovo, Plandište", "Pančevo region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "87")
                    MessageBox.Show("Severnobanatski okrug: Ada, Kikinda, Kanjiža, Novi Kneževac, Senta, Čoka", "Kikinda region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "88")
                    MessageBox.Show("Sremski okrug: Inđija, Pećinci, Ruma, Sremska Mitrovica, Stara Pazova, Šid, Irig", "Ruma region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "89")
                    MessageBox.Show("Sremski okrug: Inđija, Pećinci, Ruma, Sremska Mitrovica, Stara Pazova, Šid, Irig", "Sremska Mitrovica region", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (drzava.StartsWith("9"))
            {
                if (drzava == "91")
                    MessageBox.Show("Kosovski okrug: Priština, Obilić, Podujevo, Štrpce, Lipljan, Glogovac, Kačanik, Kosovo Polje, Uroševac, Štimlje", "Priština region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "92")
                    MessageBox.Show("Kosovsko Mitrovački okrug: Kosovska Mitrovica, Zvečan, Leposavić, Zubin Potok, Vučitrn, Srbica", "Kosovska Mitrovica region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "93")
                    MessageBox.Show("Pećki okrug: Peć, Istok, Klina", "Peć region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "94")
                    MessageBox.Show("Pećki okrug: Dečani, Đakovica", "Đakovica region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "95")
                    MessageBox.Show("Prizrenski okrug: Gora-Dragaš, Orahovac, Prizren, Suva Reka", "Prizren region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (drzava == "96")
                    MessageBox.Show("Gnjilane, Kosovska Kamenica, Vitina, Novo Brdo", "Kosovsko Pomoravski okrug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pogresna drzava");
                return;
            }
        }

        private int kontrolna_cifra;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label3.Hide();
            label4.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            button1.Hide();
        }
        private void proveriJMBG(string jmbgUnos)
        {
            dan = Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 11));
            mesec = Convert.ToInt32(textBox1.Text.Substring(2, textBox1.Text.Length - 11));
            godina = Convert.ToInt32(textBox1.Text.Substring(4, textBox1.Text.Length - 10));

            //Provera godine
            if (godina.ToString() == "0")
            {
                godina += 2000;
            }
            else
            {
                godina += 1000;
            }

            label8.Text = dan + "." + mesec + "." + godina;

            drzava = textBox1.Text.Substring(7, textBox1.Text.Length - 11);

            proveri_mesec_dan_godinu(dan, mesec, godina);
            proveri_drzavu_grad(drzava);
            provera_pol(muski_pol, zenski_pol);
            kontrolni_broj(kontrolna_cifra);

        }
        private bool proveri_mesec_dan_godinu(int dan, int mesec, int godina)
        {
            if (mesec == 1 && dan > 31)
            {
                MessageBox.Show("Januar ne moze da ima vise od 31 dan!");
                return false;
            }
            if (mesec == 2 && godina % 4 == 0 && dan > 29)
            {
                MessageBox.Show("Februar ne moze da ima vise od 29 dana ako je godina prestupna!");
                return false;
            }
            if (mesec == 2 && godina % 4 != 0 && dan > 28)
            {
                MessageBox.Show("Februar ne moze da ima vise od 28 dana ako godina nije prestupna!");
                return false;
            }
            if (mesec == 3 && dan > 31)
            {
                MessageBox.Show("Mart ne moze da ima vise od 31 dan!");
                return false;
            }
            if (mesec == 4 && dan > 30)
            {
                MessageBox.Show("April ne moze da ima vise od 30 dana!");
                return false;
            }
            if (mesec == 5 && dan > 31)
            {
                MessageBox.Show("Maj ne moze da ima vide od 31 dan!");
                return false;
            }
            if (mesec == 6 && dan > 30)
            {
                MessageBox.Show("Jun ne moze da ima vide od 30 dana!");
                return false;
            }
            if (mesec == 7 && dan > 31)
            {
                MessageBox.Show("Jul ne moze da ima vide od 31 dan!");
                return false;
            }
            if (mesec == 8 && dan > 31)
            {
                MessageBox.Show("Avgust ne moze da ima vide od 31 dan!");
                return false;
            }
            if (mesec == 9 && dan > 30)
            {
                MessageBox.Show("Septembar ne moze da ima vide od 30 dana!");
                return false;
            }
            if (mesec == 10 && dan > 31)
            {
                MessageBox.Show("Oktobar ne moze da ima vide od 31 dan!");
                return false;
            }
            if (mesec == 11 && dan > 30)
            {
                MessageBox.Show("Novembar ne moze da ima vide od 30 dana!");
                return false;
            }
            if (mesec == 12 && dan > 31)
            {
                MessageBox.Show("Septembar ne moze da ima vide od 31 dan!");
                return false;
            }
            if (mesec == 13)
            {
                MessageBox.Show("Pogresan mesec!");
                return false;
            }
            /*if (godina < 1900)
            {
                MessageBox.Show("Godina ne moze da bude manja od 1900-te!");
                return false;
            }
            */
            if (godina > DateTime.Now.Year)
            {
                MessageBox.Show("Godina ne moze da bude veca od sadanje!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void proveri_drzavu_grad(string drzava)
        {
            //Bez drzavaljanstva
            if (drzava.StartsWith("0"))
            {
                if (drzava == "01" || drzava == "02" || drzava == "03" || drzava == "04" || drzava == "05" || drzava == "07" || drzava == "08" || drzava == "09")
                {
                    label3.Text = "Stranci bez državljanstva bivše SFRJ ili njenih naslednica";
                    pictureBox1.Image = imageList1.Images[0];
                }
                if (drzava == "01")
                    label4.Text = "Stranci u BiH";
                if (drzava == "02")
                    label4.Text = "Stranci u Crnoj Gori";
                if (drzava == "03")
                    label4.Text = "Stranci u Hrvatskoj";
                if (drzava == "04")
                    label4.Text = "Stranci u Makedoniji";
                if (drzava == "05")
                    label4.Text = "Stranci u Sloveniji";
                if (drzava == "07")
                    label4.Text = "Stranci u Srbiji (bez pokrajina)";
                if (drzava == "08")
                    label4.Text = "Stranci u Vojvodini";
                if (drzava == "09")
                    label4.Text = "Stranci na Kosovu";
            }

            //BIH
            else if (drzava.StartsWith("1"))
            {
                if (drzava == "10" || drzava == "11" || drzava == "12" || drzava == "13" || drzava == "14" || drzava == "15" || drzava == "16" || drzava == "17" || drzava == "18" || drzava == "19")
                {
                    label3.Text = "Bosna i Hercegovina";
                    pictureBox1.Image = imageList1.Images[1];
                }
                if (drzava == "10")
                    label4.Text = "Banja Luka";
                if (drzava == "11")
                    label4.Text = "Bihać";
                if (drzava == "12")
                    label4.Text = "Doboj";
                if (drzava == "13")
                    label4.Text = "Goražde";
                if (drzava == "14")
                    label4.Text = "Livno";
                if (drzava == "15")
                    label4.Text = "Mostar";
                if (drzava == "16")
                    label4.Text = "Prijedor";
                if (drzava == "17")
                    label4.Text = "Sarajevo";
                if (drzava == "18")
                    label4.Text = "Tuzla";
                if (drzava == "19")
                    label4.Text = "Zenica";
            }

            //Crna Gora
            else if (drzava.StartsWith("2"))
            {
                if (drzava == "21" || drzava == "26" || drzava == "29")
                {
                    label3.Text = "Crna Gora";
                    pictureBox1.Image = imageList1.Images[2];
                }
                if (drzava == "21")
                    label4.Text = "Podgorica";
                if (drzava == "26")
                    label4.Text = "Nikšić";
                if (drzava == "29")
                    label4.Text = "Pljevlja";
            }

            //Hrvacka hehe
            else if (drzava.StartsWith("3"))
            {
                if (drzava == "30" || drzava == "31" || drzava == "32" || drzava == "33" || drzava == "34" || drzava == "35" || drzava == "36" || drzava == "37" || drzava == "38" || drzava == "39")
                {
                    label3.Text = "Hrvatska";
                    pictureBox1.Image = imageList1.Images[3];
                }
                if (drzava == "30")
                    label4.Text = "Osijek, Slavonija region";
                if (drzava == "31")
                    label4.Text = "Bjelovar, Virovitica, Koprivnica, Pakrac, Podravina region";
                if (drzava == "32")
                    label4.Text = "Varaždin, Međimurje region";
                if (drzava == "33")
                    label4.Text = "Zagreb";
                if (drzava == "34")
                    label4.Text = "Karlovac";
                if (drzava == "35")
                    label4.Text = "Gospić, Lika region";
                if (drzava == "36")
                    label4.Text = "Rijeka, Pula, Istra and Primorje regions";
                if (drzava == "37")
                    label4.Text = "Sisak, Banovina region";
                if (drzava == "38")
                    label4.Text = "Split, Zadar, Dubrovnik, Dalmacija region";
                if (drzava == "39")
                    label4.Text = "mešano";
            }

            //FYROM
            else if (drzava.StartsWith("4"))
            {
                if (drzava == "41" || drzava == "42" || drzava == "43" || drzava == "44" || drzava == "45" || drzava == "46" || drzava == "47" || drzava == "48" || drzava == "49")
                {
                    label3.Text = "Makedonija";
                    pictureBox1.Image = imageList1.Images[4];
                }
                if (drzava == "41")
                    label4.Text = "Bitola";
                if (drzava == "42")
                    label4.Text = "Kumanovo";
                if (drzava == "43")
                    label4.Text = "Ohrid";
                if (drzava == "44")
                    label4.Text = "Prilep";
                if (drzava == "45")
                    label4.Text = "Skopje";
                if (drzava == "46")
                    label4.Text = "Strumica";
                if (drzava == "47")
                    label4.Text = "Tetovo";
                if (drzava == "48")
                    label4.Text = "Veles";
                if (drzava == "49")
                    label4.Text = "Štip";
            }

            //Slovenija
            else if (drzava.StartsWith("5"))
            {
                if (drzava == "50")
                {
                    label3.Text = "Slovenija";
                    pictureBox1.Image = imageList1.Images[5];
                }
            }

            //Srbija
            else if (drzava.StartsWith("7"))
            {
                if (drzava == "71" || drzava == "72" || drzava == "73" || drzava == "74" || drzava == "75" || drzava == "76" || drzava == "77" || drzava == "78" || drzava == "79")
                {
                    label3.Text = "Srbija";
                    pictureBox1.Image = imageList1.Images[6];
                }
                if (drzava == "71")
                    label4.Text = "Region Beograd";
                if (drzava == "72")
                    label4.Text = "Region Šumadija i Pomoravlje";
                if (drzava == "73")
                    label4.Text = "Niš region";
                if (drzava == "74")
                    label4.Text = "Južna Morava region";
                if (drzava == "75")
                    label4.Text = "Zaječar region";
                if (drzava == "76")
                    label4.Text = "Podunavlje region";
                if (drzava == "77")
                    label4.Text = "Podrinje i Kolubara region";
                if (drzava == "78")
                    label4.Text = "Kraljevo region";
                if (drzava == "79")
                    label4.Text = "Užice region";
            }

            //Autonomna Pokrajina Vojvodina
            else if (drzava.StartsWith("8"))
            {
                if (drzava == "80" || drzava == "81" || drzava == "82" || drzava == "85" || drzava == "86" || drzava == "87" || drzava == "88" || drzava == "89")
                {
                    label3.Text = "Autonomna Pokrajina Vojvodina";
                    pictureBox1.Image = imageList1.Images[6];
                }
                if (drzava == "80")
                    label4.Text = "Novi Sad region";
                if (drzava == "81")
                    label4.Text = "Sombor region";
                if (drzava == "82")
                    label4.Text = "Subotica region";
                if (drzava == "85")
                    label4.Text = "Zrenjanin region";
                if (drzava == "86")
                    label4.Text = "Pančevo region";
                if (drzava == "87")
                    label4.Text = "Kikinda region";
                if (drzava == "88")
                    label4.Text = "Ruma region";
                if (drzava == "89")
                    label4.Text = "Sremska Mitrovica region";
            }

            //Autonomna Pokrajina Kosovo i Metohija
            else if (drzava.StartsWith("9"))
            {
                if (drzava == "91" || drzava == "92" || drzava == "93" || drzava == "94" || drzava == "95" || drzava == "96")
                {
                    label3.Text = "Autonomna Pokrajina Kosovo i Metohija";
                    pictureBox1.Image = imageList1.Images[6];
                }
                if (drzava == "91")
                    label4.Text = "Priština region";
                if (drzava == "92")
                    label4.Text = "Kosovska Mitrovica region";
                if (drzava == "93")
                    label4.Text = "Peć region";
                if (drzava == "94")
                    label4.Text = "Đakovica region";
                if (drzava == "95")
                    label4.Text = "Prizren region";
                if (drzava == "96")
                    label4.Text = "Kosovsko Pomoravski okrug";
            }
            else
            {
                MessageBox.Show("Pogresna drzava");
                return;
            }
        }
        private void provera_pol(int muski_pol, int zenski_pol)
        {
            muski_pol = Convert.ToInt32(textBox1.Text.Substring(9, textBox1.Text.Length - 10));
            zenski_pol = Convert.ToInt32(textBox1.Text.Substring(9, textBox1.Text.Length - 10));

            if (muski_pol >= 0 && muski_pol <= 499)
            {
                label10.Text = "Muski";
                label11.Text = muski_pol.ToString();
            }
            else if (zenski_pol >= 500 && zenski_pol <= 999)
            {
                label10.Text = "Ženski";
                label11.Text = zenski_pol.ToString();
            }
            else
            {
                MessageBox.Show("Pogresan pol");
            }
        }

        private void kontrolni_broj(int kontrolna_cifra)
        {
            A = Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 12));
            B = Convert.ToInt32(textBox1.Text.Substring(1, textBox1.Text.Length - 12));
            V = Convert.ToInt32(textBox1.Text.Substring(2, textBox1.Text.Length - 12));
            G = Convert.ToInt32(textBox1.Text.Substring(3, textBox1.Text.Length - 12));
            D = Convert.ToInt32(textBox1.Text.Substring(4, textBox1.Text.Length - 12));
            Đ = Convert.ToInt32(textBox1.Text.Substring(5, textBox1.Text.Length - 12));
            E = Convert.ToInt32(textBox1.Text.Substring(6, textBox1.Text.Length - 12));
            Ž = Convert.ToInt32(textBox1.Text.Substring(7, textBox1.Text.Length - 12));
            Z = Convert.ToInt32(textBox1.Text.Substring(8, textBox1.Text.Length - 12));
            I = Convert.ToInt32(textBox1.Text.Substring(9, textBox1.Text.Length - 12));
            J = Convert.ToInt32(textBox1.Text.Substring(10, textBox1.Text.Length - 12));
            K = Convert.ToInt32(textBox1.Text.Substring(11, textBox1.Text.Length - 12));
            L = Convert.ToInt32(textBox1.Text.Substring(12, textBox1.Text.Length - 12));

            kontrolna_cifra = 11 - ((7 * (A + E) + 6 * (B + Ž) + 5 * (V + Z) + 4 * (G + I) + 3 * (D + J) + 2 * (Đ + K)) % 11);

            if (kontrolna_cifra <= 9)
            {
                if (kontrolna_cifra != L)
                {
                    MessageBox.Show("JMBG Nije dobar.Kontrolna cifra se ne slaze!","JMBG",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox1.Text = "";
                    pictureBox1.Image = null;
                    label3.Text = "";
                    label4.Text = "";
                    label8.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                    button1.Enabled = false;
                    textBox1.Focus();

                    return;
                }
            }
            else if (kontrolna_cifra > 9)
            {
                if (L != 0)
                {
                    MessageBox.Show("JMBG Nije dobar.Kontrolna cifra se ne slaze!");

                    textBox1.Text = "";
                    pictureBox1.Image = null;
                    label3.Text = "";
                    label4.Text = "";
                    label8.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                    button1.Enabled = false;
                    textBox1.Focus();

                    return;
                }
            }
            else
            {
                MessageBox.Show("Proverite JMBG zbog greske u maticnom broju!");

                textBox1.Text = "";
                pictureBox1.Image = null;
                label3.Text = "";
                label4.Text = "";
                label8.Text = "";
                label10.Text = "";
                label11.Text = "";
                button1.Enabled = false;
                textBox1.Focus();

                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string jmbgUnos;
            jmbgUnos = textBox1.Text;
            for (int i = 0; i < jmbgUnos.Length; i++)
            {
                if (jmbgUnos.Length == 13)
                {
                    proveriJMBG(jmbgUnos);
                    button1.Enabled = true;
                    break;
                }
                else
                    continue;
            }
            pictureBox1.Show();
            label3.Show();
            label4.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            button1.Show();
        }
    }
}
