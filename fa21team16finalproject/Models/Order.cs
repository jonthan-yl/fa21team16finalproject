using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace fa21team16finalproject.Models
{
    
    public class Order
    {
        //Primary Key
        [Display(Name = "Order ID:")]
        [Required(ErrorMessage = "Order ID is required")]
        public Int32 OrderID { get; set; }

        [Display(Name = "Confirmation Number:")]
        [Required(ErrorMessage = "Confirmation Number is required")]
        public Int32 ConfirmationNumber { get; set; }

        [Display(Name = "Order Date:")]
        [Required(ErrorMessage = "Order Date is required")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Order Subtotal")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderSubtotal
        {
            get { return Reservations.Sum(Reservation => Reservation.DiscountedSubtotal); }
        }

        [Display(Name = "Sales Tax (810%)")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal SalesTax
        {
            get { return OrderSubtotal * TAX_RATE; }
        }

        [Display(Name = "Order Total")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public Decimal OrderTotal
        {
            get { return OrderSubtotal + SalesTax; }
        }

        public const Decimal TAX_RATE = 0.1m;

        [Display(Name = "Confirmed:")]
        public bool isComplete { get; set; }

        public Status Status { get; set; }

        //Navigational Property
        //Assigned upon creation of reservation
        public List<Reservation> Reservations { get; set; }

        //Declared in creation of order
        public AppUser AppUser { get; set; }

        public Order()
        {
            if (Reservations == null)
            {
                Reservations = new List<Reservation>();
            }
            if (isComplete != true)
            {
                isComplete = false;
            }
        }

    }
}