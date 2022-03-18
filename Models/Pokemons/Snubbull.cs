using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Snubbull Species to store common natural stats of all Snubbulls
	#region SpeciesSnubbull
	public class SpeciesSnubbull : PokemonSpecies
	{
#nullable enable
		private static SpeciesSnubbull? _instance = null;
#nullable restore
        public static SpeciesSnubbull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSnubbull();
                }
                return _instance;
            }
        }

		#region SpeciesSnubbull Constructor
		public SpeciesSnubbull() : base(
			209,
			"Snubbull",
			0.6,
			7.8,
			60, // HPs
			80, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			30		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Tail-Whip",
				"Leer",
				"Bite",
				"Roar",
				"Flamethrower",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Reflect",
				"Metronome",
				"Lick",
				"Fire-Blast",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Smelling-Salts",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Fake-Tears",
				"Overheat",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Close-Combat",
				"Payback",
				"Fling",
				"Last-Resort",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Captivate",
				"Round",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Play-Rough",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Snubbull PokemonInstance Class
	#region Snubbull
	public class SnubbullInstance : PokemonInstance
	{
		#region Snubbull Constructors
		/// <summary>
		/// Snubbull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SnubbullInstance(string nickname, int level)
		: base(
				SpeciesSnubbull.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snubbull Builder only waiting for a Level
		/// </summary>
		public SnubbullInstance(int level)
		: base(
				SpeciesSnubbull.Instance, // PokemonInstance Species
				"Snubbull", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snubbull Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SnubbullInstance() : base(
			SpeciesSnubbull.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}