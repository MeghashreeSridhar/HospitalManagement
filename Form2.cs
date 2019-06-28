using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class Form2 : Form
    {
        private readonly Form1 frm1;

        public Form2()
        {
            InitializeComponent();
            Speciality_Box.Items.Add("Surgeon");
            Speciality_Box.Items.Add("Neurologist");
            Speciality_Box.Items.Add("Gastroenterologist");
            Speciality_Box.Items.Add("Cardiologist");
            Speciality_Box.Items.Add("Dentist");
            Speciality_Box.Items.Add("Pediatrician");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.doctor doc = new Form1.doctor();
            doc.input_doctor(frm1, this);
            MessageBox.Show("Saved!");

            
        }
    }
}
