using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeBook.Domain.Entities;

namespace FreeBook.Domain.Abstract
{
    public interface IBooksRepository
    {
        IEnumerable<Book> Books { get; }
    }
}
