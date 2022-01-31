using Pokedex.Enums;
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
        private BoltStrike() : base("Bolt Strike", Rock.Instance, MoveCategory.Physical, 5, 130, 0.8)
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
        private ThunderFang() : base("Thunder Fang", Rock.Instance, MoveCategory.Physical, 15, 65, 0.95)
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
        private FusionBolt() : base("Fusion Bolt", Rock.Instance, MoveCategory.Physical, 5, 100)
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
        private WildCharge() : base("Wild Charge", Rock.Instance, MoveCategory.Physical, 15, 90)
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
        private Spark() : base("Spark", Rock.Instance, MoveCategory.Physical, 20, 65)
        {
        }
    }
}
