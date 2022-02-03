using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class Discharge : Move
    {
        private static Discharge? _instance = null;
        public static Discharge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Discharge();
                }
                return _instance;
            }
        }
        private Discharge() : base("Discharge",
                                    Electric.Instance,
                                    MoveCategory.Special,
                                    15, 80, 1)
        { }
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
        private ShockWave() : base(
                                    "Shock Wave",
                                    Electric.Instance,
                                    MoveCategory.Special,
                                    20, 60, null
                                  )
        {
        }
    }

    internal class Thunder : Move
    {
        private static Thunder? _instance = null;
        public static Thunder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Thunder();
                }
                return _instance;
            }
        }
        private Thunder() : base("Thunder", Electric.Instance, MoveCategory.Special, 10, 120, 0.7)
        { }
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
        private Thunderbolt() : base(
                                        "Thunderbolt",
                                        Electric.Instance,
                                        MoveCategory.Special,
                                        15, 95, 1
                                    )
        {
        }
    }

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

        private ThunderShock() : base("Thunder Shock",
                                        Electric.Instance,
                                        MoveCategory.Special,
                                        30, 40, 1
                                    )
        { }
    }
}
