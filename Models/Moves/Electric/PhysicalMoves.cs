
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class BoltStrike : Move
    {
        private static BoltStrike? _instance = null;
        public static BoltStrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BoltStrike();
                }
                return _instance;
            }
        }
        private BoltStrike() : base("Bolt Strike", Electric.Instance, Physical.Instance, 5, 130, 0.8)
        {
        }
    }
    internal class ThunderFang : Move
    {
        private static ThunderFang? _instance = null;
        public static ThunderFang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThunderFang();
                }
                return _instance;
            }
        }
        private ThunderFang() : base("Thunder Fang", Electric.Instance, Physical.Instance, 15, 65, 0.95)
        {
        }
    }
    internal class FusionBolt : Move
    {
        private static FusionBolt? _instance = null;
        public static FusionBolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FusionBolt();
                }
                return _instance;
            }
        }
        private FusionBolt() : base("Fusion Bolt", Electric.Instance, Physical.Instance, 5, 100, 1)
        {
        }
    }
    internal class WildCharge : Move
    {
        private static WildCharge? _instance = null;
        public static WildCharge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WildCharge();
                }
                return _instance;
            }
        }
        private WildCharge() : base("Wild Charge", Electric.Instance, Physical.Instance, 15, 90, 1)
        {
        }
    }
    internal class Spark : Move
    {
        private static Spark? _instance = null;
        public static Spark Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Spark();
                }
                return _instance;
            }
        }
        private Spark() : base("Spark", Electric.Instance, Physical.Instance, 20, 65, 1)
        {
        }
    }
}
