using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque
{
    [Table("saidaproduto", Schema = "public")]
    public class DtoSaidaProduto
    {
            [Key]
            public int id { get; set; }
            public int idproduto { get; set; }
            public decimal qteproduto { get; set; }
            public decimal? vlrunitario { get; set; }
            public decimal? vlrtotal { get; set; }
            public DateTime? dtentrada { get; set; }
        }
}
