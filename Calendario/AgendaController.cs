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

        public static void EliminarRegistro(int idRegistro)
        {
            using (var db = new syspolizaEntities())
            {
                try
                {
                    db.AgendaRegistro.Remove(db.AgendaRegistro.Find(idRegistro));
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
                  
            }
        }

        public static List<AgendaRegistro> ExtraerRegistrosAgendaMensual (int idUsuario, DateTime mes, bool recordatorio, bool tarea)
        {
            using (var db = new syspolizaEntities())
            {
             
                if(recordatorio && !tarea)
                {
                    return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.tipoRegistro == 1 && r.fechaHoraInicio.Year == mes.Year && r.fechaHoraInicio.Month == mes.Month).OrderBy(r => r.tipoRegistro).ToList();

                }
                else if (tarea && !recordatorio)
                {
                    return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.tipoRegistro == 2 && r.fechaHoraInicio.Year == mes.Year && r.fechaHoraInicio.Month == mes.Month).OrderBy(r => r.tipoRegistro).ToList();

                }
                else
                {
                    return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.fechaHoraInicio.Year == mes.Year && r.fechaHoraInicio.Month == mes.Month).OrderBy(r => r.tipoRegistro).ToList();

                }

            }
        }

        public static List<AgendaRegistro> ExtraerRegistrosAgendaDiaria(int idUsuario, DateTime dia, bool recordatorio, bool tarea)
        {
            using (var db = new syspolizaEntities())
            {
                if(recordatorio && !tarea)
                {
                    return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.tipoRegistro == 1 && r.fechaHoraInicio.Year == dia.Year && r.fechaHoraInicio.Month == dia.Month && r.fechaHoraInicio.Day == dia.Day)
                    .OrderBy(r => r.tipoRegistro).ThenBy(r => r.fechaHoraInicio).ToList();

                }else if(tarea && !recordatorio)
                {
                    return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.tipoRegistro == 2 && r.fechaHoraInicio.Year == dia.Year && r.fechaHoraInicio.Month == dia.Month && r.fechaHoraInicio.Day == dia.Day)
                   .OrderBy(r => r.tipoRegistro).ThenBy(r => r.fechaHoraInicio).ToList();
                }
                else
                {
                    return db.AgendaRegistro.Where(r => r.idUsuario == idUsuario && r.fechaHoraInicio.Year == dia.Year && r.fechaHoraInicio.Month == dia.Month && r.fechaHoraInicio.Day == dia.Day)
                   .OrderBy(r => r.tipoRegistro).ThenBy(r => r.fechaHoraInicio).ToList();
                }
                
            }
        }


    }
}
