using System.Collections.Generic;

namespace NostalgiaOrbitDLL
{
    public abstract class ShopItem
    {
        public ItemShopTypes ItemShopType { get; set; }

        // Credits
        public bool CanBuyByCredit { get; protected set; }
        public List<float> CreditPurchase { get; protected set; }

        public bool CanSellByCredit { get; protected set; }
        public List<float> CreditSale { get; protected set; }

        // Uridium
        public bool CanBuyUridium { get; protected set; }
        public List<float> UridiumPurchase { get; protected set; }

        public bool CanSellUridium { get; protected set; }
        public List<float> UridiumSale { get; protected set; }

        // Auction
        public bool CanBuyOnAuctionHouse { get; protected set; }
    }
}