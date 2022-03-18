using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Silcoon Species to store common natural stats of all Silcoons
	#region SpeciesSilcoon
	public class SpeciesSilcoon : PokemonSpecies
	{
#nullable enable
		private static SpeciesSilcoon? _instance = null;
#nullable restore
        public static SpeciesSilcoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSilcoon();
                }
                return _instance;
            }
        }

		#region SpeciesSilcoon Constructor
		public SpeciesSilcoon() : base(
			266,
			"Silcoon",
			0.6,
			10.0,
			50, // HPs
			35, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			15		
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
				"String-Shot",
				"Harden",
				"Iron-Defense",
				"Bug-Bite",
				"Electroweb"
			};
		}
		#endregion
	}
	#endregion

	//Silcoon PokemonInstance Class
	#region Silcoon
	public class SilcoonInstance : PokemonInstance
	{
		#region Silcoon Constructors
		/// <summary>
		/// Silcoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SilcoonInstance(string nickname, int level)
		: base(
				SpeciesSilcoon.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silcoon Builder only waiting for a Level
		/// </summary>
		public SilcoonInstance(int level)
		: base(
				SpeciesSilcoon.Instance, // PokemonInstance Species
				"Silcoon", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silcoon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SilcoonInstance() : base(
			SpeciesSilcoon.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}