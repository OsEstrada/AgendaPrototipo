using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public static class AgendaController
    {
        public static void GuardarRegistroAgenda(AgendaRegistro registro)
        {
            using (var db = new syspolizaEntities())
            {
                try
                {
                    db.AgendaRegistro.AddOrUpdate(registro);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
        }
    }
}
