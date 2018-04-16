using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Web.Logic.Clases
{
    public class UsuarioClass
    {
        public string InsertUsuario(string strUsuario, string strPassword,
            string strPerfil , bool boolEstado,
            string strUsuarioIngresa, DateTime dtFechaIngreso)
        {
            try {
                using (Entidades.ComiteEticaEntities objComiteEticaEntities = new Entidades.ComiteEticaEntities())
                {
                    Entidades.Usuario objUsuario = new Entidades.Usuario
                    {
                        Usuario1= strUsuario,
                        Password=strPassword,
                        Perfil=strPerfil,
                        Estado=boolEstado,
                        UsuarioIngresa=strUsuarioIngresa,
                        FechaIngreso=dtFechaIngreso
                    };
                    objComiteEticaEntities.Usuario.Add(objUsuario);
                    objComiteEticaEntities.SaveChanges();
                }
            } catch( Exception e) {
            }

            return "";
        }

        public string UpdateUsuario(int intIdUsuario ,string strUsuario, string strPassword,
           string strPerfil, bool boolEstado,
           string strUsuarioModifica, DateTime dtFechaModificacion)
        {
            try
            {
                using (Entidades.ComiteEticaEntities objComiteEticaEntities = new Entidades.ComiteEticaEntities())
                {
                    Entidades.Usuario objUsuario = (from q in objComiteEticaEntities.Usuario
                                                    where q.IdUsuario == intIdUsuario
                                                    select q).First();

                    objUsuario.Usuario1 = strUsuario;
                    objUsuario.Password = strPassword;
                    objUsuario.Perfil = strPerfil;
                    objUsuario.Estado = boolEstado;
                    objUsuario.UsuarioModifica = strUsuarioModifica;
                    objUsuario.FechaModificacion = dtFechaModificacion;

                    objComiteEticaEntities.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }

            return "";
        }

        public string DeleteUsuario(int intIdUsuario)
        {
            try
            {
                using (Entidades.ComiteEticaEntities objComiteEticaEntities = new Entidades.ComiteEticaEntities())
                {
                    Entidades.Usuario objUsuario = (from q in objComiteEticaEntities.Usuario
                                                    where q.IdUsuario == intIdUsuario
                                                    select q).First();

                    objComiteEticaEntities.Usuario.Remove(objUsuario);
                    objComiteEticaEntities.SaveChanges();
                }
            }
            catch (Exception e)
            {
            }

            return "";
        }

        public List<Interfaces.UsuarioInterface> GetAllUsuario()
        {
            try
            {
                using (Entidades.ComiteEticaEntities obj= new Entidades.ComiteEticaEntities())
                {
                    List<Interfaces.UsuarioInterface> objUsuarioInterface = (from q in obj.Usuario
                                                                             select new Interfaces.UsuarioInterface {
                                                                                 IdUsuario=q.IdUsuario,
                                                                                 Usuario=q.Usuario1,
                                                                                 Password=q.Password,
                                                                                 Perfil=q.Perfil,
                                                                                 Estado=q.Estado,
                                                                                 UsuarioIngresa=q.UsuarioIngresa,
                                                                                 FechaIngreso=q.FechaIngreso,
                                                                                 UsuarioModifica=q.UsuarioModifica,
                                                                                 FechaModificacion=q.FechaModificacion
                                                                             }).ToList();
                    return objUsuarioInterface;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
