using Shakespeare.Forms.Models;
using Shakespeare.Forms.Views;

namespace Shakespeare.Forms
{
    public interface IViewFactory
    {
        BehandlingForm SkabBehandlingForm(Patient patient);
        BehandlingForm SkabBehandlingForm(Patient patient, Ophold ophold);
        FakturaForm SkabFakturaForm();
        JournalForm SkabJournalForm(Patient patient);
        PatientForm SkabPatientForm();
        PersonaleoplysningerForm SkabPersonaleoplysningerForm();
        FindTidligereOpholdForm SkabIndlæsFakturaForm(Patient patient);
    }
}