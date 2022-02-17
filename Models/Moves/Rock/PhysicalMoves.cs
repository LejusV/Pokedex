using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    #nullable enable
    internal class HeadSmash : Move
    {
        private static HeadSmash? _instance = null;
        public static HeadSmash Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HeadSmash();
                }
                return _instance;
            }
        }
        private HeadSmash() : base("Head Smash", Rock.Instance, MoveCategory.Physical, 5, 150, 0.8)
        { }
    }


    internal class RockBlast : Move
    {
        private static RockBlast? _instance = null;
        public static RockBlast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RockBlast();
                }
                return _instance;
            }
        }
        private RockBlast() : base("Rock Blast", Rock.Instance, MoveCategory.Physical, 10, 25, 0.9)
        { }
    }


    internal class RockSlide : Move
    {
        private static RockSlide? _instance = null;
        public static RockSlide Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RockSlide();
                }
                return _instance;
            }
        }
        private RockSlide() : base("Rock Slide", Rock.Instance, MoveCategory.Physical, 10, 65, 0.9)
        { }
    }


    internal class RockThrow : Move
    {
        private static RockThrow? _instance = null;
        public static RockThrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RockThrow();
                }
                return _instance;
            }
        }
        private RockThrow() : base("Wild Charge", Rock.Instance, MoveCategory.Physical, 15, 50, 0.9)
        { }
    }


    internal class RockTomb : Move
    {
        private static RockTomb? _instance = null;
        public static RockTomb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RockTomb();
                }
                return _instance;
            }
        }
        private RockTomb() : base("Rock Tomb", Rock.Instance, MoveCategory.Physical, 15, 60, 0.95)
        { }
    }
}
