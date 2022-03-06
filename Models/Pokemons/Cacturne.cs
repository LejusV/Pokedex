using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cacturne Specie to store common natural stats of all Cacturnes
	#region SpecieCacturne
	public class SpecieCacturne : PokemonSpecie
	{
#nullable enable
		private static SpecieCacturne? _instance = null;
#nullable restore
        public static SpecieCacturne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCacturne();
                }
                return _instance;
            }
        }

		#region SpecieCacturne Builder
		public SpecieCacturne() : base(
			"Cacturne",
			1.3,
			77.4,
			70, // HPs
			115, 60, // Attack & Defense
			115, 60, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Cacturne Pokemon Class
	#region Cacturne
	public class Cacturne : Pokemon
	{
		#region Cacturne Builders
		/// <summary>
		/// Cacturne Builder waiting for a Nickname & a Level
		/// </summary>
		public Cacturne(string nickname, int level)
		: base(
				332,
				SpecieCacturne.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacturne Builder only waiting for a Level
		/// </summary>
		public Cacturne(int level)
		: base(
				332,
				SpecieCacturne.Instance, // Pokemon Specie
				"Cacturne", level,
				Grass.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cacturne Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cacturne() : base(
			332,
			SpecieCacturne.Instance, // Pokemon Specie
			Grass.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}