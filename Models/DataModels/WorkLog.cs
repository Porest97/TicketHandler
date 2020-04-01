using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketHandler.Models.DataModels
{
    public class WorkLog
    {
        public int Id { get; set; }

        [Display(Name = "WL #")]
        public string WLNumber { get; set; }

        [Display(Name = "Type")]
        public string Type { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        //DateTime !
        [Display(Name = "Date Time Started")]
        public DateTime DateTimeFrom { get; set; }

        [Display(Name = "Date Time Compleated")]
        public DateTime DateTimeTo { get; set; }

        //Bus. unit, Company, Site !
        [Display(Name = "Bus. unit")]
        public string BusUnit { get; set; }

        //Incident
        public int? IncidentId { get; set; }
        [Display(Name = "INC #")]
        [ForeignKey("IncidentId")]
        public Incident Incident { get; set; }

        //Subject
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        //Accounting !
        [Display(Name = "FE Enters Site")]
        public DateTime FEEntersSite { get; set; }

        [Display(Name = "FE Exits Site")]
        public DateTime FEEExitsSite { get; set; }

        [Display(Name = "Total hours")]
        public decimal TotalHours { get; set; }

        // WorkLog Status !
        public int? WorkLogStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("WorkLogStatusId")]
        public WorkLogStatus WorkLogStatus { get; set; }
    }
}
