﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagementStocks.Core.Entities
{
    public class Stock
    {
        public Guid Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime OperationTime { get; set; }

        public Guid ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        public double Quantity { get; set; }

        public double Price { get; set; }

        public bool IsCredit { get; set; }
    }
}
