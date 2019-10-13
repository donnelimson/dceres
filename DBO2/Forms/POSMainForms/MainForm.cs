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
        MasterItemServices _masterItemService = new MasterItemServices();
        private void MainForm_Load(object sender, EventArgs e)
        {
            AppUserFullNameLabel.Text = AppUserStatic.FullName;
            DepartmentPanel.WrapContents = true;
            MasterItemPanel.WrapContents = true;
            var departmentList = _departmentService.GetAllDepartment();
            int left = 0;
            foreach(var item in departmentList)
            {
                MetroTile departmentButton = new MetroTile();
                departmentButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
                departmentButton.Left = left;
                departmentButton.Height = 50;
                departmentButton.Width = 100;
                departmentButton.Click += DepartmentClick;
                departmentButton.Name = item.DepartmentId.ToString();
                departmentButton.Text = item.DepartmentDescription;
                departmentButton.TextAlign = ContentAlignment.MiddleCenter;
                DepartmentPanel.Controls.Add(departmentButton);
                left += 120;
            }
        }
       private void DepartmentClick(object sender,EventArgs e)
        {
            var button = (Button)sender;
            MasterItemPanel.Controls.Clear();
            var masterItemList = _masterItemService.GetAllMasterItemPerDepartment(int.Parse(button.Name));
            int left = 0;
            foreach (var item in masterItemList)
            {
                MetroTile masteritemButton = new MetroTile();
                masteritemButton.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
                masteritemButton.Left = left;
                masteritemButton.Height = 50;
                masteritemButton.Width = 100;
           //     masteritemButton.Click += DepartmentClick;
                masteritemButton.Name = item.MasterItemId.ToString();
                masteritemButton.Text = item.LongDescription;
                masteritemButton.TextAlign = ContentAlignment.MiddleCenter;
                MasterItemPanel.Controls.Add(masteritemButton);
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
