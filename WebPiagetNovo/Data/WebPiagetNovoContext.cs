using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPiagetNovo.Models;

namespace WebPiagetNovo.Data
{
    public class WebPiagetNovoContext : DbContext
    {
        public WebPiagetNovoContext (DbContextOptions<WebPiagetNovoContext> options)
            : base(options)
        {
        }

        public DbSet<WebPiagetNovo.Models.Aluno> Aluno { get; set; } = default!;
    }
}
