using System;

namespace Nefta.ToolboxSdk.Nft
{
    [Serializable]
    public class NftCharacteristics
    {
        public string currency; // parameter with "nft_staking" 
        public string currency_id; // parameter with "nft_staking" 
        public float principal_amount; // parameter with "nft_staking" 
        public float interest; // parameter with "nft_staking". Interest earned per day based on principal   

        public int days_to_self_destruct; // parameter with "timed_assets" 
        public int hours_to_self_destruct; // parameter with "timed_assets" 
        public int minute_to_self_destruct; // parameter with "timed_assets" 

        //public int rental_period;  // parameter with "rentable" 
        public string rental_period_type; // parameter with "rentable" can be "day" or "month"

        // The following are booleans indicating the present characteristics of the asset 
        public bool nft_staking;
        public bool burnable;
        public bool rentable;
        public bool timed_assets;
        public bool evolvable;
    }
}