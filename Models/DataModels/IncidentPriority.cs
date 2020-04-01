using System.ComponentModel.DataAnnotations;

namespace TicketHandler.Models.DataModels
{
    public class IncidentPriority
    {
        public int Id { get; set; }

        [Display(Name = "Prio.")]
        public string IncidentPriorityName { get; set; }
    }
}