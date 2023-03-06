using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using webapi.Models;

namespace WebUI.Context
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<TB_CADASTRO> TB_CADASTRO { get; set; }
    }
}
