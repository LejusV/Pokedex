using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Trevenant Species to store common natural stats of all Trevenants
	#region SpeciesTrevenant
	public class SpeciesTrevenant : PokemonSpecies
	{
#nullable enable
		private static SpeciesTrevenant? _instance = null;
#nullable restore
        public static SpeciesTrevenant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTrevenant();
                }
                return _instance;
            }
        }

		#region SpeciesTrevenant Constructor
		public SpeciesTrevenant() : base(
			709,
			"Trevenant",
			1.5,
			71.0,
			85, // HPs
			110, 76, // Attack & Defense
			65, 82, // Special Attack & Defense
			56		
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
				"Hyper-Beam",
				"Strength",
				"Leech-Seed",
				"Growth",
				"Solar-Beam",
				"Earthquake",
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
				"Secret-Power",
				"Astonish",
				"Block",
				"Calm-Mind",
				"Worry-Seed",
				"Poison-Jab",
				"Dark-Pulse",
				"Seed-Bomb",
				"X-Scissor",
				"Drain-Punch",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Trick-Room",
				"Grass-Knot",
				"Wood-Hammer",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Bulldoze",
				"Horn-Leech",
				"Phantom-Force",
				"Forests-Curse",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Trevenant PokemonInstance Class
	#region Trevenant
	public class TrevenantInstance : PokemonInstance
	{
		#region Trevenant Constructors
		/// <summary>
		/// Trevenant Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TrevenantInstance(string nickname, int level)
		: base(
				SpeciesTrevenant.Instance, // Pokemon Species
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trevenant Builder only waiting for a Level
		/// </summary>
		public TrevenantInstance(int level)
		: base(
				SpeciesTrevenant.Instance, // PokemonInstance Species
				"Trevenant", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Trevenant Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TrevenantInstance() : base(
			SpeciesTrevenant.Instance, // PokemonInstance Species
			Ghost.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}