using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Entity;
using DataModel;
using BussinesEntity;
using System.ComponentModel;

namespace BussinesLayer
{
    public class AlumnoBL
    {
        //public List<BussinesEntity.AlumnoBL> listarAlumnos()
        public BindingList<AlumnoDto> listarAlumnos()
        {
            try
            {
                using (PersonaDBEntities dbContext = new PersonaDBEntities())
                {
                    List<BussinesEntity.AlumnoDto> Query = (from n in dbContext.Alumno
                                             select new BussinesEntity.AlumnoDto
                                             {
                                                 i_IdPersona = n.i_IdPersona,
                                                 v_Direccion = n.v_Direccion,
                                                 v_DNI = n.v_DNI,
                                                 v_NombresApellidos = n.v_NombresApellidos,
                                                 v_Telefono = n.v_Telefono,
                                                 t_FechaNacimiento = n.t_FechaNacimiento
                                             }).ToList();
                    BindingList<AlumnoDto> result = new BindingList<AlumnoDto>(Query);
                        return result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public void actualizarAlumno (ref operationResult _objOperationResult , List<AlumnoDto> tempInsertar, List<AlumnoDto> tempModificar, List<AlumnoDto> tempEliminar)
        {
            try
            {
                using (PersonaDBEntities dbContext = new PersonaDBEntities())
                {
                    #region Insertar
                    foreach (AlumnoDto _alumno in tempInsertar)
                    {
                        Alumno Entidad = new Alumno();

                        Entidad.v_NombresApellidos = _alumno.v_NombresApellidos;
                        Entidad.v_DNI = _alumno.v_DNI;
                        Entidad.v_Telefono = _alumno.v_Telefono;
                        Entidad.t_FechaNacimiento = _alumno.t_FechaNacimiento;
                        dbContext.Alumno.Add(Entidad);
                    }
                    #endregion

                    #region Modificar
                    foreach (AlumnoDto _alumno in tempModificar)
                    {
                        Alumno Entidad = (from n in dbContext.Alumno
                                          where n.i_IdPersona == _alumno.i_IdPersona
                                          select n).FirstOrDefault();

                        Entidad.v_NombresApellidos = _alumno.v_NombresApellidos;
                        Entidad.v_DNI = _alumno.v_DNI;
                        Entidad.v_Telefono = _alumno.v_Telefono;
                        Entidad.t_FechaNacimiento = _alumno.t_FechaNacimiento;
                        dbContext.Alumno.Add(Entidad);
                    }
                    #endregion

                    #region Eliminar
                    foreach (AlumnoDto _alumno in tempEliminar)
                    {
                        Alumno Entidad = (from n in dbContext.Alumno
                                          where n.i_IdPersona == _alumno.i_IdPersona
                                          select n).FirstOrDefault();
                        dbContext.Alumno.Remove(Entidad);
                    }

                    #endregion

                    dbContext.SaveChanges();
                    _objOperationResult.succes = 1;
                }
            }
            catch (Exception ex)
            {
                _objOperationResult.succes = 0;
                _objOperationResult.errorMessage = ex.Message;
                _objOperationResult.innerException = ex.InnerException != null ? ex.InnerException.Message : string.Empty;
                _objOperationResult.AdditionInformation = "AlumnoBL.actualizarAlumno()";
                return;
            }
        }

    }
}
