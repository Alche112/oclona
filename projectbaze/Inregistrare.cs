using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbaze
{
    public partial class Inregistrare : Form
    {
        Form1 frm;
        public Inregistrare(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clearText = textBox2.Text.Trim();
              string cipherText = CryptorEngine.Encrypt(clearText, true);
            try
            {
              
                DataClasses2DataContext data = new DataClasses2DataContext();

                // string Insertstatement = "Insert into Useri values('textBox1.Text', textBox2.Text,textBox3.Text,textBox4.Text)";
                //data.ExecuteQuery<Useri>(Insertstatement);
                
                var employee = new Useri
                {
                    Username = textBox1.Text,
                    Parola = cipherText,
                    email = textBox3.Text,
                    adresa = textBox4.Text
                };
                data.Useris.InsertOnSubmit(employee);
                data.SubmitChanges();
                MessageBox.Show("User inregistrat");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
