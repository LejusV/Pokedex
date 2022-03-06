using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Fearow Specie to store common natural stats of all Fearows
	#region SpecieFearow
	public class SpecieFearow : PokemonSpecie
	{
#nullable enable
		private static SpecieFearow? _instance = null;
#nullable restore
        public static SpecieFearow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFearow();
                }
                return _instance;
            }
        }

		#region SpecieFearow Builder
		public SpecieFearow() : base(
			"Fearow",
			1.2,
			38.0,
			65, // HPs
			90, 65, // Attack & Defense
			61, 61, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Fearow Pokemon Class
	#region Fearow
	public class Fearow : Pokemon
	{
		#region Fearow Builders
		/// <summary>
		/// Fearow Builder waiting for a Nickname & a Level
		/// </summary>
		public Fearow(string nickname, int level)
		: base(
				22,
				SpecieFearow.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fearow Builder only waiting for a Level
		/// </summary>
		public Fearow(int level)
		: base(
				22,
				SpecieFearow.Instance, // Pokemon Specie
				"Fearow", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fearow Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Fearow() : base(
			22,
			SpecieFearow.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}