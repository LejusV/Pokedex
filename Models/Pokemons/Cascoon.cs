using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cascoon Species to store common natural stats of all Cascoons
	#region SpeciesCascoon
	public class SpeciesCascoon : PokemonSpecies
	{
#nullable enable
		private static SpeciesCascoon? _instance = null;
#nullable restore
        public static SpeciesCascoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCascoon();
                }
                return _instance;
            }
        }

		#region SpeciesCascoon Constructor
		public SpeciesCascoon() : base(
			268,
			"Cascoon",
			0.7,
			11.5,
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

	//Cascoon PokemonInstance Class
	#region Cascoon
	public class CascoonInstance : PokemonInstance
	{
		#region Cascoon Constructors
		/// <summary>
		/// Cascoon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CascoonInstance(string nickname, int level)
		: base(
				SpeciesCascoon.Instance, // Pokemon Species
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cascoon Builder only waiting for a Level
		/// </summary>
		public CascoonInstance(int level)
		: base(
				SpeciesCascoon.Instance, // PokemonInstance Species
				"Cascoon", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cascoon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CascoonInstance() : base(
			SpeciesCascoon.Instance, // PokemonInstance Species
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}