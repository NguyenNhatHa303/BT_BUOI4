using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BUOI4
{
    public partial class Form2 : Form
    {
        private Form1 _form1; // Tham chiếu đến Form1
        private Employee _employee; // Nhân viên cần sửa (nếu có)
        public Form2(Form1 form1, Employee employee = null)
        {
            InitializeComponent();
            _form1 = form1;
            _employee = employee;

            if (_employee != null)
            {
                // Hiển thị thông tin nhân viên nếu đang sửa
                txtIDForm2.Text = _employee.Id;
                txtNameForm2.Text = _employee.Name;
                txtSalaryForm2.Text = _employee.Salary.ToString();
                txtIDForm2.Enabled = false; // Không cho phép sửa MSNV
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (_employee == null) // Trường hợp thêm mới
            {
                Employee newEmployee = new Employee
                {
                    Id = txtIDForm2.Text,
                    Name = txtNameForm2.Text,
                    Salary = double.Parse(txtSalaryForm2.Text)
                };

                _form1.employees.Add(newEmployee); // Thêm vào danh sách
            }
            else // Trường hợp sửa
            {
                _employee.Name = txtNameForm2.Text;
                _employee.Salary = double.Parse(txtSalaryForm2.Text);
            }

            _form1.RefreshGridView(); // Làm mới DataGridView
            this.Close(); // Đóng Form2
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form2 mà không làm gì
        }
    }
}
