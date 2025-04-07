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
        private List<(List<string> listBoxData, string richTextBox1Data, string richTextBox2Data)> history;
        private MainForm mainForm;

        public HistoryForm(List<(List<string>, string, string)> historyData)
        {
            InitializeComponent();
            history = historyData;

            foreach (var entry in history)
            {
                listBoxHistory.Items.Add(entry.richTextBox1Data);
            }

            mainForm = (MainForm)Application.OpenForms["MainForm"];
        }

        private void listBoxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedIndex != -1)
            {
                var selectedHistory = history[listBoxHistory.SelectedIndex];

                mainForm.LoadHistoryData(selectedHistory.listBoxData, selectedHistory.richTextBox1Data, selectedHistory.richTextBox2Data);

                this.Close();
            }
        }
    }
}
