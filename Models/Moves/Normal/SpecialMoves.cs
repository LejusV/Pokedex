using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
#nullable enable
    internal class EchoedVoice : Move
    {
        private static EchoedVoice? _instance = null;
        public static EchoedVoice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EchoedVoice();
                }
                return _instance;
            }
        }
        private EchoedVoice() : base(
                                    "Echoed Voice",
                                    Normal.Instance,
                                    MoveCategory.Special,
                                    15, 40, 1
                                  )
        {
        }
    }

    internal class HyperVoice : Move
    {
        private static HyperVoice? _instance = null;
        public static HyperVoice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HyperVoice();
                }
                return _instance;
            }
        }
        private HyperVoice() : base("Hyper Voice",
                                    Normal.Instance,
                                    MoveCategory.Special,
                                    10, 90, 1)
        { }
    }

    internal class RevelationDance : Move
    {
        private static RevelationDance? _instance = null;
        public static RevelationDance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RevelationDance();
                }
                return _instance;
            }
        }
        private RevelationDance() : base(
                                        "Revelation Dance",
                                        Normal.Instance,
                                        MoveCategory.Special,
                                        15, 90, 1
                                    )
        {
        }
    }

    internal class SonicBoom : Move
    {
        private static SonicBoom? _instance = null;
        public static SonicBoom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SonicBoom();
                }
                return _instance;
            }
        }
        private SonicBoom() : base("Sonic Boom", Normal.Instance, MoveCategory.Special, 20, null, 0.9)
        { }
    }

    internal class WringOut : Move
    {
        private static WringOut? _instance = null;
        public static WringOut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WringOut();
                }
                return _instance;
            }
        }

        private WringOut() : base("Wring Out",
                                        Normal.Instance,
                                        MoveCategory.Special,
                                        5, null, 1
                                    )
        {
        }
    }
}
