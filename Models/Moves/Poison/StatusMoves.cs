using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    internal class AcidArmor : Move
    {
        private static AcidArmor? _instance = null;
        public static AcidArmor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AcidArmor();
                }
                return _instance;
            }
        }
        private AcidArmor() : base(
                                    "Acid Armor",
                                    Poison.Instance,
                                    MoveCategory.Status,
                                    20
                               )
        {}
    }

    internal class Coil : Move
    {
        private static Coil? _instance = null;
        public static Coil Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Coil();
                }
                return _instance;
            }
        }
        private Coil() : base("Coil",
                                Poison.Instance,
                                MoveCategory.Status,
                                20)
        { }
    }
    
    internal class PoisonGas : Move
    {
        private static PoisonGas? _instance = null;
        public static PoisonGas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PoisonGas();
                }
                return _instance;
            }
        }
        private PoisonGas() : base(
                                    "Poison Gas",
                                    Poison.Instance,
                                    MoveCategory.Status,
                                    40, null, 90)
        {}
    }
    
    internal class PoisonPowder : Move
    {
        private static PoisonPowder? _instance = null;
        public static PoisonPowder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PoisonPowder();
                }
                return _instance;
            }
        }
        private PoisonPowder() : base(
                                    "Poison Powder",
                                    Poison.Instance,
                                    MoveCategory.Status,
                                    35, null, 0.75
                                    )
        {
        }
    }

    internal class Toxic : Move
    {
        private static Toxic? _instance = null;
        public static Toxic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Toxic();
                }
                return _instance;
            }
        }
        private Toxic() : base("Toxic",
                                Poison.Instance,
                                MoveCategory.Status,
                                10, null, 0.9)
        {}
    }
}
