using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
#nullable enable
    internal class Bide : Move
    {
        private static Bide? _instance = null;
        public static Bide Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bide();
                }
                return _instance;
            }
        }
        private Bide() : base("Bide", Normal.Instance, MoveCategory.Physical, 10)
        {
        }
    }

    internal class Cut : Move
    {
        private static Cut? _instance = null;
        public static Cut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Cut();
                }
                return _instance;
            }
        }
        private Cut() : base("Cut", Normal.Instance, MoveCategory.Physical, 15, 90, 1)
        {
        }
    }

    internal class DoubleEdge : Move
    {
        private static DoubleEdge? _instance = null;
        public static DoubleEdge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DoubleEdge();
                }
                return _instance;
            }
        }
        private DoubleEdge() : base("Double-Edge", Normal.Instance, MoveCategory.Physical, 35, 40, 1)
        {
        }
    }

    internal class RapidSpin : Move
    {
        private static RapidSpin? _instance = null;
        public static RapidSpin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RapidSpin();
                }
                return _instance;
            }
        }
        private RapidSpin() : base("Rapid Spin", Normal.Instance, MoveCategory.Physical, 40, 20, 1)
        {
        }
    }

    internal class Scratch : Move
    {
#nullable enable
        private static Scratch? _instance = null;
        public static Scratch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Scratch();
                }
                return _instance;
            }
        }

        /*public string Use(Pokemon sender, Pokemon target)
        {
            target.ActualStats.Set("hp", sender.ActualStats.Get("power"))
        }*/

        private Scratch() : base("Scratch", Normal.Instance, MoveCategory.Physical, 35, 40, 1)
        {
        }
    }

    internal class Tackle : Move
    {
        private static Tackle? _instance = null;
        public static Tackle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tackle();
                }
                return _instance;
            }
        }
        private Tackle() : base("Tackle", Normal.Instance, MoveCategory.Physical, 35, 40, 1)
        {
        }
    }
}
#nullable restore