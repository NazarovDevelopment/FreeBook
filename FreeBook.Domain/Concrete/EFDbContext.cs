﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FreeBook.Domain.Entities;
using System.Data.Entity;

namespace FreeBook.Domain.Concrete
{
    public class EFDbContext : DbContext    {
        public DbSet<Book> Books { get; set; }
    }
}
