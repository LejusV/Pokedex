using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Weedle Species to store common natural stats of all Weedles
	#region SpeciesWeedle
	public class SpeciesWeedle : PokemonSpecies
	{
#nullable enable
		private static SpeciesWeedle? _instance = null;
#nullable restore
        public static SpeciesWeedle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesWeedle();
                }
                return _instance;
            }
        }

		#region SpeciesWeedle Constructor
		public SpeciesWeedle() : base(
			13,
			"Weedle",
			0.3,
			3.2,
			40, // HPs
			35, 30, // Attack & Defense
			20, 20, // Special Attack & Defense
			50		
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
				"Poison-Sting",
				"String-Shot",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Weedle PokemonInstance Class
	#region Weedle
	public class WeedleInstance : PokemonInstance
	{
		#region Weedle Constructors
		/// <summary>
		/// Weedle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public WeedleInstance(string nickname, int level)
		: base(
				SpeciesWeedle.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weedle Builder only waiting for a Level
		/// </summary>
		public WeedleInstance(int level)
		: base(
				SpeciesWeedle.Instance, // PokemonInstance Species
				"Weedle", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Weedle Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public WeedleInstance() : base(
			SpeciesWeedle.Instance, // PokemonInstance Species
			Bug.Instance, Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}