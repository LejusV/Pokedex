using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class BlueFlare : Move
    {
        private static BlueFlare? _instance = null;
        public static BlueFlare Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BlueFlare();
                }
                return _instance;
            }
        }

        private BlueFlare() : base("Blue Flare",
                                        Fire.Instance,
                                        MoveCategory.Special,
                                        4,
                                        130,
                                        0.85)
        {}
    }

    internal class Ember : Move
    {
        private static Ember? _instance = null;
        public static Ember Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ember();
                }
                return _instance;
            }
        }
        private Ember() : base("Ember",
                                Fire.Instance,
                                MoveCategory.Special,
                                25,
                                40,
                                1)
        { }
    }

    internal class Flamethrower : Move
    {
        private static Flamethrower? _instance = null;
        public static Flamethrower Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Flamethrower();
                }
                return _instance;
            }
        }
        private Flamethrower() : base(
                                        "Flamethrower",
                                        Fire.Instance,
                                        MoveCategory.Special,
                                        15,
                                        95,
                                        1)
        {}
    }
    internal class FieryDance : Move
    {
        private static FieryDance? _instance = null;
        public static FieryDance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FieryDance();
                }
                return _instance;
            }
        }
        private FieryDance() : base("Fiery Dance",
                                    Fire.Instance,
                                    MoveCategory.Special,
                                    10,
                                    80,
                                    1)
        {}
    }
    internal class LavaPlume : Move
    {
        private static LavaPlume? _instance = null;
        public static LavaPlume Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LavaPlume();
                }
                return _instance;
            }
        }
        private LavaPlume() : base("Lava Plume",
                                    Fire.Instance,
                                    MoveCategory.Special,
                                    15,
                                    80,
                                    1)
        {}
    }
}
