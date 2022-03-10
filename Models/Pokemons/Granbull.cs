using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Granbull Species to store common natural stats of all Granbulls
	#region SpeciesGranbull
	public class SpeciesGranbull : PokemonSpecies
	{
#nullable enable
		private static SpeciesGranbull? _instance = null;
#nullable restore
        public static SpeciesGranbull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGranbull();
                }
                return _instance;
            }
        }

		#region SpeciesGranbull Constructor
		public SpeciesGranbull() : base(
			"Granbull",
			1.4,
			48.7,
			90, // HPs
			120, 75, // Attack & Defense
			60, 60, // Special Attack & Defense
			45		
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
				"Bite",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
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
				"Rock-Slide",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Outrage",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Rock-Tomb",
				"Bulk-Up",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Last-Resort",
				"Focus-Blast",
				"Giga-Impact",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Rock-Climb",
				"Stone-Edge",
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

	//Granbull PokemonInstance Class
	#region Granbull
	public class GranbullInstance : PokemonInstance
	{
		#region Granbull Constructors
		/// <summary>
		/// Granbull Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GranbullInstance(string nickname, int level)
		: base(
				210,
				SpeciesGranbull.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Granbull Builder only waiting for a Level
		/// </summary>
		public GranbullInstance(int level)
		: base(
				210,
				SpeciesGranbull.Instance, // PokemonInstance Species
				"Granbull", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Granbull Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Granbull() : base(
			210,
			SpeciesGranbull.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}