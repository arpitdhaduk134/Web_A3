using System;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public string PurchaseHistory { get; set; } // Assuming purchase history is stored as JSON or serialized string
    public string ShippingAddress { get; set; }
}
