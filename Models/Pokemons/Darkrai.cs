using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Darkrai Specie to store common natural stats of all Darkrais
	#region SpecieDarkrai
	public class SpecieDarkrai : PokemonSpecie
	{
#nullable enable
		private static SpecieDarkrai? _instance = null;
#nullable restore
        public static SpecieDarkrai Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDarkrai();
                }
                return _instance;
            }
        }

		#region SpecieDarkrai Builder
		public SpecieDarkrai() : base(
			"Darkrai",
			70, // HPs
			90, 90, // Attack & Defense
			135, 90, // Special Attack & Defense
			125		
		)
		{
			this._height = 15;
			this._weight = 505;
		}
		#endregion
	}
	#endregion

	//Darkrai Pokemon Class
	#region Darkrai
	public class Darkrai : Pokemon
	{
		#region Darkrai Builders
		/// <summary>
		/// Darkrai Builder waiting for a Nickname & a Level
		/// </summary>
		public Darkrai(string nickname, int level)
		: base(
				491,
				SpecieDarkrai.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darkrai Builder only waiting for a Level
		/// </summary>
		public Darkrai(int level)
		: base(
				491,
				SpecieDarkrai.Instance, // Pokemon Specie
				"Darkrai", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darkrai Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Darkrai() : base(
			491,
			SpecieDarkrai.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}