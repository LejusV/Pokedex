using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class ThunderWave : Move
    {
        private static ThunderWave? _instance = null;
        public static ThunderWave Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThunderWave();
                }
                return _instance;
            }
        }

        private ThunderWave() : base("Thunder Wave",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    20, null, 1)
        {
        }
    }
    internal class IonDeluge : Move
    {
        private static IonDeluge? _instance = null;
        public static IonDeluge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new IonDeluge();
                }
                return _instance;
            }
        }
        private IonDeluge() : base(
                                    "Ion Deluge",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    25)
        {
        }
    }
    internal class EerieImpulse : Move
    {
        private static EerieImpulse? _instance = null;
        public static EerieImpulse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EerieImpulse();
                }
                return _instance;
            }
        }
        private EerieImpulse() : base("Eerie Impulse",
                                        Fairy.Instance,
                                        MoveCategory.Status,
                                        15, null, 1)
        { }
    }
    internal class MagnetRise : Move
    {
        private static MagnetRise? _instance = null;
        public static MagnetRise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MagnetRise();
                }
                return _instance;
            }
        }
        private MagnetRise() : base(
                                    "Magnet Rise",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    10, null, 1
                                   )
        {
        }
    }
    internal class Charge : Move
    {
        private static Charge? _instance = null;
        public static Charge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Charge();
                }
                return _instance;
            }
        }
        private Charge() : base(
                                    "Charge",
                                    Fairy.Instance,
                                    MoveCategory.Status,
                                    20, null, 1
                               )
        {
        }
    }
}
