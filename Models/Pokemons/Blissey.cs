using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Blissey Species to store common natural stats of all Blisseys
	#region SpeciesBlissey
	public class SpeciesBlissey : PokemonSpecies
	{
#nullable enable
		private static SpeciesBlissey? _instance = null;
#nullable restore
        public static SpeciesBlissey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBlissey();
                }
                return _instance;
            }
        }

		#region SpeciesBlissey Constructor
		public SpeciesBlissey() : base(
			"Blissey",
			1.5,
			46.8,
			255, // HPs
			10, 10, // Attack & Defense
			75, 135, // Special Attack & Defense
			55		
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
				"Pound",
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Growl",
				"Sing",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Minimize",
				"Defense-Curl",
				"Light-Screen",
				"Metronome",
				"Egg-Bomb",
				"Fire-Blast",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Recycle",
				"Brick-Break",
				"Endeavor",
				"Skill-Swap",
				"Refresh",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Block",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Last-Resort",
				"Drain-Punch",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Blissey PokemonInstance Class
	#region Blissey
	public class BlisseyInstance : PokemonInstance
	{
		#region Blissey Constructors
		/// <summary>
		/// Blissey Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BlisseyInstance(string nickname, int level)
		: base(
				242,
				SpeciesBlissey.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blissey Builder only waiting for a Level
		/// </summary>
		public BlisseyInstance(int level)
		: base(
				242,
				SpeciesBlissey.Instance, // PokemonInstance Species
				"Blissey", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blissey Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Blissey() : base(
			242,
			SpeciesBlissey.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}