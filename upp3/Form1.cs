//Ruimin Ma, ruimac-1@student.ltu.se, L0002B, Uppgift 3
//Jinting Zhang, jinzha-2@student.ltu.se, L0002B, Uppgift 3
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text);
            string personNo = person.Getprnr();
            bool check = person.Checkprnr(personNo);
            try
            {
                if (check)
                {
                    fornamnsvar.Text = "Förnamn :" + person.Getfornamn();
                    efternamnsvar.Text = "Efternamn :" + person.Getefternamn();
                    konsvar.Text = person.Getkon();
                    personnummersvar.Text = "Personnummer :" + personNo;
                }else
                    personnummersvar.Text = "Felaktigt uppgift!";
            }
            catch(Exception)
            {
                personnummersvar.Text = "Felaktigt uppgift!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void fornamnsvar_Click(object sender, EventArgs e)
        {

        }

        private void efternamnsvar_Click(object sender, EventArgs e)
        {

        }

        private void personnummersvar_Click(object sender, EventArgs e)
        {

        }

        private void konsvar_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }





}