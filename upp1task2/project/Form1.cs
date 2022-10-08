using System;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            int pris = Convert.ToInt32(txb_pris.Text);

            int betalning = Convert.ToInt32(txb_deposit.Text);

            int sum = betalning - pris;

            if (sum > 0)
            {
                txb_byte.AppendText($"Pengar tillbaka: {sum} kr");
                txb_byte.AppendText(Environment.NewLine);

                int tvåhundra, hundra, femtio, tjugo, tio, fem, en;
                while (sum >= 200)
                {
                    tvåhundra = sum / 200;
                    sum = sum % 200;
                    txb_byte.AppendText(tvåhundra + " tvåhundralappar");
                    txb_byte.AppendText(Environment.NewLine);                
                }
                while (sum >= 100)
                {
                    hundra = sum / 100;
                    sum = sum % 100;
                    txb_byte.AppendText(hundra + " hundralappar");
                    txb_byte.AppendText(Environment.NewLine);
                }
                while (sum >= 50)
                {
                    femtio = sum / 50;
                    sum = sum % 50;
                    txb_byte.AppendText(femtio + " femtiolappar");
                    txb_byte.AppendText(Environment.NewLine);
                }
                while (sum >= 20)
                {
                    tjugo = sum / 20;
                    sum = sum % 20;
                    txb_byte.AppendText(tjugo + " tjugolappar");
                    txb_byte.AppendText(Environment.NewLine);
                }
                while (sum >= 10)
                {
                    tio = sum / 10;
                    sum = sum % 10;
                    txb_byte.AppendText(tio + " tiokronor");
                    txb_byte.AppendText(Environment.NewLine);
                }
                while (sum >= 5)
                {
                    fem = sum / 5;
                    sum = sum % 5;
                    txb_byte.AppendText(fem + " femkronor");
                    txb_byte.AppendText(Environment.NewLine);
                }
                while (sum >= 1)
                {
                    en = sum / 1;
                    sum = sum % 1;
                    txb_byte.AppendText(en + " enkronor");
                    txb_byte.AppendText(Environment.NewLine);
                }             
            }
            else if (sum == 0)
            {
                txb_byte.AppendText("Tack för att betala exakt rätt!");
                txb_byte.AppendText(Environment.NewLine);
                txb_byte.AppendText("\n--------------------------------------------------------\n");
                txb_byte.AppendText(Environment.NewLine);          
            }
            else
            {
                txb_byte.AppendText("Du saknar {Math.Abs(sum)} kr ");
                txb_byte.AppendText(Environment.NewLine);
                txb_byte.AppendText("\n--------------------------------------------------------\n");
                txb_byte.AppendText(Environment.NewLine);               
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}