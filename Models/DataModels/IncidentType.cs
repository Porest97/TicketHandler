using System.ComponentModel.DataAnnotations;

namespace TicketHandler.Models.DataModels
{
    public class IncidentType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string IncidentTypeName { get; set; }
    }
}