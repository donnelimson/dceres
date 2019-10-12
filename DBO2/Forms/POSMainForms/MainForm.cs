using Infrastructure.Services;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Models.PublicClass;
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
            AppUserFullNameLabel.Text = AppUserStatic.FullName;
            DepartmentPanel.WrapContents = true;
            var departmentList = _departmentService.GetAllDepartment();
            int left = 0;
            foreach(var item in departmentList)
            {
                MetroTile departmentButton = new MetroTile();
                departmentButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
                departmentButton.Left = left;
                departmentButton.Height = 50;
                departmentButton.Width = 100;
                departmentButton.Name = item.DepartmentId.ToString();
                departmentButton.Text = item.DepartmentDescription;
                departmentButton.TextAlign = ContentAlignment.MiddleCenter;
                DepartmentPanel.Controls.Add(departmentButton);
                left += 120;
            }
        }
        private void DateTimeTick()
        {
            DateTimeLabel.Text = DateTime.Now.ToString();
        }

        private void MainFormTimer_Tick(object sender, EventArgs e)
        {
            DateTimeTick();
        }

    }
}
