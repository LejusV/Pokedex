using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ribombee Species to store common natural stats of all Ribombees
	#region SpeciesRibombee
	public class SpeciesRibombee : PokemonSpecies
	{
#nullable enable
		private static SpeciesRibombee? _instance = null;
#nullable restore
        public static SpeciesRibombee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesRibombee();
                }
                return _instance;
            }
        }

		#region SpeciesRibombee Constructor
		public SpeciesRibombee() : base(
			"Ribombee",
			0.2,
			0.5,
			60, // HPs
			55, 60, // Attack & Defense
			95, 70, // Special Attack & Defense
			124		
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
				"Absorb",
				"Solar-Beam",
				"Stun-Spore",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Sweet-Scent",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Facade",
				"Nature-Power",
				"Aromatherapy",
				"Silver-Wind",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"U-Turn",
				"Bug-Buzz",
				"Energy-Ball",
				"Quiver-Dance",
				"Round",
				"Acrobatics",
				"Struggle-Bug",
				"Draining-Kiss",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Infestation",
				"Pollen-Puff"
			};
		}
		#endregion
	}
	#endregion

	//Ribombee PokemonInstance Class
	#region Ribombee
	public class RibombeeInstance : PokemonInstance
	{
		#region Ribombee Constructors
		/// <summary>
		/// Ribombee Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public RibombeeInstance(string nickname, int level)
		: base(
				743,
				SpeciesRibombee.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ribombee Builder only waiting for a Level
		/// </summary>
		public RibombeeInstance(int level)
		: base(
				743,
				SpeciesRibombee.Instance, // PokemonInstance Species
				"Ribombee", level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ribombee Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ribombee() : base(
			743,
			SpeciesRibombee.Instance, // PokemonInstance Species
			Bug.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}