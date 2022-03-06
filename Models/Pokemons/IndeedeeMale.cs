using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Indeedee-Male Specie to store common natural stats of all Indeedee-Males
	#region SpecieIndeedee-Male
	public class SpecieIndeedeeMale : PokemonSpecie
	{
#nullable enable
		private static SpecieIndeedeeMale? _instance = null;
#nullable restore
        public static SpecieIndeedeeMale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIndeedeeMale();
                }
                return _instance;
            }
        }

		#region SpecieIndeedee-Male Builder
		public SpecieIndeedeeMale() : base(
			"Indeedee-Male",
			60, // HPs
			65, 55, // Attack & Defense
			105, 95, // Special Attack & Defense
			95		
		)
		{
			this._height = 9;
			this._weight = 280;
		}
		#endregion
	}
	#endregion

	//Indeedee-Male Pokemon Class
	#region Indeedee-Male
	public class IndeedeeMale : Pokemon
	{
		#region Indeedee-Male Builders
		/// <summary>
		/// Indeedee-Male Builder waiting for a Nickname & a Level
		/// </summary>
		public IndeedeeMale(string nickname, int level)
		: base(
				876,
				SpecieIndeedeeMale.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Indeedee-Male Builder only waiting for a Level
		/// </summary>
		public IndeedeeMale(int level)
		: base(
				876,
				SpecieIndeedeeMale.Instance, // Pokemon Specie
				"Indeedee-Male", level,
				Psychic.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Indeedee-Male Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public IndeedeeMale() : base(
			876,
			SpecieIndeedeeMale.Instance, // Pokemon Specie
			Psychic.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}