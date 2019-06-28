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
    public partial class Form1 : Form
    {
        public class patient
        {
            public string pat_id;
            public string patient_NAME;
            public string disease;
            public string doctor_id;
            public string Appointment_date;
            public string doc_name;


            public void input_patient(Form1 frm1, Form3 frm3)
            {
                FileStream f = new FileStream("patient.txt", FileMode.Append);

                

                patient_NAME = frm3.patientName.Text;
                pat_id = frm3.PatientId.Text;
                disease = frm3.comboBox_disease.Text;
                doctor_id = frm3.DrId.Text;
                Appointment_date = frm3.dateTimePicker1.Text;


                string record_patient = pat_id + '@' + patient_NAME + '@' + disease + '@' + doctor_id + '@' + Appointment_date;
                int rec_length = record_patient.Length;

                byte[] rec_patient = new byte[rec_length];
                for (int i = 0; i < rec_length; i++)
                {
                    rec_patient[i] = (byte)record_patient[i];
                }
                f.WriteByte((byte)rec_length);
                f.Write(rec_patient, 0, rec_length);
                f.Close();
            }


            public void FindAllPatientstreated(Form1 frm)
            {

                FileStream fs = new FileStream("doctors.txt", FileMode.Open);
                

                string DrName = frm.DoctorBox.Text;

                string dr_id = "";
                string doctor_spec = "";
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

                    if (DrName == field[1])
                    {
                        dr_id = field[0];
                        doctor_spec = field[2];

                    }

                   
                }
                fs.Close();

                FileStream f = new FileStream("patient.txt", FileMode.Open);
                string[] fields;
                int record_patientlength;
                byte[] rec_patient;
                string record_patient = "";

                bool found = false;


                    DataTable table = new DataTable();
                    table.Columns.Add("Patient ID");
                    table.Columns.Add("Patient Name");
                    table.Columns.Add("Disease");
                    table.Columns.Add("Appointment Date");
                    table.Columns.Add("Doctor's speciality");

                while (f.Position != f.Length)
                {
                    record_patient = "";
                    record_patientlength = f.ReadByte();
                    rec_patient = new byte[record_patientlength];

                    f.Read(rec_patient, 0, record_patientlength);
                    for (int i = 0; i < record_patientlength; i++)
                    {
                        record_patient += (char)rec_patient[i];
                    }
                    fields = record_patient.Split('@');




                    if (dr_id == fields[3])
                    {
                        found = true;

                        DataRow dr = table.NewRow();
                        dr["Patient ID"] = fields[0];
                        dr["Patient Name"] = fields[1];
                        dr["Disease"] = fields[2];
                        dr["Doctor's speciality"] = doctor_spec;
                        dr["Appointment Date"] = fields[4];


                        table.Rows.Add(dr);
                        var bindingsource = new BindingSource();
                        bindingsource.DataSource = null;
                        frm.dataGridView1.Refresh();
                        bindingsource.DataSource = table;
                        frm.dataGridView1.DataSource = bindingsource;
                        bindingsource.ResetBindings(true);

                    }

                }
                if (found == false)
                    {
                    var bindingsource = new BindingSource();
                    bindingsource.DataSource = null;
                    frm.dataGridView1.DataSource = bindingsource;
                    frm.dataGridView1.Refresh();
                    

                }
                f.Close();
            }

            public void FindAllPatientsSuffer(Form1 frm)
            {
                FileStream f = new FileStream("patient.txt", FileMode.Open);
                
                string disease1 = frm.DiseaseBox.Text;

                string[] fields;
                int record_patientlength;
                byte[] rec_patient;
                string record_patient = "";


                DataTable table = new DataTable();
                table.Columns.Add("Patient ID");
                table.Columns.Add("Patient Name");
                table.Columns.Add("Appointment Date");
                table.Columns.Add("Doctor Name");

                while (f.Position != f.Length)
                {
                    record_patientlength = f.ReadByte();
                    rec_patient = new byte[record_patientlength];
                    record_patient = "";
                    f.Read(rec_patient, 0, record_patientlength);
                    for (int i = 0; i < record_patientlength; i++)
                    {
                        record_patient += (char)rec_patient[i];
                    }
                    fields = record_patient.Split('@');
                    pat_id = fields[0];
                    patient_NAME = fields[1];
                    disease = fields[2];
                    doctor_id = fields[3];

                    Appointment_date = fields[4];

                    FileStream fs = new FileStream("doctors.txt", FileMode.Open);


                   

                    string dr_id = "";
                    string doctor_spec = "";
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

                        if (doctor_id == field[0])
                        {
                             doc_name = field[1];

                        }


                    }
                    fs.Close();

                    if (disease1 == disease)
                    {
                        DataRow dr = table.NewRow();
                        dr["Patient ID"] = pat_id;
                        dr["Patient Name"] = patient_NAME;
                        dr["Appointment Date"] = Appointment_date;
                        dr["Doctor Name"] = doc_name;


                        table.Rows.Add(dr);
                        var bindingsource = new BindingSource();
                        bindingsource.DataSource= null;
                        frm.dataGridView1.Refresh();
                        bindingsource.DataSource = table;
                        frm.dataGridView1.DataSource = bindingsource;
                        bindingsource.ResetBindings(true);
                        
                    }
                   

                    


                }
                f.Close();

            }

        }
        public class doctor
        {
            public string Dr_ID;
            public string Dr_NAME;
            public string Dr_Specialty;

            public void input_doctor(Form1 frm1, Form2 frm2)
            {
                FileStream fs = new FileStream("doctors.txt", FileMode.Append);

                doctor d = new doctor();

                d.Dr_ID = frm2.Doc_ID.Text;
                d.Dr_NAME = frm2.Doc_Name.Text;
                d.Dr_Specialty = frm2.Speciality_Box.Text;



                string record_doctor = d.Dr_ID + '*' + d.Dr_NAME + '*' + d.Dr_Specialty;
                int rec_length = record_doctor.Length;

                byte[] rec_doctor = new byte[rec_length];
                for (int i = 0; i < rec_length; i++)
                {
                    rec_doctor[i] = (byte)record_doctor[i];
                }
                fs.WriteByte((byte)rec_length);
                fs.Write(rec_doctor, 0, rec_length);
                fs.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
            {
                this.DoctorBox.Click +=
            new System.EventHandler(read);


                {
                    FileStream f = new FileStream("patient.txt", FileMode.Open);


                    string[] fields;
                    int record_patientlength;
                    byte[] rec_patient;
                    string record_patient = "";


                    List<string> coursesList = new List<string>();

                    while (f.Position != f.Length)
                    {
                        record_patient = "";
                        record_patientlength = f.ReadByte();
                        rec_patient = new byte[record_patientlength];
                        record_patient = "";
                        f.Read(rec_patient, 0, record_patientlength);
                        for (int i = 0; i < record_patientlength; i++)
                        {
                            record_patient += (char)rec_patient[i];
                        }
                        fields = record_patient.Split('@');

                        coursesList.Add(fields[2]);

                    }
                    coursesList = coursesList.Distinct().ToList();

                    for (int i = 0; i < coursesList.Count; i++)
                    {

                        DiseaseBox.Items.Add(coursesList[i]);


                    }
                    f.Close();
                }
            }
        }

            
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            patient PAT = new patient();
            
            PAT.FindAllPatientstreated(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            patient PAT = new patient();
            
            PAT.FindAllPatientsSuffer(this);
        }
        private void read(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("doctors.txt", FileMode.Open);

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

                DoctorBox.Items.Add(field[1]);

            }
            fs.Close();
        }
    }
}
