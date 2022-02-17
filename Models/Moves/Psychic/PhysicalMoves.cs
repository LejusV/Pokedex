using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    /// <summary>
    /// 30% chances to put fear on target (can't attack this turn)
    /// </summary>
    internal class HeartStamp : Move
    {
        private static HeartStamp? _instance = null;
        public static HeartStamp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HeartStamp();
                }
                return _instance;
            }
        }
        private HeartStamp() : base("Heart Stamp", Psychic.Instance, MoveCategory.Physical, 25, 60, 1)
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class PsychicFangs : Move
    {
        private static PsychicFangs? _instance = null;
        public static PsychicFangs Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PsychicFangs();
                }
                return _instance;
            }
        }
        private PsychicFangs() : base("Psychic Fangs", Psychic.Instance, MoveCategory.Physical, 10, 80, 1)
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class PsychoCut : Move
    {
        private static PsychoCut? _instance = null;
        public static PsychoCut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PsychoCut();
                }
                return _instance;
            }
        }
        private PsychoCut() : base("Psycho Cut", Psychic.Instance, MoveCategory.Physical, 20, 70, 1)
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class ZenHeadbutt : Move
    {
        private static ZenHeadbutt? _instance = null;
        public static ZenHeadbutt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ZenHeadbutt();
                }
                return _instance;
            }
        }
        private ZenHeadbutt() : base("Zen Headbutt", Psychic.Instance, MoveCategory.Physical, 15, 80, 0.9)
        { }
    }
}
