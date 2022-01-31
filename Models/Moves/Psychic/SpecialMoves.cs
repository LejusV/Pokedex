using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    /// <summary>
    /// Deals damage and heal 50% inflicted damage if target is asleep
    /// </summary>
    internal class DreamEater : Move
    {
        private static DreamEater? _instance = null;
        public static DreamEater Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DreamEater();
                }
                return _instance;
            }
        }
        private DreamEater() : base("Dream Eater",
                                    Psychic.Instance,
                                    MoveCategory.Special,
                                    15,
                                    100,
                                    1)
        { }
    }
    internal class Extrasensory : Move
    {
        private static Extrasensory? _instance = null;
        public static Extrasensory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Extrasensory();
                }
                return _instance;
            }
        }
        private Extrasensory() : base("Extrasensory",
                                        Psychic.Instance,
                                        MoveCategory.Special,
                                        20,
                                        80,
                                        1)
        { }
    }

    /// <summary>
    /// 10% chance to lower special defense of target by 1 level
    /// </summary>
    internal class PsychicMove : Move
    {
        private static PsychicMove? _instance = null;
        public static PsychicMove Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PsychicMove();
                }
                return _instance;
            }
        }
        private PsychicMove() : base("Psychic (Move)",
                                Psychic.Instance,
                                MoveCategory.Special,
                                10,
                                90,
                                1)
        { }
    }

    /// <summary>
    /// dmg = (launcher level) * (X + 5) / 10;   X random number (0 ; 10)
    /// </summary>
    internal class Psywave : Move
    {
        private static Psywave? _instance = null;
        public static Psywave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Psywave();
                }
                return _instance;
            }
        }
        private Psywave() : base("Psywave",
                                Psychic.Instance,
                                MoveCategory.Special,
                                15,
                                null,
                                1)
        { }
    }

    /// <summary>
    /// Deals damage if target is same type than launcher (does not work on tenebra type as it is a psy move)
    /// </summary>
    internal class Synchronoise : Move
    {
        private static Synchronoise? _instance = null;
        public static Synchronoise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Synchronoise();
                }
                return _instance;
            }
        }
        private Synchronoise() : base("Synchronoise",
                                        Psychic.Instance,
                                        MoveCategory.Special,
                                        10,
                                        120,
                                        1)
        { }
    }
}
