using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    internal class Acid : Move
    {
        private static Acid? _instance = null;
        public static Acid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Acid();
                }
                return _instance;
            }
        }
        private Acid() : base("Acid",
                                Poison.Instance,
                                MoveCategory.Special,
                                30, 40, 1)
        { }
    }

    internal class Smog : Move
    {
        private static Smog? _instance = null;
        public static Smog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Smog();
                }
                return _instance;
            }
        }
        private Smog() : base(
                                "Smog",
                                Poison.Instance,
                                MoveCategory.Special,
                                20, 30, 0.7
                                )
        {
        }
    }

    internal class Sludge : Move
    {
        private static Sludge? _instance = null;
        public static Sludge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Sludge();
                }
                return _instance;
            }
        }
        private Sludge() : base("Sludge", Poison.Instance, MoveCategory.Special, 20, 65, 1)
        { }
    }

    internal class Venoshock : Move
    {
        private static Venoshock? _instance = null;
        public static Venoshock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Venoshock();
                }
                return _instance;
            }
        }
        private Venoshock() : base(
                                    "Venoshock",
                                    Poison.Instance,
                                    MoveCategory.Special,
                                    10, 65, 1
                                    )
        {
        }
    }

    internal class AcidSpray : Move
    {
        private static AcidSpray? _instance = null;
        public static AcidSpray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AcidSpray();
                }
                return _instance;
            }
        }

        private AcidSpray() : base("Acid Spray",
                                    Poison.Instance,
                                    MoveCategory.Special,
                                    20, 40, 1
                                    )
        {
        }
    }
}
