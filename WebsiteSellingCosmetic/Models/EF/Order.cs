﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebsiteSellingCosmetic.Models.EF
{
    [Table("Order")]
    public class Order : CommonAbstract
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required(ErrorMessage = "Tên khách hàng không được để trống!")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Email không được để trống!")]
        public string Email { get; set; }
        public int TotalAmount { get; set; }
        public int Quantity { get; set; }
        public int TypePayment { get; set; }
        public string CustomerId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get;}
    }
}