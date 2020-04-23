using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMotorsTeste.Core.Entity
{
    public abstract class Entity : IEquatable<Entity>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public bool Equals(Entity other)
        {
            if (other == null) return false;

            if (other.ID == 0) return false;

            if (other.ID.Equals(default(Guid)) && ID.Equals(default(Guid)))
                return ReferenceEquals(this, other);

            // Verifica se as entidades são do mesmo tipo e tem o mesmo ID. Nesse caso são iguais
            return (GetType() == other.GetType() && ID.Equals(other.ID));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Entity);
        }

        public override int GetHashCode()
        {
            if (ID == 0)
                return 0;
            else
                return ID.GetHashCode();
        }
    }
}
