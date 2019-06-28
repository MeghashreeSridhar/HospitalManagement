using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HospitalManagement
{
    public partial class Form3 : Form
    {
        private Form1 frm;

        public Form3()
        {
            InitializeComponent();

            {

                comboBox_disease.Items.Add("Headache");
                comboBox_disease.Items.Add("Toothache");
                comboBox_disease.Items.Add("Stomachache");
                comboBox_disease.Items.Add("Heart attack");
                comboBox_disease.Items.Add("Operation");
                comboBox_disease.Items.Add("Child fever");



            }

            this.Doc_name.SelectedIndexChanged +=
            new System.EventHandler(nameChanged);

           
            this.comboBox_disease.SelectedIndexChanged +=
            new System.EventHandler(disChanged);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.patient PAT = new Form1.patient();

            PAT.input_patient(frm, this);
            MessageBox.Show("Saved!");
        }


        private void disChanged(object sender, System.EventArgs e)
        {
            Doc_name.Items.Clear();
            Doc_name.Text = "";
            FileStream fs = new FileStream("doctors.txt", FileMode.Open);
            string spec=" ";
            string dis = comboBox_disease.Text;
            if (dis == "Headache")
                spec = "Neurologist";
            else if (dis == "Toothache")
                spec = "Dentist";
            else if(dis == "Stomachache")
                spec = "Gastroenterologist";
            else if (dis == "Heart attack")
                spec = "Cardiologist";
            else if (dis == "Operation")
                spec = "Surgeon";
            else if (dis == "Child fever")
                spec = "Pediatrician";
           
            


            string[] field;
            int rec_length;
            byte[] rec_doctor;
            string record_doctor = "";


            while (fs.Position != fs.Length)
            {
                record_doctor = "";
                rec_length = fs.ReadByte();
                rec_doctor = new byte[rec_length];

                fs.Read(rec_doctor, 0, rec_length);
                for (int i = 0; i < rec_length; i++)
                {
                    record_doctor += (char)rec_doctor[i];
                }
                field = record_doctor.Split('*');

                




                if (spec== field[2])
                {
                    Doc_name.Items.Add(field[1]);

                }

            }
            fs.Close();
        }
        private void nameChanged(object sender, System.EventArgs e)
        {

            FileStream fs = new FileStream("doctors.txt", FileMode.Open);


            DrId.Text = " ";


            string[] field;
            int rec_length;
            byte[] rec_doctor;
            string record_doctor = "";


            while (fs.Position != fs.Length)
            {
                record_doctor = "";
                rec_length = fs.ReadByte();
                rec_doctor = new byte[rec_length];

                fs.Read(rec_doctor, 0, rec_length);
                for (int i = 0; i < rec_length; i++)
                {
                    record_doctor += (char)rec_doctor[i];
                }
                field = record_doctor.Split('*');






                if (Doc_name.Text == field[1])
                {
                    DrId.Text = field[0];

                }

            }
            fs.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DrId_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_disease_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
