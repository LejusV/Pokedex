using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Mantyke Specie to store common natural stats of all Mantykes
	#region SpecieMantyke
	public class SpecieMantyke : PokemonSpecie
	{
#nullable enable
		private static SpecieMantyke? _instance = null;
#nullable restore
        public static SpecieMantyke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMantyke();
                }
                return _instance;
            }
        }

		#region SpecieMantyke Builder
		public SpecieMantyke() : base(
			"Mantyke",
			45, // HPs
			20, 50, // Attack & Defense
			60, 120, // Special Attack & Defense
			50		
		)
		{
			this._height = 10;
			this._weight = 650;
		}
		#endregion
	}
	#endregion

	//Mantyke Pokemon Class
	#region Mantyke
	public class Mantyke : Pokemon
	{
		#region Mantyke Builders
		/// <summary>
		/// Mantyke Builder waiting for a Nickname & a Level
		/// </summary>
		public Mantyke(string nickname, int level)
		: base(
				458,
				SpecieMantyke.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantyke Builder only waiting for a Level
		/// </summary>
		public Mantyke(int level)
		: base(
				458,
				SpecieMantyke.Instance, // Pokemon Specie
				"Mantyke", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantyke Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Mantyke() : base(
			458,
			SpecieMantyke.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}