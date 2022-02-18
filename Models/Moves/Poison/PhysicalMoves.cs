using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
#nullable enable
    internal class PoisonSting : Move
    {
        private static PoisonSting? _instance = null;
        public static PoisonSting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PoisonSting();
                }
                return _instance;
            }
        }
        private PoisonSting() : base("Poison Sting", Poison.Instance, MoveCategory.Physical, 35, 15, 1)
        {
        }
    }

    internal class PoisonFang : Move
    {
        private static PoisonFang? _instance = null;
        public static PoisonFang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PoisonFang();
                }
                return _instance;
            }
        }
        private PoisonFang() : base("Poison Fang", Poison.Instance, MoveCategory.Physical, 15, 50, 1)
        {
        }
    }

    internal class PoisonTail : Move
    {
        private static PoisonTail? _instance = null;
        public static PoisonTail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PoisonTail();
                }
                return _instance;
            }
        }
        private PoisonTail() : base("Poison Tail", Poison.Instance, MoveCategory.Physical, 25, 50, 1)
        {
        }
    }

    internal class PoisonJab : Move
    {
        private static PoisonJab? _instance = null;
        public static PoisonJab Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PoisonJab();
                }
                return _instance;
            }
        }
        private PoisonJab() : base("Poison Jab", Poison.Instance, MoveCategory.Physical, 20, 80, 1)
        {
        }
    }

    internal class GunkShot : Move
    {
        private static GunkShot? _instance = null;
        public static GunkShot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GunkShot();
                }
                return _instance;
            }
        }
        private GunkShot() : base("Gunk Shot", Poison.Instance, MoveCategory.Physical, 5, 120, 0.8)
        {
        }
    }
}
