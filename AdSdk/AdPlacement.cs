using Nefta.AdSdk.Data;

namespace Nefta.AdSdk
{
    public enum ImpressionType
    {
        Banner,
        Interstitial,
        VideoAd
    }
    
    public class AdPlacement
    {
        public enum Position
        {
            Center,
            Top,
            Right,
            Bottom,
            Left
        }
        
        public enum LoadFailReason
        {
            BidError,
            NoBids
        }
        
        public ImpressionType _type;
        public string _id;
        public float _floorPriceInUsd;
        public int _configWidth;
        public int _configHeight;
        public Position _position;

        public Bid _bid;
        public int _screenWidth;
        public int _screenHeight;
        public bool _isCreativeLoaded;

        public AdPlacement(ImpressionType type, string id, float floorPriceInUsd, int width, int height, Position position)
        {
            _type = type;
            _id = id;
            _floorPriceInUsd = floorPriceInUsd;
            _configWidth = width;
            _configHeight = height;
            _position = position;
        }

        public virtual void OnClose()
        {
            _bid = null;
        }
    }
}