using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    internal class AirCutter : Move
    {
        private static AirCutter? _instance = null;
        public static AirCutter Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AirCutter();
                }
                return _instance;
            }
        }

        private AirCutter() : base("Air Cutter",
                                        Flying.Instance,
                                        MoveCategory.Special,
                                        25,
                                        60,
                                        0.95)
        {
        }
    }
    internal class AirSlash : Move
    {
        private static AirSlash? _instance = null;
        public static AirSlash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AirSlash();
                }
                return _instance;
            }
        }
        private AirSlash() : base("AirSlash",
                                Flying.Instance,
                                MoveCategory.Special,
                                15,
                                75,
                                0.95)
        {
        }
    }
    internal class Gust : Move
    {
        private static Gust? _instance = null;
        public static Gust Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Gust();
                }
                return _instance;
            }
        }
        private Gust() : base("Gust",
                                Flying.Instance,
                                MoveCategory.Special,
                                35,
                                40,
                                1)
        {
        }
    }
    internal class Hurricane : Move
    {
        private static Hurricane? _instance = null;
        public static Hurricane Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hurricane();
                }
                return _instance;
            }
        }
        private Hurricane() : base("Hurricane",
                                    Flying.Instance,
                                    MoveCategory.Special,
                                    10,
                                    110,
                                    0.7)
        {}
    }
}
