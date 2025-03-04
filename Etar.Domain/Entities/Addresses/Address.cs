using Etar.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etar.Domain.Entities.Addresses
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        public string City { get; set; }
        public long PostalCode { get; set; }
        public int  Tag {  get; set; }
        public string Describtion {  get; set; }

        public virtual User User { get; set; }
        public Guid UserId { get; set; }
    }
}
