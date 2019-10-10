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

namespace DBO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AppuserServices _appuserServices = new AppuserServices();
       
        private void button1_Click(object sender, EventArgs e)
        {
            var result=_appuserServices.CheckUsernameAndPassword("admin", "asdf1234");
            if (result)
            {
                MessageBox.Show("Very Good!");
            }
        }
    }
}
