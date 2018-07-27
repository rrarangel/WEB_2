﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        
    }
}