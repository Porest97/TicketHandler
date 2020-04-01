using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketHandler.Models.DataModels
{
    public class Ticket
    {
        public int Id { get; set; }

        [Display(Name = "Ticket #")]
        public string TicketNumber { get; set; }

        //Incident
        public int? IncidentId { get; set; }
        [Display(Name = "INC #")]
        [ForeignKey("IncidentId")]
        public Incident Incident { get; set; }

        //WorkLogs

        public int? WorkLogId { get; set; }
        [Display(Name = "WL #1")]
        [ForeignKey("WorkLogId")]
        public WorkLog WL1 { get; set; }

        public int? WorkLogId1 { get; set; }
        [Display(Name = "WL #2")]
        [ForeignKey("WorkLogId1")]
        public WorkLog WL2 { get; set; }

        public int? WorkLogId2 { get; set; }
        [Display(Name = "WL #3")]
        [ForeignKey("WorkLogId2")]
        public WorkLog WL3 { get; set; }

        [Display(Name = "WorkLogs")]
        public string WorkLogs { get { return string.Format("{0} {1} {2} {3} {4}", WL1,",",WL2,",",WL3); } }





    }
}
