using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Shakespeare.Forms.Models
{
    public class Faktura
    {
        private readonly Patient patient;
        private readonly Ophold ophold;
        private readonly IList<Behandlingslinje> behandlingslinjer;

        public Faktura(Patient patient, Ophold ophold, IList<Behandlingslinje> behandlingslinjer)
        {
            this.patient = patient;
            this.ophold = ophold;
            this.behandlingslinjer = behandlingslinjer;
        }

        public PdfDocument GenererPdfDokument()
        {
            const int sideMargin = 24;
            const int topMargin = 32;

            var normalFont = new XFont("Century", 12);
            var document = new PdfDocument();
            PdfPage page = document.AddPage();

            using (XGraphics gfx = XGraphics.FromPdfPage(page))
            {
                // Logo.
                string logoPath = Path.Combine(Environment.CurrentDirectory, "Resources", "Logo.v2.png");
                XImage logo = XImage.FromFile(logoPath);
                double width = page.Width / 3;
                double aspectRatio = logo.PixelHeight / (double) logo.PixelWidth;
                gfx.DrawImage(logo,
                    new XRect(page.Width * 2 / 3 - sideMargin, topMargin, page.Width / 3, width * aspectRatio));

                // Patientoplysninger.
                var top = topMargin + page.Height * 0.05;
                const int lineHeight = 15;
                gfx.DrawString(patient.Cpr.Insert(6, "-"), normalFont, XBrushes.Black, new XPoint(sideMargin, top));
                gfx.DrawString(patient.Fornavn + " " + patient.Efternavn, normalFont, XBrushes.Black,
                    new XPoint(sideMargin, top + lineHeight));
                gfx.DrawString(patient.Adresse, normalFont, XBrushes.Black, new XPoint(sideMargin, top + lineHeight * 2));
                gfx.DrawString(patient.Postnr + " " + patient.By, normalFont, XBrushes.Black,
                    new XPoint(sideMargin, top + lineHeight * 3));
                gfx.DrawString(patient.Tlf, normalFont, XBrushes.Black, new XPoint(sideMargin, top + lineHeight * 4));

                // Servicelinjer.
                top = top + page.Height * 0.125;

                // Kolonne-headers.
                const int beskrivelseBredde = 200;
                const int stykprisBredde = 150;
                const int antalBredde = 100;
                gfx.DrawString("Beskrivelse", normalFont, XBrushes.Black, sideMargin, top);
                gfx.DrawString("Stykpris", normalFont, XBrushes.Black, sideMargin + beskrivelseBredde, top);
                gfx.DrawString("Antal", normalFont, XBrushes.Black, sideMargin + beskrivelseBredde + stykprisBredde, top);
                gfx.DrawString("Subtotal", normalFont, XBrushes.Black,
                    sideMargin + beskrivelseBredde + stykprisBredde + antalBredde, top);
                top = top + 5;
                gfx.DrawLine(new XPen(XColors.Black, 0.25), sideMargin, top, page.Width - sideMargin, top);
                top = top + lineHeight;

                TimeSpan opholdTidsrum = (ophold.Slut - ophold.Start);
                var totalDays = (int) opholdTidsrum.TotalDays;
                decimal subtotalSum = 0;


                // Forplejning.
                {
                    double x = sideMargin;

                    // Beskrivelse.
                    gfx.DrawString(ophold.Forplejning.Navn, normalFont, XBrushes.Black, x, top);
                    x = x + beskrivelseBredde;

                    // Stykpris.
                    string stykpris = ophold.Forplejning.Pris.ToString("C2");
                    gfx.DrawString(stykpris, normalFont, XBrushes.Black, x, top);
                    x = x + stykprisBredde;

                    // Antal.
                    string antal = totalDays.ToString("F0") + " dag(e)";
                    gfx.DrawString(antal, normalFont, XBrushes.Black, x, top);
                    x = x + antalBredde;

                    // Subtotal.
                    decimal subtotal = Convert.ToDecimal(totalDays) * ophold.Forplejning.Pris;
                    subtotalSum += subtotal;
                    gfx.DrawString(subtotal.ToString("C2"), normalFont, XBrushes.Black, x, top);

                    top = top + lineHeight;
                }

                // Værelse.
                {
                    double x = sideMargin;

                    // Beskrivelse.
                    gfx.DrawString(ophold.Værelse.Navn, normalFont, XBrushes.Black, x, top);
                    x = x + beskrivelseBredde;

                    // Stykpris.
                    string stykpris = ophold.Værelse.Pris.ToString("C2");
                    gfx.DrawString(stykpris, normalFont, XBrushes.Black, x, top);
                    x = x + stykprisBredde;

                    // Antal.
                    string antal = totalDays.ToString("F0") + " dag(e)";
                    gfx.DrawString(antal, normalFont, XBrushes.Black, x, top);
                    x = x + antalBredde;

                    // Subtotal.
                    decimal subtotal = Convert.ToDecimal(totalDays) * ophold.Værelse.Pris;
                    subtotalSum += subtotal;
                    gfx.DrawString(subtotal.ToString("C2"), normalFont, XBrushes.Black, x, top);

                    top = top + lineHeight;
                }

                foreach (var behandlingslinje in this.behandlingslinjer)
                {
                    double x = sideMargin;

                    // Beskrivelse.
                    gfx.DrawString(behandlingslinje.Behandling.Navn, normalFont, XBrushes.Black, x, top);
                    x = x + beskrivelseBredde;

                    // Stykpris.
                    string stykpris = behandlingslinje.Behandling.Pris.ToString("C2");
                    gfx.DrawString(stykpris, normalFont, XBrushes.Black, x, top);
                    x = x + stykprisBredde;

                    // Antal.
                    string antal = behandlingslinje.Antal + " stk";
                    gfx.DrawString(antal, normalFont, XBrushes.Black, x, top);
                    x = x + antalBredde;

                    // Subtotal.
                    decimal subtotal = behandlingslinje.Subtotal;
                    subtotalSum += subtotal;
                    gfx.DrawString(subtotal.ToString("C2"), normalFont, XBrushes.Black, x, top);

                    top = top + lineHeight;
                }

                gfx.DrawLine(new XPen(XColors.Black, 0.25), sideMargin, top, page.Width - sideMargin, top);
                top = top + lineHeight;

                // Subtotal.
                double rightAligned = page.Width * 0.725;
                gfx.DrawString("Subtotal: " + subtotalSum.ToString("C2"), normalFont, XBrushes.Black, rightAligned, top);
                top = top + lineHeight;

                // Moms.
                decimal moms = subtotalSum * 0.25m;
                gfx.DrawString("Moms: " + moms.ToString("C2"), normalFont, XBrushes.Black, rightAligned, top);
                top = top + lineHeight;

                // Total.
                decimal total = subtotalSum + moms;
                gfx.DrawString("Total: " + total.ToString("C2"), normalFont, XBrushes.Black, rightAligned, top);

                return document;
            }
        }
    }
}