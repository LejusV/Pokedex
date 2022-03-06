using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ducklett Specie to store common natural stats of all Duckletts
	#region SpecieDucklett
	public class SpecieDucklett : PokemonSpecie
	{
#nullable enable
		private static SpecieDucklett? _instance = null;
#nullable restore
        public static SpecieDucklett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDucklett();
                }
                return _instance;
            }
        }

		#region SpecieDucklett Builder
		public SpecieDucklett() : base(
			"Ducklett",
			0.5,
			5.5,
			62, // HPs
			44, 50, // Attack & Defense
			44, 50, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Ducklett Pokemon Class
	#region Ducklett
	public class Ducklett : Pokemon
	{
		#region Ducklett Builders
		/// <summary>
		/// Ducklett Builder waiting for a Nickname & a Level
		/// </summary>
		public Ducklett(string nickname, int level)
		: base(
				580,
				SpecieDucklett.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ducklett Builder only waiting for a Level
		/// </summary>
		public Ducklett(int level)
		: base(
				580,
				SpecieDucklett.Instance, // Pokemon Specie
				"Ducklett", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ducklett Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ducklett() : base(
			580,
			SpecieDucklett.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}