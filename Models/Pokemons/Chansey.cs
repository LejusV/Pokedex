using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chansey Specie to store common natural stats of all Chanseys
	#region SpecieChansey
	public class SpecieChansey : PokemonSpecie
	{
#nullable enable
		private static SpecieChansey? _instance = null;
#nullable restore
        public static SpecieChansey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChansey();
                }
                return _instance;
            }
        }

		#region SpecieChansey Builder
		public SpecieChansey() : base(
			"Chansey",
			1.1,
			34.6,
			250, // HPs
			5, 5, // Attack & Defense
			35, 105, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Chansey Pokemon Class
	#region Chansey
	public class Chansey : Pokemon
	{
		#region Chansey Builders
		/// <summary>
		/// Chansey Builder waiting for a Nickname & a Level
		/// </summary>
		public Chansey(string nickname, int level)
		: base(
				113,
				SpecieChansey.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chansey Builder only waiting for a Level
		/// </summary>
		public Chansey(int level)
		: base(
				113,
				SpecieChansey.Instance, // Pokemon Specie
				"Chansey", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chansey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chansey() : base(
			113,
			SpecieChansey.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}