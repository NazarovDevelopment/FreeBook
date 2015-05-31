using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FreeBook.Domain.Abstract;
using FreeBook.Domain.Concrete;
using FreeBook.Domain.Entities;

namespace FreeBook.Domain.Abstract
{
    class EFBookRepository:IBooksRepository
    {
        private EFDbContext context = new EFDbContext(); 
        public IEnumerable<Book> Books { get; }


    }
}
