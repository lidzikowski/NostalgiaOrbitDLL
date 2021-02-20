using System.Collections.Generic;

namespace NostalgiaOrbitDLL
{
    public abstract class ShopItem
    {
        // Credits
        public bool CanBuyByCredit { get; protected set; }
        public List<int> CreditPurchase { get; protected set; }

        public bool CanSellByCredit { get; protected set; }
        public List<int> CreditSale { get; protected set; }

        // Uridium
        public bool CanBuyUridium { get; protected set; }
        public List<int> UridiumPurchase { get; protected set; }

        public bool CanSellUridium { get; protected set; }
        public List<int> UridiumSale { get; protected set; }

        // Auction
        public bool CanBuyOnAuctionHouse { get; protected set; }
    }
}