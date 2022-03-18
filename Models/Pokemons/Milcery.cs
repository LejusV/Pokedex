using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Milcery Species to store common natural stats of all Milcerys
	#region SpeciesMilcery
	public class SpeciesMilcery : PokemonSpecies
	{
#nullable enable
		private static SpeciesMilcery? _instance = null;
#nullable restore
        public static SpeciesMilcery Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMilcery();
                }
                return _instance;
            }
        }

		#region SpeciesMilcery Constructor
		public SpeciesMilcery() : base(
			868,
			"Milcery",
			0.2,
			0.3,
			45, // HPs
			40, 40, // Attack & Defense
			50, 61, // Special Attack & Defense
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

	//Milcery PokemonInstance Class
	#region Milcery
	public class MilceryInstance : PokemonInstance
	{
		#region Milcery Constructors
		/// <summary>
		/// Milcery Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MilceryInstance(string nickname, int level)
		: base(
				SpeciesMilcery.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milcery Builder only waiting for a Level
		/// </summary>
		public MilceryInstance(int level)
		: base(
				SpeciesMilcery.Instance, // PokemonInstance Species
				"Milcery", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Milcery Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MilceryInstance() : base(
			SpeciesMilcery.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}