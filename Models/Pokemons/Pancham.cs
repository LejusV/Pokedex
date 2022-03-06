using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pancham Specie to store common natural stats of all Panchams
	#region SpeciePancham
	public class SpeciePancham : PokemonSpecie
	{
#nullable enable
		private static SpeciePancham? _instance = null;
#nullable restore
        public static SpeciePancham Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePancham();
                }
                return _instance;
            }
        }

		#region SpeciePancham Builder
		public SpeciePancham() : base(
			"Pancham",
			67, // HPs
			82, 62, // Attack & Defense
			46, 48, // Special Attack & Defense
			43		
		)
		{
			this._height = 6;
			this._weight = 80;
		}
		#endregion
	}
	#endregion

	//Pancham Pokemon Class
	#region Pancham
	public class Pancham : Pokemon
	{
		#region Pancham Builders
		/// <summary>
		/// Pancham Builder waiting for a Nickname & a Level
		/// </summary>
		public Pancham(string nickname, int level)
		: base(
				674,
				SpeciePancham.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pancham Builder only waiting for a Level
		/// </summary>
		public Pancham(int level)
		: base(
				674,
				SpeciePancham.Instance, // Pokemon Specie
				"Pancham", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pancham Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pancham() : base(
			674,
			SpeciePancham.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}