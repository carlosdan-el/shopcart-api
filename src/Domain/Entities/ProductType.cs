using System;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class ProductType: IDatabaseEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProductCategoryId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}