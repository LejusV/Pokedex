using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    internal class Aromatherapy : Move
    {
        private static Aromatherapy? _instance = null;
        public static Aromatherapy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Aromatherapy();
                }
                return _instance;
            }
        }

        private Aromatherapy() : base("Aromatherapy",
                                    Grass.Instance,
                                    MoveCategory.Status,
                                    5)
        {
        }
    }
    internal class CottonGuard : Move
    {
        private static CottonGuard? _instance = null;
        public static CottonGuard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CottonGuard();
                }
                return _instance;
            }
        }
        private CottonGuard() : base("Cotton Guard",
                                    Grass.Instance,
                                    MoveCategory.Status,
                                    10)
        {
        }
    }

    /// <summary>
    /// Makes target sleep if no major status effet already on it. "Audio" move
    /// </summary>
    internal class GrassWhistle : Move
    {
        private static GrassWhistle? _instance = null;
        public static GrassWhistle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GrassWhistle();
                }
                return _instance;
            }
        }
        private GrassWhistle() : base("Grass Whistle",
                                        Grass.Instance,
                                        MoveCategory.Status,
                                        15,
                                        null,
                                        0.55)
        { }
    }

    /// <summary>
    /// drains hp from target every end of turn
    /// </summary>
    internal class LeechSeed : Move
    {
        private static LeechSeed? _instance = null;
        public static LeechSeed Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LeechSeed();
                }
                return _instance;
            }
        }
        private LeechSeed() : base("Leech Seed",
                                    Grass.Instance,
                                    MoveCategory.Status,
                                    10,
                                    null,
                                    0.9)
        { }
    }

    /// <summary>
    /// Makes target sleep if no major status effect already on target
    /// </summary>
    internal class SleepPowder : Move
    {
        private static SleepPowder? _instance = null;
        public static SleepPowder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SleepPowder();
                }
                return _instance;
            }
        }
        private SleepPowder() : base("Sleep Powder",
                                    Grass.Instance,
                                    MoveCategory.Status,
                                    15,
                                    null,
                                    0.75)
        { }
    }
}
