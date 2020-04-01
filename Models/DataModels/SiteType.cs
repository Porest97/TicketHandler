using System.ComponentModel.DataAnnotations;

namespace TicketHandler.Models.DataModels
{
    public class SiteType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string SiteTypeName { get; set; }
    }
}