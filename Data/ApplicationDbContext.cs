using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketHandler.Models.DataModels;

namespace TicketHandler.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TicketHandler.Models.DataModels.Company> Company { get; set; }
        public DbSet<TicketHandler.Models.DataModels.Incident> Incident { get; set; }
        public DbSet<TicketHandler.Models.DataModels.IncidentPriority> IncidentPriority { get; set; }
        public DbSet<TicketHandler.Models.DataModels.IncidentStatus> IncidentStatus { get; set; }
        public DbSet<TicketHandler.Models.DataModels.IncidentType> IncidentType { get; set; }
        public DbSet<TicketHandler.Models.DataModels.Person> Person { get; set; }
        public DbSet<TicketHandler.Models.DataModels.PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<TicketHandler.Models.DataModels.Site> Site { get; set; }
        public DbSet<TicketHandler.Models.DataModels.Ticket> Ticket { get; set; }
        public DbSet<TicketHandler.Models.DataModels.WorkLog> WorkLog { get; set; }
        public DbSet<TicketHandler.Models.DataModels.WorkLogStatus> WorkLogStatus { get; set; }
    }
}
