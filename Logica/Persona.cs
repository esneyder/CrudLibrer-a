using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using databaseConnection;
using System.Data;
namespace Logica
{
    public class Persona
    {
     DbConnection db = new DbConnection("parametros.xml");
        
        public static string mensaje;
        public  string Mensaje {
            get { return mensaje; }
            
            
        }
        public string cedula{ get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string genero { get; set; }
        public string ciudad { get; set; }
        public string direccion { get; set; }
        public string telefono{ get; set; }
        
        public int NuevaPresona(Persona pers)
        {
            string[] parametros = { "@operacion",
                                    "@cedula",
                                  "@nombres",
                                  "@apellidos",
                                  "@genero",
                                  "@ciudad",
                                  "@direccion",
                                  "@telefono"};
            if (!db.OpenConnection())
            {
                db.CloseConnection();
                mensaje = db.Error;
                return 0;
            }
            else { 
                if(db.ExecuteProcedures("spPersonaIA", parametros, "I", pers.cedula, pers.nombre, pers.apellido, 
               pers.genero, pers.ciudad, pers.direccion, pers.telefono)>0)
              mensaje = "Registro ingresado correctamente";
              db.CloseConnection();
              return 1;          
              
                 
            }

        }

        public int ActualizarPersona(Persona pers)
        {
            
            string[] parametros = { "@operacion",
                                    "@cedula",
                                  "@nombres",
                                  "@apellidos",
                                  "@genero",
                                  "@ciudad",
                                  "@direccion",
                                  "@telefono"};
            if (!db.OpenConnection())
            {
                mensaje = db.Error;
                db.CloseConnection();
                return 0;
            }
            else
            {
                if(db.ExecuteProcedures("spPersonaIA", parametros,
                      "A", pers.cedula, pers.nombre, pers.apellido,
                      pers.genero, pers.ciudad, pers.direccion, pers.telefono)>0)
                mensaje = "Registro actualizado";
                db.CloseConnection();
                return 1;
            }

        }

        public DataTable ListadoPersonas() {
          
            if (!db.OpenConnection())
            {
                mensaje = db.Error;
                db.CloseConnection();
                return null;
            }
            else
            {
                string[] parametros = { "@operacion", "@cedula" };
                return db.GetData("spPersonaSE", parametros, "T", 0);
            }
        }

        public int EliminarPesona(string cedula)
        {
            string[] parametros = { "@operacion", "@cedula" };
            
            if (!db.OpenConnection())
            {
                mensaje = db.Error;
                db.CloseConnection();
                return 0;
            }
            else if (db.ExecuteProcedures("spPersonaSE", parametros, "E", cedula)>0)
            {
                mensaje = "Registro eliminado";
                db.CloseConnection();                  
                 
            }
                return 1;
        }

        public Persona getPersona(string cedula)
        {
            
             
            DataTable dt = new DataTable();
            Persona p = new Persona();
            string[] parametros = { "@operacion", "@cedula" };
            dt = db.GetData("spPersonaSE", parametros, "S", cedula);   
            foreach (DataRow fila in dt.Rows)
            {
                p.cedula = fila["cedula"].ToString();
                p.nombre = fila["nombres"].ToString();
                p.apellido = fila["apellidos"].ToString();
                p.genero = fila["genero"].ToString();
                p.ciudad = fila["ciudad"].ToString();
                p.direccion = fila["direccion"].ToString();
                p.telefono=fila["telefono"].ToString();
                mensaje = "Registros encontrados";

            }
            return p;


        }

    }
}
