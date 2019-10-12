using Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using DBO2.PopupForms;
using DBO2.Forms.POSMainForms;
using System.Threading;
using Models.PublicClass;

namespace DBO2
{
    public partial class LoginForm : FormProperties
    {
        public LoginForm()
        {
            InitializeComponent();
            UsernameTextbox.TabIndex = 0;
            PasswordTextbox.TabIndex = 1;
        }
        #region services
        AppuserServices _appuserServices = new AppuserServices();
        #endregion
        #region forms
        ErrorPopup errorPopup = new ErrorPopup();
        MainForm mainForm = new MainForm();
        #endregion

        private void ClearAll()
        {
            this.UsernameTextbox.Clear();
            this.PasswordTextbox.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoginButton_Click_1(object sender, EventArgs e)
        {
            var result = _appuserServices.CheckUsernameAndPassword(UsernameTextbox.Text, PasswordTextbox.Text);
            if (result!=null)
            {
                AppUserStatic.AppUserId = result.AppUserId;
                AppUserStatic.FullName = result.FullName;
                this.Hide();
                mainForm.Show();
            }
            else
            {
                errorPopup.ErrorLabel.Text = "Wrong username or password!";
                DarkenForm(errorPopup);
                ClearAll();
            }
        }
    }
}
