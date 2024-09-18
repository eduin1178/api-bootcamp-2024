﻿namespace Api.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public int CategoryId { get; set; }
    }
}
