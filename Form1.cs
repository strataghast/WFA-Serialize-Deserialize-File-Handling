using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Assignment_10_2
{
    public partial class Form1 : Form
    {
        Student stud;
        const string binary = @"C:\Users\brett\OneDrive\Desktop\Programming\MSSA\20483C\Module 6\Assignment 10-2\EMS Files\StudentData-Binary.txt";
        const string xml = @"C:\Users\brett\OneDrive\Desktop\Programming\MSSA\20483C\Module 6\Assignment 10-2\EMS Files\StudentData-XML.txt";
        const string json = @"C:\Users\brett\OneDrive\Desktop\Programming\MSSA\20483C\Module 6\Assignment 10-2\EMS Files\StudentData-JSON.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpSerialize.Enabled = false;
            grpDeSerialize.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stud = new Student();
            stud.studentID = Convert.ToInt32(txtStudentID.Text);
            stud.studentName = txtName.Text;
            stud.studentAddress = txtAddress.Text;
            stud.studentMarks = float.Parse(txtMarks.Text);
            stud.studentGrade = txtGrade.Text;
            grpSerialize.Enabled = true;
            MessageBox.Show("Student added successfully.");
        }

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(binary, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, stud);
            fs.Close();
            MessageBox.Show("Student data serialized successfully in binary format.");
            grpDeSerialize.Enabled = true;
        }

        private void btnBinDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(binary, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            var stud = (Student)bf.Deserialize(fs);
            rtxtData.Text = "Student ID: " + stud.studentID + "\nStudent Name: " + stud.studentName + "\nStudent Address: " + stud.studentAddress + "\nStudent Marks: " + stud.studentMarks + "\nStudent Grade: " + stud.studentGrade;
        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(xml, FileMode.OpenOrCreate, FileAccess.Write);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, stud);
            fs.Close();
            MessageBox.Show("Student data serialized successfully in XML format.");
            grpDeSerialize.Enabled = true;
        }

        private void btnXMLDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(xml, FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();
            var stud = (Student)sf.Deserialize(fs);
            rtxtData.Text = "Student ID: " + stud.studentID + "\nStudent Name: " + stud.studentName + "\nStudent Address: " + stud.studentAddress + "\nStudent Marks: " + stud.studentMarks + "\nStudent Grade: " + stud.studentGrade;
        }

        private void btnJSONSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(json, FileMode.OpenOrCreate, FileAccess.Write);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Student));
            js.WriteObject(fs, stud);
            fs.Close();
            MessageBox.Show("Student data serialized successfully in JSON format.");
            grpDeSerialize.Enabled = true;
        }

        private void btnJSONDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(json, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Student));
            var stud = (Student)js.ReadObject(fs);
            rtxtData.Text = "Student ID: " + stud.studentID + "\nStudent Name: " + stud.studentName + "\nStudent Address: " + stud.studentAddress + "\nStudent Marks: " + stud.studentMarks + "\nStudent Grade: " + stud.studentGrade;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rtxtData.Clear();
            txtStudentID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtMarks.Clear();
            txtGrade.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "C:\\Users\\brett\\OneDrive\\Desktop\\Programming\\MSSA\\20483C\\Module 6\\Assignment 10-2\\EMS Files");
        }
    }
}
