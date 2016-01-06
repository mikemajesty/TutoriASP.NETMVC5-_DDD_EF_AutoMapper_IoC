using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModel.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Nome { get; set; }
        public decimal Value { get; set; }
        public bool Available { get; set; }       
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
    }
}
