using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciocoiu_Cristian_Lab6.Models;

namespace Ciocoiu_Cristian_Lab6.Data
{
    public class Ciocoiu_Cristian_Lab6Context : DbContext
    {
        public Ciocoiu_Cristian_Lab6Context (DbContextOptions<Ciocoiu_Cristian_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Ciocoiu_Cristian_Lab6.Models.Book> Book { get; set; }
    }
}
