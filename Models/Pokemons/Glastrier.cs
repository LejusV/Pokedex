using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Glastrier Specie to store common natural stats of all Glastriers
	#region SpecieGlastrier
	public class SpecieGlastrier : PokemonSpecie
	{
#nullable enable
		private static SpecieGlastrier? _instance = null;
#nullable restore
        public static SpecieGlastrier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlastrier();
                }
                return _instance;
            }
        }

		#region SpecieGlastrier Builder
		public SpecieGlastrier() : base(
			"Glastrier",
			2.2,
			800.0,
			100, // HPs
			145, 130, // Attack & Defense
			65, 110, // Special Attack & Defense
			30		
		)
		{}
		#endregion
	}
	#endregion

	//Glastrier Pokemon Class
	#region Glastrier
	public class Glastrier : Pokemon
	{
		#region Glastrier Builders
		/// <summary>
		/// Glastrier Builder waiting for a Nickname & a Level
		/// </summary>
		public Glastrier(string nickname, int level)
		: base(
				896,
				SpecieGlastrier.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glastrier Builder only waiting for a Level
		/// </summary>
		public Glastrier(int level)
		: base(
				896,
				SpecieGlastrier.Instance, // Pokemon Specie
				"Glastrier", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Glastrier Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Glastrier() : base(
			896,
			SpecieGlastrier.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}