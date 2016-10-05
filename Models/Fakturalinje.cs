using System;
using System.ComponentModel;

namespace Shakespeare.Forms.Models
{
    public class Fakturalinje
    {
        private readonly int id;
        private readonly string navn;
        private readonly decimal stykpris;
        private readonly int antal;

        public Fakturalinje(int id, string navn, decimal stykpris, int antal)
        {
            if (navn == null)
            {
                throw new ArgumentNullException("navn");
            }

            if (string.IsNullOrWhiteSpace(navn))
            {
                throw new ArgumentException("Navn må ikke være tom.", "navn");
            }

            if (antal < 0)
            {
                throw new ArgumentOutOfRangeException("antal");
            }

            this.id = id;
            this.navn = navn;
            this.stykpris = stykpris;
            this.antal = antal;
        }

        [Browsable(false)]
        public int Id
        {
            get { return this.id; }
        }

        public string Navn
        {
            get { return this.navn; }
        }

        public decimal Stykpris
        {
            get { return this.stykpris; }
        }

        public int Antal
        {
            get { return this.antal; }
        }

        public decimal Subtotal
        {
            get { return Stykpris * Convert.ToDecimal(Antal); }
        }
    }
}