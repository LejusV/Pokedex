using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Spoink Specie to store common natural stats of all Spoinks
	#region SpecieSpoink
	public class SpecieSpoink : PokemonSpecie
	{
#nullable enable
		private static SpecieSpoink? _instance = null;
#nullable restore
        public static SpecieSpoink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpoink();
                }
                return _instance;
            }
        }

		#region SpecieSpoink Builder
		public SpecieSpoink() : base(
			"Spoink",
			60, // HPs
			25, 35, // Attack & Defense
			70, 80, // Special Attack & Defense
			60		
		)
		{
			this._height = 7;
			this._weight = 306;
		}
		#endregion
	}
	#endregion

	//Spoink Pokemon Class
	#region Spoink
	public class Spoink : Pokemon
	{
		#region Spoink Builders
		/// <summary>
		/// Spoink Builder waiting for a Nickname & a Level
		/// </summary>
		public Spoink(string nickname, int level)
		: base(
				325,
				SpecieSpoink.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spoink Builder only waiting for a Level
		/// </summary>
		public Spoink(int level)
		: base(
				325,
				SpecieSpoink.Instance, // Pokemon Specie
				"Spoink", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spoink Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Spoink() : base(
			325,
			SpecieSpoink.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}