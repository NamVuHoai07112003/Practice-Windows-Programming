using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var db = new StudentDBEntities1();
            var select = from s in db.Students select s;
            String st = "";
            foreach (var item in select)
            {
                st = st + "ID: " + item.StudentID.ToString() + System.Environment.NewLine;
                st = st + "Name: " + item.StudentName.ToString() +
                System.Environment.NewLine;
                st = st + "Gender: " + item.StudentGender.ToString() +
                System.Environment.NewLine;
                st = st + "Address: " + item.Address.ToString() + System.Environment.NewLine;
            }
            this.textBox1.Text = st;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new StudentDBEntities1();
            Student aStudent;
            try
            {
                if (db.Students.Find(5) == null)
                {
                    aStudent = new Student();
                    aStudent.StudentID = 5;
                    aStudent.StudentName = "Nguyen Tri Dung";
                    aStudent.StudentGender = "Male";
                    aStudent.Address = " 11 Le Lai";
                    db.Students.Add(aStudent);
                    db.SaveChanges();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Not exist");
            }
            


            var select = from s in db.Students select s;
            String st = "";
            foreach (var item in select)
            {
                st = st + "ID: " + item.StudentID.ToString() + System.Environment.NewLine;
                st = st + "Name: " + item.StudentName.ToString() +
                System.Environment.NewLine;
                st = st + "Gender: " + item.StudentGender.ToString() +
                System.Environment.NewLine;
                st = st + "Address: " + item.Address.ToString() + System.Environment.NewLine;
            }
            this.textBox1.Text = st;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new StudentDBEntities1();
            Student aStudent;

            try
            {
                aStudent = db.Students.Where(d => d.StudentID == 5).First() as Student;
                aStudent.StudentName = "Nguyen Van Linh";
                db.SaveChanges();
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("Not exist");
            }

            var select = from s in db.Students select s;
            String st = "";
            foreach (var item in select)
            {
                st = st + "ID: " + item.StudentID.ToString() + System.Environment.NewLine;
                st = st + "Name: " + item.StudentName.ToString() +
                System.Environment.NewLine;
                st = st + "Gender: " + item.StudentGender.ToString() +
                System.Environment.NewLine;
                st = st + "Address: " + item.Address.ToString() + System.Environment.NewLine;
            }
            this.textBox1.Text = st;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new StudentDBEntities1();
            Student aStudent;

            try
            {
                aStudent = db.Students.Where(d => d.StudentID == 5).First() as Student;
                db.Students.Remove(aStudent);
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Not exist");
            }

            var select = from s in db.Students select s;
            String st = "";
            foreach (var item in select)
            {
                st = st + "ID: " + item.StudentID.ToString() + System.Environment.NewLine;
                st = st + "Name: " + item.StudentName.ToString() +
                System.Environment.NewLine;
                st = st + "Gender: " + item.StudentGender.ToString() +
                System.Environment.NewLine;
                st = st + "Address: " + item.Address.ToString() + System.Environment.NewLine;
            }
            this.textBox1.Text = st;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (StudentDBEntities1 db = new StudentDBEntities1())
            {
                Student aStudent;
                
                try
                {
                    // add
                    aStudent = new Student();
                    aStudent.StudentID = 5;
                    aStudent.StudentName = "Nguyen Tri Dung";
                    aStudent.StudentGender = "Male";
                    aStudent.Address = " 11 Le Lai";
                    db.Students.Add(aStudent);
                    // update
                    aStudent = db.Students.Where(d => d.StudentID == 3).First() as Student;
                    aStudent.StudentName = "Nguyen Van Linh";
                    //delete
                    aStudent = db.Students.Where(d => d.StudentID == 3).First() as Student;
                    db.Students.Remove(aStudent);
                    db.SaveChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Not exist");
                }
                


                var select = from s in db.Students select s;
                String st = "";
                foreach (var item in select)
                {
                    st = st + "ID: " + item.StudentID.ToString() + System.Environment.NewLine;
                    st = st + "Name: " + item.StudentName.ToString() +
                    System.Environment.NewLine;
                    st = st + "Gender: " + item.StudentGender.ToString() +
                    System.Environment.NewLine;
                    st = st + "Address: " + item.Address.ToString() + System.Environment.NewLine;
                }
                this.textBox1.Text = st;
            }
        }
    }
}
