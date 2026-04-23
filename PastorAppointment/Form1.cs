using System;
using System.Windows.Forms;

namespace PastorAppointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionnel : valeur par défaut pour la date
            dtpDateAppointment.Value = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Récupération des données
            string pastorName = txtPastorName.Text;
            string location = txtLocation.Text;
            string reason = txtReason.Text;
            string additionalInfo = txtAdditionalInfo.Text;
            DateTime appointmentDate = dtpDateAppointment.Value;

            // Vérification simple
            if (pastorName == "" || location == "" || reason == "")
            {
                MessageBox.Show("Please fill all required fields.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Affichage du résumé
            string message = "Appointment Submitted!\n\n" +
                             "Pastor Name: " + pastorName + "\n" +
                             "Location: " + location + "\n" +
                             "Reason: " + reason + "\n" +
                             "Additional Info: " + additionalInfo + "\n" +
                             "Date: " + appointmentDate.ToShortDateString();

            MessageBox.Show(message, "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Nettoyer les champs après envoi
            txtPastorName.Clear();
            txtLocation.Clear();
            txtReason.Clear();
            txtAdditionalInfo.Clear();
            dtpDateAppointment.Value = DateTime.Now;
        }
    }
}