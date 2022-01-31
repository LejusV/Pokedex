using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class BlazeKick : Move
    {
        private static BlazeKick? _instance = null;
        public static BlazeKick Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BlazeKick();
                }
                return _instance;
            }
        }
        private BlazeKick() : base("Blaze Kick",
                                    Fire.Instance,
                                    MoveCategory.Physical,
                                    10,
                                    85,
                                    0.9)
        {
        }
    }
    internal class FireFang : Move
    {
        private static FireFang? _instance = null;
        public static FireFang Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FireFang();
                }
                return _instance;
            }
        }
        private FireFang() : base("Fire Fang",
                                 Fire.Instance,
                                 MoveCategory.Physical,
                                 15,
                                 65,
                                 0.95)
        { }
    }
    internal class FirePunch : Move
    {
        private static FirePunch? _instance = null;
        public static FirePunch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FirePunch();
                }
                return _instance;
            }
        }
        private FirePunch() : base("Fire Punch",
                                    Fire.Instance,
                                    MoveCategory.Physical,
                                    15,
                                    75,
                                    1)
        { }
    }
    internal class FlareBlitz : Move
    {
        private static FlareBlitz? _instance = null;
        public static FlareBlitz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FlareBlitz();
                }
                return _instance;
            }
        }
        private FlareBlitz() : base("Flare Blitz",
                                    Fire.Instance,
                                    MoveCategory.Physical,
                                    15,
                                    120,
                                    1)
        { }
    }
    internal class SacredFire : Move
    {
        private static SacredFire? _instance = null;
        public static SacredFire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SacredFire();
                }
                return _instance;
            }
        }
        private SacredFire() : base("Sacred Fire",
                                Fire.Instance,
                                MoveCategory.Physical,
                                5,
                                100,
                                0.95)
        { }
    }
}
