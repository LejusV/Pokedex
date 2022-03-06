using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Audino Specie to store common natural stats of all Audinos
	#region SpecieAudino
	public class SpecieAudino : PokemonSpecie
	{
#nullable enable
		private static SpecieAudino? _instance = null;
#nullable restore
        public static SpecieAudino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAudino();
                }
                return _instance;
            }
        }

		#region SpecieAudino Builder
		public SpecieAudino() : base(
			"Audino",
			1.1,
			31.0,
			103, // HPs
			60, 86, // Attack & Defense
			60, 86, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Audino Pokemon Class
	#region Audino
	public class Audino : Pokemon
	{
		#region Audino Builders
		/// <summary>
		/// Audino Builder waiting for a Nickname & a Level
		/// </summary>
		public Audino(string nickname, int level)
		: base(
				531,
				SpecieAudino.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Audino Builder only waiting for a Level
		/// </summary>
		public Audino(int level)
		: base(
				531,
				SpecieAudino.Instance, // Pokemon Specie
				"Audino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Audino Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Audino() : base(
			531,
			SpecieAudino.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}