using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Data_Entity_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProrigoEntities dbcontext =new ProrigoEntities();
        private void button1_Save_Click(object sender, EventArgs e)
        {
           
            
           
                // 1.Create object of Emp and store data from application
                Employee emp = new Employee();
                emp.EmpName = textBox2_Name.Text;
                emp.EmpSalary = Convert.ToDecimal(textBox3_Salary.Text);
                //2.Add Data to The Data Context
                dbcontext.Employees.Add(emp);
                //3.update the changes to the DB
                dbcontext.SaveChanges();
                MessageBox.Show("Done");
          /*  }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); } */          
            
        }

        private void button3_Search_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(textBox1_ID.Text));
                if(emp !=null)
                {
                    textBox2_Name.Text = emp.EmpName;
                    textBox3_Salary.Text=emp.EmpSalary.ToString();
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(textBox1_ID.Text));
                if(emp!=null)
                {
                    emp.EmpName = textBox2_Name.Text;
                    emp.EmpSalary = Convert.ToDecimal(textBox3_Salary.Text);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Updated");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbcontext.Employees.Find(Convert.ToInt32(textBox1_ID.Text));
                if (emp != null)
                {
                    dbcontext.Employees.Remove(emp);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Deleted");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_showAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.Employees.ToList();

        }
    }
}
