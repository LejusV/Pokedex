using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class Brine : Move
    {
        private static Brine? _instance = null;
        public static Brine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Brine();
                }
                return _instance;
            }
        }

        private Brine() : base("Brine",
                                Water.Instance,
                                MoveCategory.Special,
                                10,
                                65,
                                1)
        { }
    }


    internal class Bubble : Move
    {
        private static Bubble? _instance = null;
        public static Bubble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bubble();
                }
                return _instance;
            }
        }
        private Bubble() : base("Bubble",
                                Water.Instance,
                                MoveCategory.Special,
                                30,
                                40,
                                1)
        { }
    }


    internal class HydroCannon : Move
    {
        private static HydroCannon? _instance = null;
        public static HydroCannon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HydroCannon();
                }
                return _instance;
            }
        }
        private HydroCannon() : base("Hydro Cannon",
                                    Water.Instance,
                                    MoveCategory.Special,
                                    5,
                                    150,
                                    0.9)
        { }
    }
    internal class Octazooka : Move
    {
        private static Octazooka? _instance = null;
        public static Octazooka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Octazooka();
                }
                return _instance;
            }
        }
        private Octazooka() : base("Octazooka",
                                    Water.Instance,
                                    MoveCategory.Special,
                                    10,
                                    65,
                                    0.85)
        {}
    }
    internal class WaterGun : Move
    {
        private static WaterGun? _instance = null;
        public static WaterGun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WaterGun();
                }
                return _instance;
            }
        }
        private WaterGun() : base("Water Gun",
                                    Water.Instance,
                                    MoveCategory.Special,
                                    25,
                                    40,
                                    1)
        {}
    }
}
