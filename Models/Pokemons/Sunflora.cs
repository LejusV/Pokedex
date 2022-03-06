using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sunflora Specie to store common natural stats of all Sunfloras
	#region SpecieSunflora
	public class SpecieSunflora : PokemonSpecie
	{
#nullable enable
		private static SpecieSunflora? _instance = null;
#nullable restore
        public static SpecieSunflora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSunflora();
                }
                return _instance;
            }
        }

		#region SpecieSunflora Builder
		public SpecieSunflora() : base(
			"Sunflora",
			75, // HPs
			75, 55, // Attack & Defense
			105, 85, // Special Attack & Defense
			30		
		)
		{
			this._height = 8;
			this._weight = 85;
		}
		#endregion
	}
	#endregion

	//Sunflora Pokemon Class
	#region Sunflora
	public class Sunflora : Pokemon
	{
		#region Sunflora Builders
		/// <summary>
		/// Sunflora Builder waiting for a Nickname & a Level
		/// </summary>
		public Sunflora(string nickname, int level)
		: base(
				192,
				SpecieSunflora.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunflora Builder only waiting for a Level
		/// </summary>
		public Sunflora(int level)
		: base(
				192,
				SpecieSunflora.Instance, // Pokemon Specie
				"Sunflora", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sunflora Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sunflora() : base(
			192,
			SpecieSunflora.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}