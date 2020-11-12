using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MainMusicStore.Models.DbModels
{
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public DateTime ShippingDate { get; set; }

        [Required]
        public double OrderTotal { get; set; }

        public string TrackingNumber { get; set; } //siparis no

        public string Carrier { get; set; } //tasıyıcı bilgisi

        public string OrderStatus { get; set; } //ürün siparis durumu

        public string PaymentStatus { get; set; } //ödeme tipi

        public DateTime PaymentDate { get; set; }

        public DateTime PaymentDueDate { get; set; } //ürünün son ödeme tarihi

        public string TransactionId { get; set; } 

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
