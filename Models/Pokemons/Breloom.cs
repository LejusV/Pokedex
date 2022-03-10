using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Breloom Species to store common natural stats of all Brelooms
	#region SpeciesBreloom
	public class SpeciesBreloom : PokemonSpecies
	{
#nullable enable
		private static SpeciesBreloom? _instance = null;
#nullable restore
        public static SpeciesBreloom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesBreloom();
                }
                return _instance;
            }
        }

		#region SpeciesBreloom Constructor
		public SpeciesBreloom() : base(
			"Breloom",
			1.2,
			39.2,
			60, // HPs
			130, 80, // Attack & Defense
			60, 60, // Special Attack & Defense
			70		
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
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Absorb",
				"Mega-Drain",
				"Leech-Seed",
				"Solar-Beam",
				"Stun-Spore",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Mind-Reader",
				"Snore",
				"Protect",
				"Mach-Punch",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Synthesis",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Superpower",
				"Brick-Break",
				"Snatch",
				"Secret-Power",
				"Rock-Tomb",
				"Sky-Uppercut",
				"Bullet-Seed",
				"Bulk-Up",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Worry-Seed",
				"Force-Palm",
				"Seed-Bomb",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Stone-Edge",
				"Captivate",
				"Grass-Knot",
				"Venoshock",
				"Low-Sweep",
				"Round",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Breloom PokemonInstance Class
	#region Breloom
	public class BreloomInstance : PokemonInstance
	{
		#region Breloom Constructors
		/// <summary>
		/// Breloom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public BreloomInstance(string nickname, int level)
		: base(
				286,
				SpeciesBreloom.Instance, // Pokemon Species
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Breloom Builder only waiting for a Level
		/// </summary>
		public BreloomInstance(int level)
		: base(
				286,
				SpeciesBreloom.Instance, // PokemonInstance Species
				"Breloom", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Breloom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Breloom() : base(
			286,
			SpeciesBreloom.Instance, // PokemonInstance Species
			Grass.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}