using CompraProgramadaAcoes.Data;
using CompraProgramadaAcoes.Domain;

namespace CompraProgramadaAcoes.Services;

public class PurchaseService
{
    private readonly AppDbContext _context;

    public PurchaseService(AppDbContext context)
    {
        _context = context;
    }

    public void ExecutePurchase(decimal totalAmount)
    {
        var assets = _context.Assets.Take(5).ToList();

        if (assets.Count == 0) return;

        decimal amountPerAsset = totalAmount / assets.Count;

        foreach (var asset in assets)
        {
            if (asset.Price <= 0) continue;

            int quantity = (int)(amountPerAsset / asset.Price);

            if (quantity <= 0) continue;

            var order = new Order
            {
                Ticker = asset.Ticker,
                Quantity = quantity,
                Price = asset.Price
            };

            _context.Orders.Add(order);
        }

        _context.SaveChanges();
    }
}