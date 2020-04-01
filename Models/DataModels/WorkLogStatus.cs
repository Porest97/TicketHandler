using System.ComponentModel.DataAnnotations;

namespace TicketHandler.Models.DataModels
{
    public class WorkLogStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string WorkLogStatusName { get; set; }
    }
}