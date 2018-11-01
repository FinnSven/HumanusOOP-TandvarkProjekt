using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TandVark.Data.Data1
{
    public class TandVerkContext : DbContext
    {

        public TandVerkContext()
        {
        }

        public TandVerkContext(DbContextOptions<TandVerkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblUser> TblPatient { get; set; }
        public virtual DbSet<TblUserType> TblUserTypes { get; set; }

    }
        
}
