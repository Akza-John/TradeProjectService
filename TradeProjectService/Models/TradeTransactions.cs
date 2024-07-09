﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TradeProjectService.Models
{
    public class TradeTransactions
    {
        public int TransId { get; set; }
        public string TradeStage { get; set; }
       
        public string StageName { get; set; }
        public string Status { get; set; }
        public int Cost { get; set; }

    }
}