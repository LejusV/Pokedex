using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chingling Specie to store common natural stats of all Chinglings
	#region SpecieChingling
	public class SpecieChingling : PokemonSpecie
	{
#nullable enable
		private static SpecieChingling? _instance = null;
#nullable restore
        public static SpecieChingling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChingling();
                }
                return _instance;
            }
        }

		#region SpecieChingling Builder
		public SpecieChingling() : base(
			"Chingling",
			0.2,
			0.6,
			45, // HPs
			30, 50, // Attack & Defense
			65, 50, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Chingling Pokemon Class
	#region Chingling
	public class Chingling : Pokemon
	{
		#region Chingling Builders
		/// <summary>
		/// Chingling Builder waiting for a Nickname & a Level
		/// </summary>
		public Chingling(string nickname, int level)
		: base(
				433,
				SpecieChingling.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chingling Builder only waiting for a Level
		/// </summary>
		public Chingling(int level)
		: base(
				433,
				SpecieChingling.Instance, // Pokemon Specie
				"Chingling", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chingling Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chingling() : base(
			433,
			SpecieChingling.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}