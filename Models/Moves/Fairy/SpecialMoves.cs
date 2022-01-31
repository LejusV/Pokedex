using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class DazzlingGleam : Move
    {
        private static DazzlingGleam? _instance = null;
        public static DazzlingGleam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DazzlingGleam();
                }
                return _instance;
            }
        }

        private DazzlingGleam() : base("Dazzling Gleam",
                                        Fairy.Instance,
                                        MoveCategory.Special,
                                        10,
                                        80,
                                        1)
        {
        }
    }
    internal class DisarmingVoice : Move
    {
        private static DisarmingVoice? _instance = null;
        public static DisarmingVoice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DisarmingVoice();
                }
                return _instance;
            }
        }
        private DisarmingVoice() : base("Disarming Voice",
                                        Fairy.Instance,
                                        MoveCategory.Special,
                                        15,
                                        40)
        {
        }
    }
    internal class DrainingKiss : Move
    {
        private static DrainingKiss? _instance = null;
        public static DrainingKiss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DrainingKiss();
                }
                return _instance;
            }
        }
        private DrainingKiss() : base("Draining Kiss",
                                    Fairy.Instance,
                                    MoveCategory.Special,
                                    10,
                                    50,
                                    1)
        {
        }
    }
    internal class FairyWind : Move
    {
        private static FairyWind? _instance = null;
        public static FairyWind Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FairyWind();
                }
                return _instance;
            }
        }
        private FairyWind() : base("Fairy Wind",
                                    Fairy.Instance,
                                    MoveCategory.Special,
                                    30,
                                    40,
                                    1)
        {}
    }
    internal class Moonblast : Move
    {
        private static Moonblast? _instance = null;
        public static Moonblast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Moonblast();
                }
                return _instance;
            }
        }
        private Moonblast() : base("Moonblast",
                                    Fairy.Instance,
                                    MoveCategory.Special,
                                    15,
                                    95,
                                    1)
        {}
    }
}
