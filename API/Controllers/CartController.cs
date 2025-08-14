using System;
using Core.Entities;
using Core.Interfaces;
using Infrastucture.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CartController(ICartService cartService) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<ShooppingCart>> getCartById(string id)
    {
        var cart = await cartService.GetCartAsync(id);

        return Ok(cart ?? new ShooppingCart { Id = id });
    }

    [HttpPost]
    public async Task<ActionResult<ShooppingCart>> UpdateCart(ShooppingCart cart)
    {
        var updatedCart = await cartService.SetCartAsync(cart);

        if (updatedCart == null) return BadRequest("Problem with cart");

        return updatedCart;
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteCart(string id)
    {
        var result = await cartService.DeleteCartAsync(id);
        if (!result) return BadRequest("Problem with the cart");

        return Ok();
    }
}
