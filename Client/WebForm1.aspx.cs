using System;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getEmployee(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new
                EmployeeService.EmployeeServiceClient();

            EmployeeService.Employee employee = client.GetEmployee(Convert.ToInt32(txtId.Text));
            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            Label4.Text = "Employee retrieved";
        }

        protected void saveEmployee(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = new EmployeeService.Employee();
            employee.Id = Convert.ToInt32(txtId.Text);
            employee.Name = txtName.Text;
            employee.Gender = txtGender.Text;
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);
            client.SaveEmployee(employee);
        }
    }
}