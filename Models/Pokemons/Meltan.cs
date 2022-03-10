using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Meltan Species to store common natural stats of all Meltans
	#region SpeciesMeltan
	public class SpeciesMeltan : PokemonSpecies
	{
#nullable enable
		private static SpeciesMeltan? _instance = null;
#nullable restore
        public static SpeciesMeltan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMeltan();
                }
                return _instance;
            }
        }

		#region SpeciesMeltan Constructor
		public SpeciesMeltan() : base(
			"Meltan",
			0.2,
			8.0,
			46, // HPs
			65, 65, // Attack & Defense
			55, 35, // Special Attack & Defense
			34		
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

	//Meltan PokemonInstance Class
	#region Meltan
	public class MeltanInstance : PokemonInstance
	{
		#region Meltan Constructors
		/// <summary>
		/// Meltan Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MeltanInstance(string nickname, int level)
		: base(
				808,
				SpeciesMeltan.Instance, // Pokemon Species
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meltan Builder only waiting for a Level
		/// </summary>
		public MeltanInstance(int level)
		: base(
				808,
				SpeciesMeltan.Instance, // PokemonInstance Species
				"Meltan", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meltan Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Meltan() : base(
			808,
			SpeciesMeltan.Instance, // PokemonInstance Species
			Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}