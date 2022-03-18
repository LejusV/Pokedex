using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mawile Species to store common natural stats of all Mawiles
	#region SpeciesMawile
	public class SpeciesMawile : PokemonSpecies
	{
#nullable enable
		private static SpeciesMawile? _instance = null;
#nullable restore
        public static SpeciesMawile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMawile();
                }
                return _instance;
            }
        }

		#region SpeciesMawile Constructor
		public SpeciesMawile() : base(
			303,
			"Mawile",
			0.6,
			11.5,
			50, // HPs
			85, 85, // Attack & Defense
			55, 55, // Special Attack & Defense
			50		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Mega-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Vice-Grip",
				"Swords-Dance",
				"Slam",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Growl",
				"Flamethrower",
				"Ice-Beam",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Baton-Pass",
				"Sweet-Scent",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Poison-Fang",
				"Astonish",
				"Fake-Tears",
				"Rock-Tomb",
				"Tickle",
				"Iron-Defense",
				"Natural-Gift",
				"Metal-Burst",
				"Payback",
				"Embargo",
				"Fling",
				"Guard-Swap",
				"Punishment",
				"Last-Resort",
				"Sucker-Punch",
				"Magnet-Rise",
				"Dark-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Flash-Cannon",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Misty-Terrain",
				"Play-Rough",
				"Fairy-Wind",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Mawile PokemonInstance Class
	#region Mawile
	public class MawileInstance : PokemonInstance
	{
		#region Mawile Constructors
		/// <summary>
		/// Mawile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MawileInstance(string nickname, int level)
		: base(
				SpeciesMawile.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mawile Builder only waiting for a Level
		/// </summary>
		public MawileInstance(int level)
		: base(
				SpeciesMawile.Instance, // PokemonInstance Species
				"Mawile", level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mawile Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MawileInstance() : base(
			SpeciesMawile.Instance, // PokemonInstance Species
			Steel.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}