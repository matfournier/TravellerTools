
namespace Grauenwolf.TravellerTools.TradeCalculator
{
    /// <summary>
    /// A bid is the desire to sell a trade good [to the players].
    /// </summary>
    public class TradeOffer
    {
        public decimal BasePrice { get; set; }
        public decimal CurrentPrice => BasePrice * PriceModifier;
        public decimal PriceModifier { get; set; }
        public int PurchaseDM { get; set; }
        public int Roll { get; internal set; }
        public string Subtype { get; set; }
        public int Tons { get; set; }
        public string Type { get; set; }
    }
}