using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    /// <summary>
    /// Lower ennemy dodging skill
    /// </summary>
    internal class Defog : Move
    {
        private static Defog? _instance = null;
        public static Defog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Defog();
                }
                return _instance;
            }
        }

        private Defog() : base("Defog",
                                Flying.Instance,
                                MoveCategory.Status,
                                15)
        { }
    }

    /// <summary>
    /// Lower ennemy attack by 2 levels
    /// </summary>
    internal class FeatherDance : Move
    {
        private static FeatherDance? _instance = null;
        public static FeatherDance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FeatherDance();
                }
                return _instance;
            }
        }
        private FeatherDance() : base(
                                    "Feather Dance",
                                    Flying.Instance,
                                    MoveCategory.Status,
                                    15)
        { }
    }

    /// <summary>
    /// Spell Defog /!\ Clone last spell received on launcher, need to stack data every round
    /// </summary>
    internal class MirrorMove : Move
    {
        private static MirrorMove? _instance = null;
        public static MirrorMove Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MirrorMove();
                }
                return _instance;
            }
        }
        private MirrorMove() : base("Mirror Move",
                                    Flying.Instance,
                                    MoveCategory.Status,
                                    20)
        { }
    }

    /// <summary>
    /// Land, making launcher heal and loose his flying type unti the end of this turn
    /// </summary>
    internal class Roost : Move
    {
        private static Roost? _instance = null;
        public static Roost Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Roost();
                }
                return _instance;
            }
        }
        private Roost() : base("Roost",
                                Flying.Instance,
                                MoveCategory.Status,
                                10)
        { }
    }

    /// <summary>
    /// double entire team speed for 4 rounds
    /// </summary>
    internal class Tailwind : Move
    {
        private static Tailwind? _instance = null;
        public static Tailwind Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tailwind();
                }
                return _instance;
            }
        }
        private Tailwind() : base("Tailwind",
                                    Flying.Instance,
                                    MoveCategory.Status,
                                    15)
        { }
    }
}
