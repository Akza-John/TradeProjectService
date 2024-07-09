using System;
using System.ComponentModel.DataAnnotations;

namespace TradeProjectService.Models
{
    public class MeetingDetail
    {
        [Key]
        public int MeetingId { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Participants { get; set; }
    }

}
