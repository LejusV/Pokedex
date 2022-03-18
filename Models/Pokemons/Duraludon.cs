using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Duraludon Species to store common natural stats of all Duraludons
	#region SpeciesDuraludon
	public class SpeciesDuraludon : PokemonSpecies
	{
#nullable enable
		private static SpeciesDuraludon? _instance = null;
#nullable restore
        public static SpeciesDuraludon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDuraludon();
                }
                return _instance;
            }
        }

		#region SpeciesDuraludon Constructor
		public SpeciesDuraludon() : base(
			884,
			"Duraludon",
			1.8,
			40.0,
			70, // HPs
			95, 115, // Attack & Defense
			120, 50, // Special Attack & Defense
			85		
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

	//Duraludon PokemonInstance Class
	#region Duraludon
	public class DuraludonInstance : PokemonInstance
	{
		#region Duraludon Constructors
		/// <summary>
		/// Duraludon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DuraludonInstance(string nickname, int level)
		: base(
				SpeciesDuraludon.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duraludon Builder only waiting for a Level
		/// </summary>
		public DuraludonInstance(int level)
		: base(
				SpeciesDuraludon.Instance, // PokemonInstance Species
				"Duraludon", level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duraludon Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DuraludonInstance() : base(
			SpeciesDuraludon.Instance, // PokemonInstance Species
			Steel.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}