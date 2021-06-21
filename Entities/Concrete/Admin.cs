using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // Varlık sınıfı
    public class Admin : IEntity
    {
        public int Id { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }

    }
}
