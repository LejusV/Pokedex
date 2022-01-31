using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
    internal class WillOWisp : Move
    {
        private static WillOWisp? _instance = null;
        public static WillOWisp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WillOWisp();
                }
                return _instance;
            }
        }

        private WillOWisp() : base("Will-O-Wisp",
                                    Fire.Instance,
                                    MoveCategory.Status,
                                    15,
                                    null,
                                    75)
        {
        }
    }
    internal class SunnyDay : Move
    {
        private static SunnyDay? _instance = null;
        public static SunnyDay Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SunnyDay();
                }
                return _instance;
            }
        }
        private SunnyDay() : base(
                                    "Sunny Day",
                                    Fire.Instance,
                                    MoveCategory.Status,
                                    5,
                                    null,
                                    null)
        {
        }
    }
}