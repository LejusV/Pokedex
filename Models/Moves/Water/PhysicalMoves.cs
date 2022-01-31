using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class AquaJet : Move
    {
        private static AquaJet? _instance = null;
        public static AquaJet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AquaJet();
                }
                return _instance;
            }
        }
        private AquaJet() : base("Aqua Jet", Water.Instance, MoveCategory.Physical, 20, 40, 1)
        { }
    }


    internal class AquaTail : Move
    {
        private static AquaTail? _instance = null;
        public static AquaTail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AquaTail();
                }
                return _instance;
            }
        }
        private AquaTail() : base("Aqua Tail", Water.Instance, MoveCategory.Physical, 10, 90, 0.9)
        { }
    }


    internal class Dive : Move
    {
        private static Dive? _instance = null;
        public static Dive Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dive();
                }
                return _instance;
            }
        }
        private Dive() : base("Dive", Water.Instance, MoveCategory.Physical, 10, 80, 1)
        { }
    }


    internal class Liquidation : Move
    {
        private static Liquidation? _instance = null;
        public static Liquidation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Liquidation();
                }
                return _instance;
            }
        }
        private Liquidation() : base("Liquidation", Water.Instance, MoveCategory.Physical, 10, 85, 1)
        { }
    }


    internal class RazorShell : Move
    {
        private static RazorShell? _instance = null;
        public static RazorShell Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RazorShell();
                }
                return _instance;
            }
        }
        private RazorShell() : base("Razor Shell", Water.Instance, MoveCategory.Physical, 10, 75, 0.95)
        { }
    }
}
