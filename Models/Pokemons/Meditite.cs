using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Meditite Specie to store common natural stats of all Meditites
	#region SpecieMeditite
	public class SpecieMeditite : PokemonSpecie
	{
#nullable enable
		private static SpecieMeditite? _instance = null;
#nullable restore
        public static SpecieMeditite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeditite();
                }
                return _instance;
            }
        }

		#region SpecieMeditite Builder
		public SpecieMeditite() : base(
			"Meditite",
			30, // HPs
			40, 55, // Attack & Defense
			40, 55, // Special Attack & Defense
			60		
		)
		{
			this._height = 6;
			this._weight = 112;
		}
		#endregion
	}
	#endregion

	//Meditite Pokemon Class
	#region Meditite
	public class Meditite : Pokemon
	{
		#region Meditite Builders
		/// <summary>
		/// Meditite Builder waiting for a Nickname & a Level
		/// </summary>
		public Meditite(string nickname, int level)
		: base(
				307,
				SpecieMeditite.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meditite Builder only waiting for a Level
		/// </summary>
		public Meditite(int level)
		: base(
				307,
				SpecieMeditite.Instance, // Pokemon Specie
				"Meditite", level,
				Fighting.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Meditite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Meditite() : base(
			307,
			SpecieMeditite.Instance, // Pokemon Specie
			Fighting.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}