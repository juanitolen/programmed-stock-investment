namespace CompraProgramadaAcoes.Domain;

public class Asset
{
    public int Id { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public decimal Price { get; set; }
}