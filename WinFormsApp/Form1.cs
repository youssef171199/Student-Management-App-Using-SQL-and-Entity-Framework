using Microsoft.EntityFrameworkCore;
using System.Linq;
using WinFormsApp.Models;
 

namespace WinFormsApp
{
    public partial class add_label : Form
    {
        TestContext DB;
        public add_label()
        {
            DB = new TestContext();
            InitializeComponent();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TestContext DB = new TestContext();
            
            //List<Student> st = DB.Students.ToList();

            students_GV.DataSource = DB.Students.Include(n => n.Dept).Select(a => new { 
               ID=a.Id, Name = a.Name,age=a.Age ,address= a.Address , department = a.Dept.Name}
            ).ToList();
            comboBox1.DataSource = DB.Departments.ToList();
            comboBox1.DisplayMember= "Name";
            comboBox1.ValueMember = "Id";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var searchtxt = textBox1.Text;
            students_GV.DataSource = DB.Students.Include(n => n.Dept).Select(a => new {
                ID = a.Id,
                Name = a.Name,
                age = a.Age,
                address = a.Address,
                department = a.Dept.Name
            }
            ).Where(s => s.Name.Contains(searchtxt)).ToList();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            students_GV.DataSource = DB.Students.Include(n => n.Dept).Select(a => new {
                ID = a.Id,
                Name = a.Name,
                age = a.Age,
                address = a.Address,
                department = a.Dept.Name
            }
            ).ToList();
        }



        private void add_btn_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                Id = int.Parse(id_txt.Text),
                Name = name_txt.Text,
                Address = adress_txt.Text,
                Age = int.Parse(age_txt.Text),
                DeptId = (int?)comboBox1.SelectedValue,

            };
            DB.Students.Add(s);
            DB.SaveChanges();
            id_txt.Text = "";
            age_txt.Text = "";
            adress_txt.Text = "";
            name_txt.Text = "";
            label6.Text = "added succeffuly";
            students_GV.DataSource = DB.Students.Include(n => n.Dept).Select(a => new {
                ID = a.Id,
                Name = a.Name,
                age = a.Age,
                address = a.Address,
                department = a.Dept.Name
            }
            ).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
