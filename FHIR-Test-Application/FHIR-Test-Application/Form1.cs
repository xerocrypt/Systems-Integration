using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;

namespace FHIR_Test_Application
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            var endpoint = new Uri("http://test.fhir.org/r3");
            var Client = new FhirClient(endpoint);

            var patientFirstName = txtFirstName.Text;
            var searchTerm = "name=" + patientFirstName;

            var query = new string[] { "" + searchTerm + "" };
            var bundle = Client.Search("Patient", query);

            txtOutput.Text = "Fetched " + bundle.Entry.Count() + " patient records." + "\r\n";

            foreach (var entry in bundle.Entry)
            {
                Patient p = (Patient)entry.Resource;
                txtOutput.Text = txtOutput.Text + p.Id + " " + p.Name + "\r\n";
            }
     
        } 
    }
}
