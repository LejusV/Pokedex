
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class ThunderShock : Move
    {
        private static ThunderShock? _instance = null;
        public static ThunderShock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThunderShock();
                }
                return _instance;
            }
        }
        private ThunderShock() : base("Thunder Shock", Electric.Instance, Special.Instance, 30, 40, 1, true)
        {
        }
    }
    internal class Thunderbolt : Move
    {
        private static Thunderbolt? _instance = null;
        public static Thunderbolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Thunderbolt();
                }
                return _instance;
            }
        }
        private Thunderbolt() : base("Thunderbolt", Electric.Instance, Special.Instance, 15, 95, 1)
        {
        }
    }
    internal class ShockWave : Move
    {
        private static ShockWave? _instance = null;
        public static ShockWave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ShockWave();
                }
                return _instance;
            }
        }
        private ShockWave() : base("Shock Wave", Electric.Instance, Special.Instance, 20, 60, 1)
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
        private WildCharge() : base("Wild Charge", Electric.Instance, Special.Instance, 15, 90, 1)
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
        private Spark() : base("Spark", Electric.Instance, Special.Instance, 20, 65, 1)
        {
        }
    }
}
