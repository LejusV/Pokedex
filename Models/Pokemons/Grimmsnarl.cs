using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Grimmsnarl Species to store common natural stats of all Grimmsnarls
	#region SpeciesGrimmsnarl
	public class SpeciesGrimmsnarl : PokemonSpecies
	{
#nullable enable
		private static SpeciesGrimmsnarl? _instance = null;
#nullable restore
        public static SpeciesGrimmsnarl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGrimmsnarl();
                }
                return _instance;
            }
        }

		#region SpeciesGrimmsnarl Constructor
		public SpeciesGrimmsnarl() : base(
			861,
			"Grimmsnarl",
			1.5,
			61.0,
			95, // HPs
			120, 65, // Attack & Defense
			95, 75, // Special Attack & Defense
			60		
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
				
			};
		}
		#endregion
	}
	#endregion

	//Grimmsnarl PokemonInstance Class
	#region Grimmsnarl
	public class GrimmsnarlInstance : PokemonInstance
	{
		#region Grimmsnarl Constructors
		/// <summary>
		/// Grimmsnarl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GrimmsnarlInstance(string nickname, int level)
		: base(
				SpeciesGrimmsnarl.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimmsnarl Builder only waiting for a Level
		/// </summary>
		public GrimmsnarlInstance(int level)
		: base(
				SpeciesGrimmsnarl.Instance, // PokemonInstance Species
				"Grimmsnarl", level,
				Dark.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grimmsnarl Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GrimmsnarlInstance() : base(
			SpeciesGrimmsnarl.Instance, // PokemonInstance Species
			Dark.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}