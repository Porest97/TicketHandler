using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketHandler.Models.DataModels;

namespace TicketHandler.Models.ViewModels
{
    public class DataViewModel
    {
        public List<Company> Companies { get; internal set; }

        public List<Incident> Incidents { get; internal set; }

        public List<IncidentPriority> IncidentPriorities { get; internal set; }

        public List<IncidentStatus> IncidentStatuses { get; internal set; }

        public List<IncidentType> IncidentTypes { get; internal set; }

        public List<Person> People { get; internal set; }

        public List<PurchaseOrder> PurchaseOrders { get; internal set; }

        public List<Site> Sites { get; internal set; }

        public List<SiteRole> SiteRoles { get; internal set; }

        public List<SiteType> SiteTypes { get; internal set; }
    }
}
