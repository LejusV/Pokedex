using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Magearna Specie to store common natural stats of all Magearnas
	#region SpecieMagearna
	public class SpecieMagearna : PokemonSpecie
	{
#nullable enable
		private static SpecieMagearna? _instance = null;
#nullable restore
        public static SpecieMagearna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagearna();
                }
                return _instance;
            }
        }

		#region SpecieMagearna Builder
		public SpecieMagearna() : base(
			"Magearna",
			80, // HPs
			95, 115, // Attack & Defense
			130, 115, // Special Attack & Defense
			65		
		)
		{
			this._height = 10;
			this._weight = 805;
		}
		#endregion
	}
	#endregion

	//Magearna Pokemon Class
	#region Magearna
	public class Magearna : Pokemon
	{
		#region Magearna Builders
		/// <summary>
		/// Magearna Builder waiting for a Nickname & a Level
		/// </summary>
		public Magearna(string nickname, int level)
		: base(
				801,
				SpecieMagearna.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magearna Builder only waiting for a Level
		/// </summary>
		public Magearna(int level)
		: base(
				801,
				SpecieMagearna.Instance, // Pokemon Specie
				"Magearna", level,
				Steel.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magearna Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Magearna() : base(
			801,
			SpecieMagearna.Instance, // Pokemon Specie
			Steel.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}