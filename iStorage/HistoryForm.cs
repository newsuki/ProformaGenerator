using com.itextpdf.text.pdf;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iStorage
{
    public partial class HistoryForm : Form
    {
        private MainForm mainForm;
        private Database db;

        public HistoryForm()
        {
            InitializeComponent();

            mainForm = (MainForm)Application.OpenForms["MainForm"];
            db = new Database();
        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            db.Open();

            db.LoadData(listBoxHistory, "proforma_invoices");

            db.Close();
        }
    }
}
