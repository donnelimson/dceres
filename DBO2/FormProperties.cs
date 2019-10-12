using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBO2
{
    public class FormProperties : MetroForm
    {

        public FormProperties()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            Movable = false;
            Resizable = false;
        }
        protected void DarkenForm(Form form)
        {
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                double percent = 0.60;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, this.ClientRectangle);
                }
                using (Panel p = new Panel())
                {
                    p.Location = new Point(0, 0);
                    p.Size = this.ClientRectangle.Size;
                    p.BackgroundImage = bmp;
                    this.Controls.Add(p);
                    p.BringToFront();
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.ShowDialog();
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormProperties
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Name = "FormProperties";
            this.Load += new System.EventHandler(this.FormProperties_Load);
            this.ResumeLayout(false);

        }

        private void FormProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
