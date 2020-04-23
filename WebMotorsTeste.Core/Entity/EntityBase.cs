namespace WebMotorsTeste.Core.Entity
{
    public class EntityBase : Entity
    {
        public EntityBase Clone()
        {
            return (EntityBase)MemberwiseClone();
        }
    }
}
