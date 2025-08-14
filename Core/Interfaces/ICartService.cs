using System;
using Core.Entities;

namespace Core.Interfaces;

public interface ICartService
{
    Task<ShooppingCart?> GetCartAsync(string key);
    Task<ShooppingCart?> SetCartAsync(ShooppingCart cart);
    Task<bool> DeleteCartAsync(string key);
}
