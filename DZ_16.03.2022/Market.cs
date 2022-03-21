using System;

namespace markets
{
    public class Market
    {
        public string marketName { get; set; }
        public string marketProfile { get; set; }
        public string marketAddress { get; set; }

        public Market(string marketName, string marketProfile, string marketAddress)
        {
            this.marketName = marketName;
            this.marketProfile = marketProfile;
            this.marketAddress = marketAddress;
        }

    }
}
