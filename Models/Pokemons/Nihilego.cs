using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Nihilego Species to store common natural stats of all Nihilegos
	#region SpeciesNihilego
	public class SpeciesNihilego : PokemonSpecies
	{
#nullable enable
		private static SpeciesNihilego? _instance = null;
#nullable restore
        public static SpeciesNihilego Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesNihilego();
                }
                return _instance;
            }
        }

		#region SpeciesNihilego Constructor
		public SpeciesNihilego() : base(
			793,
			"Nihilego",
			1.2,
			55.5,
			109, // HPs
			53, 47, // Attack & Defense
			127, 131, // Special Attack & Defense
			103		
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
				"Headbutt",
				"Acid",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Constrict",
				"Psywave",
				"Rest",
				"Substitute",
				"Protect",
				"Sludge-Bomb",
				"Sandstorm",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Mirror-Coat",
				"Facade",
				"Tickle",
				"Toxic-Spikes",
				"Poison-Jab",
				"Power-Gem",
				"Trick-Room",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Head-Smash",
				"Guard-Split",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Venoshock",
				"Sludge-Wave",
				"Acid-Spray",
				"Round",
				"Echoed-Voice",
				"Clear-Smog",
				"Confide",
				"Venom-Drench",
				"Dazzling-Gleam",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Nihilego PokemonInstance Class
	#region Nihilego
	public class NihilegoInstance : PokemonInstance
	{
		#region Nihilego Constructors
		/// <summary>
		/// Nihilego Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public NihilegoInstance(string nickname, int level)
		: base(
				SpeciesNihilego.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nihilego Builder only waiting for a Level
		/// </summary>
		public NihilegoInstance(int level)
		: base(
				SpeciesNihilego.Instance, // PokemonInstance Species
				"Nihilego", level,
				Rock.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nihilego Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public NihilegoInstance() : base(
			SpeciesNihilego.Instance, // PokemonInstance Species
			Rock.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}