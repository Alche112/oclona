using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectbaze
{
    public partial class ptlaptopuri : UserControl
    {

        public ptlaptopuri()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void one_shown(object sender, EventArgs e)
        {
            var context = new DataClasses2DataContext();

            // string cipherText = textBox2.Text.Trim();
            // string decryptedText = CryptorEngine.Decrypt(cipherText, true);
            var alex = from emp in context.Produses
                       where (emp.Nume == "Asus" && emp.Categorie_id == 1)
                       select emp;
            foreach (var a in alex)
            {
                label1.Text = a.Pret.ToString() + "lei";
            }
            var alex2 = from emp in context.Produses
                        where (emp.Nume == "HP" && emp.Categorie_id == 1)
                        select emp;
            foreach (var a in alex2)
            {
                label2.Text = a.Pret.ToString() + "lei";
            }
            var alex22 = from emp in context.Produses
                         where (emp.Nume == "Lenovo" && emp.Categorie_id == 1)
                         select emp;
            foreach (var a in alex22)
            {
                label3.Text = a.Pret.ToString() + "lei";
            }
        }
    }
}
