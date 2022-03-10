using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grimer Species to store common natural stats of all Grimers
	#region SpeciesGrimer
	public class SpeciesGrimer : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrimer? _instance = null;
#nullable restore
        public static SpeciesGrimer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrimer();
                }
                return _instance;
            }
        }

		#region SpeciesGrimer Constructor
		public SpeciesGrimer() : base(
			"Grimer",
			0.9,
			30.0,
			80, // HPs
			80, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			25		
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
				"Body-Slam",
				"Disable",
				"Flamethrower",
				"Strength",
				"Mega-Drain",
				"Thunderbolt",
				"Thunder",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Harden",
				"Minimize",
				"Haze",
				"Bide",
				"Self-Destruct",
				"Lick",
				"Sludge",
				"Fire-Blast",
				"Poison-Gas",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Sludge-Bomb",
				"Mud-Slap",
				"Zap-Cannon",
				"Giga-Drain",
				"Endure",
				"Swagger",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Stockpile",
				"Spit-Up",
				"Swallow",
				"Torment",
				"Memento",
				"Facade",
				"Taunt",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Shadow-Punch",
				"Shock-Wave",
				"Natural-Gift",
				"Payback",
				"Fling",
				"Poison-Jab",
				"Shadow-Sneak",
				"Mud-Bomb",
				"Gunk-Shot",
				"Captivate",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Incinerate",
				"Belch",
				"Confide",
				"Infestation",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Grimer PokemonInstance Class
	#region Grimer
	public class GrimerInstance : PokemonInstance
	{
		#region Grimer Constructors
		/// <summary>
		/// Grimer Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrimerInstance(string nickname, int level)
		: base(
				88,
				SpeciesGrimer.Instance, // Pokemon Species
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimer Builder only waiting for a Level
		/// </summary>
		public GrimerInstance(int level)
		: base(
				88,
				SpeciesGrimer.Instance, // PokemonInstance Species
				"Grimer", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimer Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Grimer() : base(
			88,
			SpeciesGrimer.Instance, // PokemonInstance Species
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}