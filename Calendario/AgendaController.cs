﻿using System;
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


        public static List<AgendaRegistro> ExtraerRegistrosAgendaMensual (int idUsuario, DateTime mes)
        {
            using (var db = new syspolizaEntities())
            {
                return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.fechaHoraInicio.Month == mes.Month).ToList();
            }
        }

    }
}