using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Shakespeare.Forms.Models.Kataloger;

namespace Shakespeare.Forms
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Sæt system til dansk.
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("da-DK");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("da-DK");

            // Åben en forbindelse, så databasen ikke er langsom.
            IDbConnectionFactory connectionFactory = new SqlConnectionFactory();
            
            using (connectionFactory.Åbn())
            {

            }

            IViewFactory viewFactory = new ViewFactory(connectionFactory);

            using (var form = viewFactory.SkabFakturaForm())
            {
                Application.Run(form);
            }
        }
    }
}