﻿namespace HotCatCafe.Common.CartHelpers
{
    public class CartItem
    {
        //sepetin ne özellikleri olacaksa o tanımlanacak

        public CartItem()
        {
            Quantity = 1;
        }

        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public decimal SubTotal 
        { 
            get
            {
                return Quantity * UnitPrice;
            }
        }

    }
}
