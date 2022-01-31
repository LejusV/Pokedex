using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class BabyDollEyes : Move
    {
        private static BabyDollEyes? _instance = null;
        public static BabyDollEyes Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BabyDollEyes();
                }
                return _instance;
            }
        }

        private BabyDollEyes() : base("Baby-Doll Eyes",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    30, null, 1)
        {
        }
    }
    internal class FlowerShield : Move
    {
        private static FlowerShield? _instance = null;
        public static FlowerShield Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FlowerShield();
                }
                return _instance;
            }
        }
        private FlowerShield() : base("Flower Shield",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    10)
        {
        }
    }
    internal class MistyTerrain : Move
    {
        private static MistyTerrain? _instance = null;
        public static MistyTerrain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MistyTerrain();
                }
                return _instance;
            }
        }
        private MistyTerrain() : base("Misty Terrain",
                                        Fairy.Instance,
                                        MoveCategory.Status,
                                        10)
        { }
    }
    internal class Moonlight : Move
    {
        private static Moonlight? _instance = null;
        public static Moonlight Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Moonlight();
                }
                return _instance;
            }
        }
        private Moonlight() : base("Moonlight",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    5
                                   )
        {
        }
    }
}
