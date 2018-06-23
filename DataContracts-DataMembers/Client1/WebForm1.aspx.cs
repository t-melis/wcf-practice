using System;

namespace Client1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new
                EmployeeService.EmployeeServiceClient();

            int id = int.Parse(TextBox1.Text);
            EmployeeService.Employee employee = client.GetEmployee(id);

            if (employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                TextBox5.Text = ((EmployeeService.FullTimeEmployee)employee).AnnualSallary.ToString();
                Label8.Visible = false;
                TextBox6.Visible = false;
                Label9.Visible = false;
                TextBox7.Visible = false;
            }
            else
            {
                TextBox6.Text = ((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();
                TextBox7.Text = ((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();
                TextBox5.Visible = false;
                Label7.Visible = false;
            }

            ddIEmployeeType.SelectedValue = ((int)employee.Type).ToString();
            TextBox1.Text = employee.ID.ToString();
            TextBox2.Text = employee.Name;
            TextBox3.Text = employee.Gender;
            TextBox4.Text = employee.DateOfBirth.ToShortDateString();

            Label5.Text = "Employee retrieved";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = null;

            if (((EmployeeService.EmployeeType)Convert.ToInt32(ddIEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                employee = new EmployeeService.FullTimeEmployee
                {
                    AnnualSallary = Convert.ToInt32(TextBox5.Text),
                    ID = Convert.ToInt32(TextBox1.Text),
                    Name = TextBox2.Text,
                    Gender = TextBox3.Text,
                    DateOfBirth = Convert.ToDateTime(TextBox4.Text),
                    Type = EmployeeService.EmployeeType.FullTimeEmployee
                };
            }
            else
            {
                employee = new EmployeeService.PartTimeEmployee
                {
                    ID = Convert.ToInt32(TextBox1.Text),
                    Name = TextBox2.Text,
                    Gender = TextBox3.Text,
                    DateOfBirth = Convert.ToDateTime(TextBox4.Text),
                    Type = EmployeeService.EmployeeType.PartTimeEmployee,
                    HourlyPay = Convert.ToInt32(TextBox6.Text),
                    HoursWorked = Convert.ToInt32(TextBox7.Text)
                };
            }

            client.SaveEmployee(employee);
            Label5.Text = "Employee Saved";
        }

        protected void ddIEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddIEmployeeType.SelectedValue == "-1")
            {
                Label7.Visible = false;
                Label8.Visible = false;
                Label9.Visible = false;
                TextBox5.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
            }
            else if (ddIEmployeeType.SelectedValue == "1")
            {
                Label8.Visible = false;
                Label9.Visible = false;
                TextBox6.Visible = false;
                TextBox7.Visible = false;
            }
            else
            {
                Label7.Visible = false;
                TextBox5.Visible = false;
            }
        }
    }
}