using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    internal class AncientPower : Move
    {
        private static AncientPower? _instance = null;
        public static AncientPower Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AncientPower();
                }
                return _instance;
            }
        }

        private AncientPower() : base("Ancient Power",
                                        Rock.Instance,
                                        MoveCategory.Special,
                                        5,
                                        60,
                                        1)
        { }
    }


    internal class MeteorBeam : Move
    {
        private static MeteorBeam? _instance = null;
        public static MeteorBeam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MeteorBeam();
                }
                return _instance;
            }
        }
        private MeteorBeam() : base("Meteor Beam",
                                    Rock.Instance,
                                    MoveCategory.Special,
                                    10,
                                    120,
                                    0.9)
        { }
    }


    internal class PowerGem : Move
    {
        private static PowerGem? _instance = null;
        public static PowerGem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PowerGem();
                }
                return _instance;
            }
        }
        private PowerGem() : base("Power Gem",
                                    Rock.Instance,
                                    MoveCategory.Special,
                                    20,
                                    80,
                                    1)
        { }
    }
}
