using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public interface IAgregar {
        public void InsertarUsuario(Usuario user);
        }
    public class Usuario
    {
        //atributos
    }

    public class AgregarUsuario 
    {
        IAgregar agregar;

        public AgregarUsuario(IAgregar _agregar) 
        {
            this.agregar = _agregar;
        }

        public void InsertarUsuario(Usuario user) 
        {
            agregar.InsertarUsuario(user);
        }
    }
}
