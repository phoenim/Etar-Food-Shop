using Etar.Domain.Entities.Addresses;

namespace Etar.Domain.Entities.Users
{
    public class User : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
