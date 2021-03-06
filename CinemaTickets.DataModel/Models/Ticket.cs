﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets.DataModel.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public decimal? Price { get; set; }
        public Employee Employee { get; set; }
        public int? EmployeeID { get; set; }
        public Projection Projection { get; set; }
        public int ProjectionID { get; set; }
        public int? SeatID { get; set; }
        public virtual Seat Seat { get; set; }
        public bool IsSold { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}
