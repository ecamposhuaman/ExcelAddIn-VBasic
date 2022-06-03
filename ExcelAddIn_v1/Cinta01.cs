using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace ExcelAddIn_v1
{
    public partial class Cinta01
    {
        private void Cinta01_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnGuardarED_Click(object sender, RibbonControlEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }

        private void btnPrecioMC_Click(object sender, RibbonControlEventArgs e)
        {
            FormPMC frm2 = new FormPMC();
            frm2.Show();
        }
    }
}
