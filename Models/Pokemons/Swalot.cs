using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Swalot Species to store common natural stats of all Swalots
	#region SpeciesSwalot
	public class SpeciesSwalot : PokemonSpecies
	{
#nullable enable
		private static SpeciesSwalot? _instance = null;
#nullable restore
        public static SpeciesSwalot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSwalot();
                }
                return _instance;
            }
        }

		#region SpeciesSwalot Constructor
		public SpeciesSwalot() : base(
			"Swalot",
			1.7,
			80.0,
			100, // HPs
			73, 83, // Attack & Defense
			73, 83, // Special Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Self-Destruct",
				"Sludge",
				"Amnesia",
				"Dream-Eater",
				"Poison-Gas",
				"Explosion",
				"Rest",
				"Substitute",
				"Nightmare",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Mud-Slap",
				"Giga-Drain",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Facade",
				"Yawn",
				"Snatch",
				"Secret-Power",
				"Bullet-Seed",
				"Block",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Wring-Out",
				"Gastro-Acid",
				"Seed-Bomb",
				"Giga-Impact",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Bulldoze",
				"Belch",
				"Confide",
				"Venom-Drench",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Swalot PokemonInstance Class
	#region Swalot
	public class SwalotInstance : PokemonInstance
	{
		#region Swalot Constructors
		/// <summary>
		/// Swalot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SwalotInstance(string nickname, int level)
		: base(
				317,
				SpeciesSwalot.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swalot Builder only waiting for a Level
		/// </summary>
		public SwalotInstance(int level)
		: base(
				317,
				SpeciesSwalot.Instance, // PokemonInstance Species
				"Swalot", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swalot Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Swalot() : base(
			317,
			SpeciesSwalot.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}