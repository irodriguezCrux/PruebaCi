using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Facturas
    {
            [Required()]
            [Key()]
            public int idFactura { get; set; }
            public string  numFactura { get; set; }

            public Facturas() { }
            public Facturas(int id, string num) { idFactura = id; numFactura = num; }
    }
    public class DetFacturas
    {
        public int idLineaPedido { get; set; }
        public int idFacturaPed { get; set; }
        public int total { get; set; }

        public DetFacturas() { }
        public DetFacturas(int id, int idFac ,int num) { idLineaPedido = id; idFacturaPed = idFac; total = num; }
    }
}
