using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tpjavacsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceCercleClient objCom = new ServiceReference1.ServiceCercleClient();
            ServiceReference1.cercle objCercle = new ServiceReference1.cercle();
            objCercle.rayon = Convert.ToDouble( textBox1.Text);
            if(comboBox1.SelectedItem.ToString().Equals("Perimetre")){
            MessageBox.Show(" le perimetre d'un cercle de rayon :"+objCercle.rayon+"  est : "+ objCom.CalculerPerimetre(objCercle).ToString());
            }
            if (comboBox1.SelectedItem.ToString().Equals("Surface"))
            {
                MessageBox.Show("la surface d'un cercle de rayon :"+objCercle.rayon +"est : "+objCom.CalculerSurface(objCercle).ToString());
            }
            }
    }
}
