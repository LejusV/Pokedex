using System.Collections.Generic;
using Pokedex.Enums;
using Pokedex.Models.Types;

namespace Pokedex.Models.Moves.Categories
{
#nullable enable    
    internal class DefenseCurl : Move
    {
        private static DefenseCurl? _instance = null;
        public static DefenseCurl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DefenseCurl();
                }
                return _instance;
            }
        }
        private DefenseCurl() : base(
                                    "Defense Curl",
                                    Normal.Instance,
                                    MoveCategory.Status,
                                    40)
        {}
    }
    
    internal class Endure : Move
    {
        private static Endure? _instance = null;
        public static Endure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Endure();
                }
                return _instance;
            }
        }
        private Endure() : base(
                                "Endure",
                                Normal.Instance,
                                MoveCategory.Status,
                                10
                               )
        {
        }
    }

    internal class Growl : Move
    {
        private static Growl? _instance = null;
        public static Growl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Growl();
                }
                return _instance;
            }
        }
        private Growl() : base(
                                    "Growl",
                                    Normal.Instance,
                                    MoveCategory.Status,
                                    40, null, 1
                               )
        {}
    }
    
    internal class Mimic : Move
    {
        private static Mimic? _instance = null;
        public static Mimic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Mimic();
                }
                return _instance;
            }
        }
        private Mimic() : base("Mimic",
                                Normal.Instance,
                                MoveCategory.Status,
                                10)
        {}
    }

    internal class Screech : Move
    {
        private static Screech? _instance = null;
        public static Screech Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Screech();
                }
                return _instance;
            }
        }
        private Screech() : base("Screech",
                                        Normal.Instance,
                                        MoveCategory.Status,
                                        40, null, 0.85)
        { }
    }
    
    internal class TailWhip : Move
    {
        private static TailWhip? _instance = null;
        public static TailWhip Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TailWhip();
                }
                return _instance;
            }
        }
        private TailWhip() : base("Tail Whip",
                                    Normal.Instance,
                                    MoveCategory.Status,
                                    30, null, 1)
        { }
    }
}
