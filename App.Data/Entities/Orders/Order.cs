using App.Data.DomainEntity;
using App.Data.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities.Orders
{
    [Table("Ordes")]
    public class Order : EntityBase<Guid>
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Message { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Guid? CustomerId { get; set; }
    }
}