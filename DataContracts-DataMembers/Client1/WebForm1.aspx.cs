using System;

namespace Client1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            int id = Convert.ToInt32(txtID.Text);
            EmployeeService.Employee employee = client.GetEmployee(id);
            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            if (employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                txtAnnualSalart.Text = ((EmployeeService.FullTimeEmployee)employee).AnnualSallary.ToString();
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                txtHourlyPay.Text = ((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();
                txtHoursWorked.Text = ((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHoursWorked.Visible = true;
                trHourlyPay.Visible = true;
            }

            ddIEmployeeType.SelectedValue = ((int)employee.Type).ToString();
            lblMessage.Text = "Employee retrieved";


        }

        protected void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = null;

            if (((EmployeeService.EmployeeType)Convert.ToInt32(ddIEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                employee = new EmployeeService.FullTimeEmployee
                {
                    ID = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = EmployeeService.EmployeeType.FullTimeEmployee,
                    AnnualSallary = Convert.ToInt32(txtAnnualSalart.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else if (((EmployeeService.EmployeeType)Convert.ToInt32(ddIEmployeeType.SelectedValue)) == EmployeeService.EmployeeType.PartTimeEmployee)
            {
                employee = new EmployeeService.PartTimeEmployee
                {
                    ID = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = EmployeeService.EmployeeType.PartTimeEmployee,
                    HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                    HoursWorked = Convert.ToInt32(txtHoursWorked.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else
            {
                lblMessage.Text = "Please select Employee Type";
            }


        }

        protected void ddIEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddIEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else if (ddIEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlyPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlyPay.Visible = true;
                trHoursWorked.Visible = true;
            }
        }
    }
}

