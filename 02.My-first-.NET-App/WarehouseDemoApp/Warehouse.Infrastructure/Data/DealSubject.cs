﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Infrastructure.Data
{
    public class DealSubject
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid DealId { get; set; }

        public Guid ItemId { get; set; }

        public int ItemCount { get; set; }

        [ForeignKey(nameof(DealId))]
        public Deal Deal { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }
    }
}