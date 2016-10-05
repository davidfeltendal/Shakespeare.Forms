using System;
using System.Linq;
using Shakespeare.Forms.Models;
using Shakespeare.Forms.Models.Kataloger;

namespace Shakespeare.Forms.Controllers
{
    public class PatientController
    {
        private readonly IPatientLæser patientLæser;
        private readonly IPatientSkriver patientSkriver;

        public PatientController(IPatientLæser patientLæser, IPatientSkriver patientSkriver)
        {
            if (patientLæser == null)
            {
                throw new ArgumentNullException("patientLæser");
            }

            if (patientSkriver == null)
            {
                throw new ArgumentNullException("patientSkriver");
            }

            this.patientLæser = patientLæser;
            this.patientSkriver = patientSkriver;
        }

        public Patient HentPatient(string cpr)
        {
            if (cpr == null)
            {
                throw new ArgumentNullException("cpr");
            }

            if (cpr.Length != 10)
            {
                throw new ArgumentException("CPR skal være på 10 karakterer.", "cpr");
            }

            if (cpr.All(Char.IsDigit) == false)
            {
                throw new ArgumentException("CPR må kun bestå af tal.", "cpr");
            }

            return this.patientLæser.HentPatient(cpr);
        }

        public void GemPatient(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException("patient");
            }

            this.patientSkriver.GemPatient(patient);
        }

        public bool ErGyldigCpr(string cpr)
        {
            if (cpr == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(cpr))
            {
                return false;
            }

            cpr = cpr.Replace(" ", "").Replace("-", "");
            return cpr.Length == 10 && cpr.All(Char.IsDigit);
        }
    }
}