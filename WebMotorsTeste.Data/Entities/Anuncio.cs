using System.ComponentModel.DataAnnotations.Schema;
using WebMotorsTeste.Core.Entity;

namespace WebMotorsTeste.Data.Entities
{
    [Table("tb_AnuncioWebmotors")]
    public class Anuncio: EntityBase
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string versao { get; set; }
        public int ano { get; set; }
        public int quilometragem { get; set; }
        public string observacao { get; set; }
    }
}
