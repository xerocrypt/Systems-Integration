using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hl7.Fhir;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

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

        private void cmdCreatePatient_Click(object sender, EventArgs e)
        {
            // Code for creating a patient here.
            // Patientidentifier variables
            var MyPatient = new Hl7.Fhir.Model.Patient();
            
            var PatientName = new Hl7.Fhir.Model.HumanName();
            PatientName.Use = Hl7.Fhir.Model.HumanName.NameUse.Official;

            string patientFirstName = txtFirstName.Text;
            string patientSurname = txtSurname.Text;
            string patientTitle = cmbPatientTitle.Text;
            string patientNumber = txtPatientNum.Text;

            
            PatientName.Prefix = new string[] { patientTitle };
            PatientName.Given = new string[] { patientFirstName };
            PatientName.Family = new string[] { patientSurname };

            MyPatient.Name = new List<Hl7.Fhir.Model.HumanName>();
            MyPatient.Name.Add(PatientName);

            // Institution patient identifiers
            var PatientIdentifier = new Hl7.Fhir.Model.Identifier();
            PatientIdentifier.System = "https://medical-test.net";
            PatientIdentifier.Value = patientNumber;
            MyPatient.Identifier = new List<Hl7.Fhir.Model.Identifier>();
            MyPatient.Identifier.Add(PatientIdentifier);
            
            string xml = Hl7.Fhir.Serialization.FhirSerializer.SerializeResourceToXml(MyPatient);
            XDocument xDoc = XDocument.Parse(xml);
            txtOutput.Text = xDoc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            dlgOpenFile.DefaultExt = "xml";



            //XmlReader xmlread = XmlReader.Create(new StreamReader(@"sample-patient.xml"));
            //var extractFirstName = (Patient)FhirParser.ParseResource(xmlread);

            DataSet xmlPatient = new DataSet();
            txtOutput.Text = xmlPatient.ReadXml(@"sample-patient.xml").ToString();
            
        }
    }
}
