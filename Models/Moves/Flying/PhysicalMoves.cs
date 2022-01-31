using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class Acrobatics : Move
    {
        private static Acrobatics? _instance = null;
        public static Acrobatics Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Acrobatics();
                }
                return _instance;
            }
        }
        private Acrobatics() : base("Acrobatics", Flying.Instance, MoveCategory.Physical, 15, 110, 1)
        {
        }
    }
    internal class BraveBird : Move
    {
        private static BraveBird? _instance = null;
        public static BraveBird Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BraveBird();
                }
                return _instance;
            }
        }
        private BraveBird() : base("Brave Bird", Flying.Instance, MoveCategory.Physical, 15, 120, 1)
        {
        }
    }
    internal class Fly : Move
    {
        private static Fly? _instance = null;
        public static Fly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fly();
                }
                return _instance;
            }
        }
        private Fly() : base("Fly", Flying.Instance, MoveCategory.Physical, 15, 90, 0.95)
        {
        }
    }
    internal class Peck : Move
    {
        private static Peck? _instance = null;
        public static Peck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Peck();
                }
                return _instance;
            }
        }
        private Peck() : base("Peck", Flying.Instance, MoveCategory.Physical, 35, 35, 1)
        {
        }
    }
    internal class SkyAttack : Move
    {
        private static SkyAttack? _instance = null;
        public static SkyAttack Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SkyAttack();
                }
                return _instance;
            }
        }
        private SkyAttack() : base("Sky Attack", Flying.Instance, MoveCategory.Physical, 5, 140, 0.9)
        {
        }
    }
}
