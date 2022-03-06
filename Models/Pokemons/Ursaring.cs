using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ursaring Specie to store common natural stats of all Ursarings
	#region SpecieUrsaring
	public class SpecieUrsaring : PokemonSpecie
	{
#nullable enable
		private static SpecieUrsaring? _instance = null;
#nullable restore
        public static SpecieUrsaring Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUrsaring();
                }
                return _instance;
            }
        }

		#region SpecieUrsaring Builder
		public SpecieUrsaring() : base(
			"Ursaring",
			1.8,
			125.8,
			90, // HPs
			130, 75, // Attack & Defense
			75, 75, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Ursaring Pokemon Class
	#region Ursaring
	public class Ursaring : Pokemon
	{
		#region Ursaring Builders
		/// <summary>
		/// Ursaring Builder waiting for a Nickname & a Level
		/// </summary>
		public Ursaring(string nickname, int level)
		: base(
				217,
				SpecieUrsaring.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ursaring Builder only waiting for a Level
		/// </summary>
		public Ursaring(int level)
		: base(
				217,
				SpecieUrsaring.Instance, // Pokemon Specie
				"Ursaring", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ursaring Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ursaring() : base(
			217,
			SpecieUrsaring.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}