using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class AquaRing : Move
    {
        private static AquaRing? _instance = null;
        public static AquaRing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AquaRing();
                }
                return _instance;
            }
        }

        private AquaRing() : base("Aqua Ring",
                                    Water.Instance,
                                    MoveCategory.Status,
                                    20)
        { }
    }


    internal class LifeDew : Move
    {
        private static LifeDew? _instance = null;
        public static LifeDew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LifeDew();
                }
                return _instance;
            }
        }
        private LifeDew() : base("Life Dew",
                                    Water.Instance,
                                    MoveCategory.Status,
                                    10)
        { }
    }

    
    internal class Soak : Move
    {
        private static Soak? _instance = null;
        public static Soak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Soak();
                }
                return _instance;
            }
        }
        private Soak() : base("Soak",
                                Water.Instance,
                                MoveCategory.Status,
                                20)
        { }
    }


    internal class WaterSport : Move
    {
        private static WaterSport? _instance = null;
        public static WaterSport Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WaterSport();
                }
                return _instance;
            }
        }
        private WaterSport() : base("Water Sport",
                                    Water.Instance,
                                    MoveCategory.Status,
                                    15)
        { }
    }


    internal class Withdraw : Move
    {
        private static Withdraw? _instance = null;
        public static Withdraw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Withdraw();
                }
                return _instance;
            }
        }
        private Withdraw() : base("Withdraw",
                                    Water.Instance,
                                    MoveCategory.Status,
                                    40)
        { }
    }
}
