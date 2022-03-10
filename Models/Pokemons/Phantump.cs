using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Phantump Species to store common natural stats of all Phantumps
	#region SpeciesPhantump
	public class SpeciesPhantump : PokemonSpecies
	{
#nullable enable
		private static SpeciesPhantump? _instance = null;
#nullable restore
        public static SpeciesPhantump Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPhantump();
                }
                return _instance;
            }
        }

		#region SpeciesPhantump Constructor
		public SpeciesPhantump() : base(
			"Phantump",
			0.4,
			7.0,
			43, // HPs
			70, 48, // Attack & Defense
			50, 60, // Special Attack & Defense
			38		
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
				"Cut",
				"Tackle",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Dig",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Confuse-Ray",
				"Reflect",
				"Dream-Eater",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Destiny-Bond",
				"Giga-Drain",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Will-O-Wisp",
				"Facade",
				"Nature-Power",
				"Trick",
				"Role-Play",
				"Ingrain",
				"Magic-Coat",
				"Skill-Swap",
				"Imprison",
				"Grudge",
				"Secret-Power",
				"Astonish",
				"Worry-Seed",
				"Poison-Jab",
				"Dark-Pulse",
				"Seed-Bomb",
				"Energy-Ball",
				"Shadow-Claw",
				"Trick-Room",
				"Grass-Knot",
				"Wood-Hammer",
				"Foul-Play",
				"Round",
				"Bestow",
				"Bulldoze",
				"Horn-Leech",
				"Phantom-Force",
				"Forests-Curse",
				"Confide",
				"Venom-Drench",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Phantump PokemonInstance Class
	#region Phantump
	public class PhantumpInstance : PokemonInstance
	{
		#region Phantump Constructors
		/// <summary>
		/// Phantump Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PhantumpInstance(string nickname, int level)
		: base(
				708,
				SpeciesPhantump.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phantump Builder only waiting for a Level
		/// </summary>
		public PhantumpInstance(int level)
		: base(
				708,
				SpeciesPhantump.Instance, // PokemonInstance Species
				"Phantump", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phantump Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Phantump() : base(
			708,
			SpeciesPhantump.Instance, // PokemonInstance Species
			Ghost.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}