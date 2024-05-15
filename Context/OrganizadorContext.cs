using Microsoft.EntityFrameworkCore;
using Sistema_Agendamento_EntityFramework.Models;

namespace Sistema_Agendamento_EntityFramework.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
    
}