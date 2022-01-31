using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    /// <summary>
    /// 
    /// </summary>
    internal class GrassyGlide : Move
    {
        private static GrassyGlide? _instance = null;
        public static GrassyGlide Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GrassyGlide();
                }
                return _instance;
            }
        }
        private GrassyGlide() : base("Grassy Glide", Grass.Instance, MoveCategory.Physical, 20, 70, 1)
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class PetalBlizzard : Move
    {
        private static PetalBlizzard? _instance = null;
        public static PetalBlizzard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PetalBlizzard();
                }
                return _instance;
            }
        }
        private PetalBlizzard() : base("Petal Blizzard", Grass.Instance, MoveCategory.Physical, 15, 90, 1)
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class SeedBomb : Move
    {
        private static SeedBomb? _instance = null;
        public static SeedBomb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SeedBomb();
                }
                return _instance;
            }
        }
        private SeedBomb() : base("Seed Bomb", Grass.Instance, MoveCategory.Physical, 15, 80, 1)
        { }
    }

    /// <summary>
    /// 
    /// </summary>
    internal class RazorLeaf : Move
    {
        private static RazorLeaf? _instance = null;
        public static RazorLeaf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RazorLeaf();
                }
                return _instance;
            }
        }
        private RazorLeaf() : base("Razor Leaf", Grass.Instance, MoveCategory.Physical, 25, 55, 0.95)
        { }
    }


    /// <summary>
    /// 
    /// </summary>
    internal class WoodHammer : Move
    {
        private static WoodHammer? _instance = null;
        public static WoodHammer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WoodHammer();
                }
                return _instance;
            }
        }
        private WoodHammer() : base("Wood Hammer", Grass.Instance, MoveCategory.Physical, 15, 120, 1)
        { }
    }
}
