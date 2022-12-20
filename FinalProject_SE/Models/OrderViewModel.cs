using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject_SE.Models
{
    public class OrderViewModel
    {
        [Required(ErrorMessage = "Customer Name can not be blank")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Phone number can not be blank")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address can not be blank")]
        public string Address { get; set; }
        public string Email { get; set; }
        public int TypePayment { get; set; }

        //public int Quantity { get; set; }
    }
}