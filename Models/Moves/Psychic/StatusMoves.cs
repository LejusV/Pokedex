using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    /// <summary>
    /// launcher gains two levels of speed
    /// </summary>
    internal class Agility : Move
    {
        private static Agility? _instance = null;
        public static Agility Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Agility();
                }
                return _instance;
            }
        }

        private Agility() : base("Agility",
                                    Psychic.Instance,
                                    MoveCategory.Status,
                                    30)
        { }
    }

    /// <summary>
    /// launcher gains two levels of special defense
    /// </summary>
    internal class Amnesia : Move
    {
        private static Amnesia? _instance = null;
        public static Amnesia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Amnesia();
                }
                return _instance;
            }
        }
        private Amnesia() : base("Amnesia",
                                    Psychic.Instance,
                                    MoveCategory.Status,
                                    20)
        { }
    }

    /// <summary>
    /// launcher gains one level of both defense and special defense
    /// </summary>
    internal class CosmicPower : Move
    {
        private static CosmicPower? _instance = null;
        public static CosmicPower Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CosmicPower();
                }
                return _instance;
            }
        }
        private CosmicPower() : base("Cosmic Power",
                                        Psychic.Instance,
                                        MoveCategory.Status,
                                        20, null, 1)
        { }
    }

    /// <summary>
    /// makes target asleep
    /// </summary>
    internal class Hypnosis : Move
    {
        private static Hypnosis? _instance = null;
        public static Hypnosis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hypnosis();
                }
                return _instance;
            }
        }
        private Hypnosis() : base("Hypnosis",
                                    Psychic.Instance,
                                    MoveCategory.Status,
                                    20, null, 0.6)
        { }
    }

    /// <summary>
    /// launcher gains one level of attack
    /// </summary>
    internal class Meditate : Move
    {
        private static Meditate? _instance = null;
        public static Meditate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Meditate();
                }
                return _instance;
            }
        }
        private Meditate() : base("Meditate",
                                    Psychic.Instance,
                                    MoveCategory.Status,
                                    40)
        { }
    }
}
