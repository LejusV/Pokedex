using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Duosion Specie to store common natural stats of all Duosions
	#region SpecieDuosion
	public class SpecieDuosion : PokemonSpecie
	{
#nullable enable
		private static SpecieDuosion? _instance = null;
#nullable restore
        public static SpecieDuosion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDuosion();
                }
                return _instance;
            }
        }

		#region SpecieDuosion Builder
		public SpecieDuosion() : base(
			"Duosion",
			65, // HPs
			40, 50, // Attack & Defense
			125, 60, // Special Attack & Defense
			30		
		)
		{
			this._height = 6;
			this._weight = 80;
		}
		#endregion
	}
	#endregion

	//Duosion Pokemon Class
	#region Duosion
	public class Duosion : Pokemon
	{
		#region Duosion Builders
		/// <summary>
		/// Duosion Builder waiting for a Nickname & a Level
		/// </summary>
		public Duosion(string nickname, int level)
		: base(
				578,
				SpecieDuosion.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duosion Builder only waiting for a Level
		/// </summary>
		public Duosion(int level)
		: base(
				578,
				SpecieDuosion.Instance, // Pokemon Specie
				"Duosion", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duosion Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Duosion() : base(
			578,
			SpecieDuosion.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}