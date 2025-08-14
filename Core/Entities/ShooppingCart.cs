using System;

namespace Core.Entities;

public class ShooppingCart
{
    public required string Id { get; set; }
    public List<CartItem> Items { get; set; } = [];
}
