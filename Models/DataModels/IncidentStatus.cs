using System.ComponentModel.DataAnnotations;

namespace TicketHandler.Models.DataModels
{
    public class IncidentStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string IncidentStatusName { get; set; }
    }
}