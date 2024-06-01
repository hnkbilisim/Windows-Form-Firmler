using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_Form_Calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFilmEkleForm_Click(object sender, EventArgs e)
        {
            EkleForm ekleForm = new EkleForm();
            ekleForm.ShowDialog();
        }

        private void btnTumFilmlerForm_Click(object sender, EventArgs e)
        {
            TumFilmlerForm tumFilmlerForm = new TumFilmlerForm();
            tumFilmlerForm.ShowDialog();
        }
    }
}
