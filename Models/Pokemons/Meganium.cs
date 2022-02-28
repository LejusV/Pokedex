using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meganium Specie to store common natural stats of all Meganiums
	#region SpecieMeganium
	public class SpecieMeganium : PokemonSpecie
	{
#nullable enable
		private static SpecieMeganium? _instance = null;
#nullable restore
        public static SpecieMeganium Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeganium();
                }
                return _instance;
            }
        }

		#region SpecieMeganium Builder
		public SpecieMeganium() : base(
			"Meganium",
			80, // HPs
			82, 100, // Attack & Defense
			83, 100, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Meganium Pokemon Class
	#region Meganium
	public class Meganium : Pokemon
	{
		#region Meganium Builders
		/// <summary>
		/// Meganium Builder waiting for a Nickname & a Level
		/// </summary>
		public Meganium(string nickname, int level)
		: base(
				154,
				SpecieMeganium.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meganium Builder only waiting for a Level
		/// </summary>
		public Meganium(int level)
		: base(
				154,
				SpecieMeganium.Instance, // Pokemon Specie
				"Meganium", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meganium Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Meganium() : base(
			154,
			SpecieMeganium.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}