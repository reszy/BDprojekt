using System;
using System.Linq;
using System.Windows.Forms;

using BusinessLayer;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataLayer.User user = new DataLayer.User
            {
                PersonId = 4,
                FirstName = "Atam",
                LastName = "Fnuk",
                DateRetire = DateTime.Now,
                Uname = "uncle",
                Password = "4347d0f8ba661234a8eadc005e2e1d1b646c9682",
                Role = "Admin"
            };

            //AdministrationFacade.UpdateUserData(user);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());  //new LoginScreen());
        }
    }
}
