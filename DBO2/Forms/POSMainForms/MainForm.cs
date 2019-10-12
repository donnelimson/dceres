using Infrastructure.Services;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBO2.Forms.POSMainForms
{
    public partial class MainForm : FormProperties
    {
        public MainForm()
        {
           
            InitializeComponent();
        }
        //services
        DepartmentServices _departmentService = new DepartmentServices();
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            var departmentList = _departmentService.GetAllDepartment();
            int top = 50;
            int left = 100;
            foreach(var item in departmentList)
            {
                Button departmentButton = new Button();
                departmentButton.Left = left;
                departmentButton.Top = top;
                departmentButton.Name = item.DepartmentId.ToString();
                departmentButton.Text = item.DepartmentDescription;
                DepartmentPanel.Controls.Add(departmentButton);
                top += departmentButton.Height + 2;
            }
        }

    }
}
