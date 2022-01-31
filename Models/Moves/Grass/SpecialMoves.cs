using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class EnergyBall : Move
    {
        private static EnergyBall? _instance = null;
        public static EnergyBall Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EnergyBall();
                }
                return _instance;
            }
        }

        private EnergyBall() : base("Energy Ball",
                                    Grass.Instance,
                                    MoveCategory.Special,
                                    10,
                                    90,
                                    1)
        { }
    }
    internal class GigaDrain : Move
    {
        private static GigaDrain? _instance = null;
        public static GigaDrain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GigaDrain();
                }
                return _instance;
            }
        }
        private GigaDrain() : base("Giga Drain",
                                    Grass.Instance,
                                    MoveCategory.Special,
                                    10,
                                    75,
                                    1)
        { }
    }

    /// <summary>
    /// Deals damage depending on ennemy weight
    /// </summary>
    internal class GrassKnot : Move
    {
        private static GrassKnot? _instance = null;
        public static GrassKnot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GrassKnot();
                }
                return _instance;
            }
        }
        private GrassKnot() : base("Grass Knot",
                                    Grass.Instance,
                                    MoveCategory.Special,
                                    20,
                                    null,
                                    1)
        { }
    }
    internal class MagicalLeaf : Move
    {
        private static MagicalLeaf? _instance = null;
        public static MagicalLeaf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MagicalLeaf();
                }
                return _instance;
            }
        }
        private MagicalLeaf() : base("Magical Leaf",
                                    Grass.Instance,
                                    MoveCategory.Special,
                                    20,
                                    60)
        { }
    }
    internal class SolarBeam : Move
    {
        private static SolarBeam? _instance = null;
        public static SolarBeam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SolarBeam();
                }
                return _instance;
            }
        }
        private SolarBeam() : base("Solar Beam",
                                    Grass.Instance,
                                    MoveCategory.Special,
                                    10,
                                    120,
                                    1)
        { }
    }
}