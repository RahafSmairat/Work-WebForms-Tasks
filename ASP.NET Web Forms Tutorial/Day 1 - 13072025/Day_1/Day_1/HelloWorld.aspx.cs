using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_1
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello " + showMessage.Text + "!");
        }

        protected void showMessage_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ShowRange_Click(object sender, EventArgs e)
        {
            int startNumber = Convert.ToInt32(startNumberTextBox.Text);
            int endNumber = Convert.ToInt32(endNumberTextBox.Text);

            for (int i = startNumber; i <= endNumber; i++)
            {
                Response.Write(i + " ");
            }
        }

        protected void endNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void saveBtn_Click(object sender, EventArgs e)
        {
            //name = nameTextBox.Text;
            //result.Text = "Name Was Saved Successfully!";

            ViewState["Name"] = nameTextBox.Text;
            result.Text = "Name Was Saved Successfully!";
        }

        protected void showBtn_Click(object sender, EventArgs e)
        {
            result.Text = ViewState["Name"].ToString();
            nameTextBox.Text = "";
        }

        protected void addStudentBtn_Click(object sender, EventArgs e)
        {
            if (ViewState["studentName"] == null)
            {
                List<string> students = new List<string>();
                students.Add(studentNameTextBox.Text);
                ViewState["studentName"] = students;

                successMsg.Text = $"{studentNameTextBox.Text} was added successfully!";
                studentNameTextBox.Text = "";

                ViewState["studentsCount"] = students.Count.ToString();
                studentsCount.Text = ViewState["studentsCount"].ToString();
            }
            else 
            {
                List<string> students = (List<string>)ViewState["studentName"];
                students.Add(studentNameTextBox.Text);
                successMsg.Text = $"{studentNameTextBox.Text} was added successfully!";
                studentNameTextBox.Text = "";

                ViewState["studentsCount"] = students.Count.ToString();
                studentsCount.Text = ViewState["studentsCount"].ToString();
            }
        }

        protected void showStudentsBtn_Click(object sender, EventArgs e)
        {
            studentsListBox.Items.Clear();
            successMsg.Text = "";

            List<string> students = (List<string>)ViewState["studentName"];

            //studentsCount.Text = students.Count.ToString();

            foreach (string student in students) 
            { 
                studentsListBox.Items.Add(student);
            }
        }

        protected void saveStudentBtn_Click(object sender, EventArgs e)
        {
            //Student s = new Student();

            //s.name = sNameTextBox.Text;
            //s.age = sAgeTextBox.Text;
            //s.email = sEmailTextBox.Text;

            //ViewState["Student"] = s;

            //successMsg2.Text = "Student Was Saved Successfully!";
            //sNameTextBox.Text = "";
            //sAgeTextBox.Text = "";
            //sEmailTextBox.Text = "";

            if (ViewState["Students"] ==  null)
            {
                List<Student> students = new List<Student>();

                Student student = new Student();
                student.name =sNameTextBox.Text;
                student.age = sAgeTextBox.Text;
                student.email = sEmailTextBox.Text;

                students.Add(student);
                ViewState["Students"] = students;

            }
            else
            {
                List<Student> students = (List<Student>)ViewState["Students"];

                Student student = new Student();
                student.name = sNameTextBox.Text;
                student.age = sAgeTextBox.Text;
                student.email = sEmailTextBox.Text;

                students.Add(student);
            }

            successMsg2.Text = "Student Was Saved Successfully!";
            sNameTextBox.Text = "";
            sAgeTextBox.Text = "";
            sEmailTextBox.Text = "";
        }

        protected void showStudentBtn_Click(object sender, EventArgs e)
        {
            //Student s = (Student)ViewState["Student"];

            //sName.Text = s.name;
            //sAge.Text = s.age;
            //sEmail.Text = s.email;

            successMsg2.Text = "";
            studentsListBox1.Items.Clear();

            List<Student> students = (List<Student>)ViewState["Students"];

            foreach (Student student in students)
            {
                studentsListBox1.Items.Add($"** {student.name}, {student.age}, {student.email}");
            }
        }

        protected void saveSalaryBtn_Click(object sender, EventArgs e)
        {
            Salary s = new Salary();

            s.basic = Convert.ToDouble(basicTextBox.Text);
            s.rentPerc = Convert.ToDouble(rentTextBox.Text);
            s.medicalPerc = Convert.ToDouble(medTextBox.Text);

            ViewState["Salary"] = s;
        }

        protected void showSalaryBtn_Click(object sender, EventArgs e)
        {
            Salary s = (Salary)ViewState["Salary"];

            salary.Text = s.CalculateSalary().ToString();
        }

        protected void createRegNo_Click(object sender, EventArgs e)
        {
            Vechile v  = new Vechile();
            v.name = vNameTextBox.Text;
            v.regNo = regNoTextBox.Text;

            v.speedList = new List<double>();

            ViewState["Vichele"] = v;

        }

        protected void enter_Click(object sender, EventArgs e)
        {
            double speed = Convert.ToDouble(speedTextBox.Text); 
            Vechile v = (Vechile)ViewState["Vichele"];

            v.speedList.Add(speed);
        }

        protected void showV_Click(object sender, EventArgs e)
        {
            Vechile v = (Vechile)ViewState["Vichele"];
            minSpeedTextBox.Text = v.getMin().ToString();
            maxSpeedTextBox.Text = v.getMax().ToString();
            AvgTextBox.Text = v.getAvg().ToString();
        }

        protected void saveToSession_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
        }

        protected void go_Click(object sender, EventArgs e)
        {
            Response.Redirect("AnotherPage.aspx");
        }

        protected void saveUserBtn_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            p.name = TextBox2.Text;
            p.email = TextBox3.Text;
            p.number = TextBox4.Text;

            Session["Person"] = p;
        }
    }
}