using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeBook.Domain.Entities
{
    public class Book
    {
        public ulong ISBN { get; set; }
        public string Name { get; set; }
    }
}
