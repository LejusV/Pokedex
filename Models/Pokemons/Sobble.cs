using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sobble Species to store common natural stats of all Sobbles
	#region SpeciesSobble
	public class SpeciesSobble : PokemonSpecies
	{
#nullable enable
		private static SpeciesSobble? _instance = null;
#nullable restore
        public static SpeciesSobble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSobble();
                }
                return _instance;
            }
        }

		#region SpeciesSobble Constructor
		public SpeciesSobble() : base(
			816,
			"Sobble",
			0.3,
			4.0,
			50, // HPs
			40, 40, // Attack & Defense
			70, 40, // Special Attack & Defense
			70		
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

	//Sobble PokemonInstance Class
	#region Sobble
	public class SobbleInstance : PokemonInstance
	{
		#region Sobble Constructors
		/// <summary>
		/// Sobble Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SobbleInstance(string nickname, int level)
		: base(
				SpeciesSobble.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sobble Builder only waiting for a Level
		/// </summary>
		public SobbleInstance(int level)
		: base(
				SpeciesSobble.Instance, // PokemonInstance Species
				"Sobble", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sobble Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SobbleInstance() : base(
			SpeciesSobble.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}