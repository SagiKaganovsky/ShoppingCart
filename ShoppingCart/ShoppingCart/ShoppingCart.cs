namespace ShoppingCart.ShoppingCart
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EventFeed;

    public class ShoppingCart
  {
    private HashSet<ShoppingCartItem> items = new HashSet<ShoppingCartItem>();

    public int UserId { get; }
    public IEnumerable<ShoppingCartItem> Items { get { return items; } }

    public ShoppingCart(int userId)
    {
      this.UserId = userId;
    }

    public void AddItems(
      IEnumerable<ShoppingCartItem> shoppingCartItems,
      IEventStore eventStore)
    {
      foreach (var item in shoppingCartItems)
        if (this.items.Add(item))
          eventStore.Raise(
            "ShoppingCartItemAdded",
            new { UserId, item });
    }

    public void RemoveItems(
      int[] productCatalogueIds,
      IEventStore eventStore)
    {
      items.RemoveWhere(i => productCatalogueIds.Contains(i.ProductCatalogueId));
    }
  }
}
