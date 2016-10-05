using System.Collections.Generic;
using System.IO;
using PdfSharp.Pdf;
using Shakespeare.Forms.Models;
using Shakespeare.Forms.Models.Kataloger;

namespace Shakespeare.Forms.Controllers
{
    public class FakturaController
    {
        private readonly IBehandlingKatalog behandlinger;
        private readonly IOpholdKatalog ophold;

        public FakturaController(IBehandlingKatalog behandlinger, IOpholdKatalog ophold)
        {
            this.behandlinger = behandlinger;
            this.ophold = ophold;
        }

        public PdfDocument GenererPdfDokument(Patient patient, Ophold ophold)
        {
            IList<Behandlingslinje> behandlingslinjer = HentBehandlingslinjerForOphold(ophold);
            return new Faktura(patient, ophold, behandlingslinjer).GenererPdfDokument();
        }

        public void GemFaktura(PdfDocument faktura, Stream stream)
        {
            using (faktura)
            using (stream)
            {
                faktura.Save(stream);
            }
        }

        public IList<Behandlingslinje> HentBehandlingslinjerForOphold(Ophold ophold)
        {
            return this.behandlinger.HentBehandlingslinjerForOphold(ophold.Id);
        }

        public void SletOphold(Ophold opholdId)
        {
            ophold.SletOphold(opholdId);
        }
    }
}