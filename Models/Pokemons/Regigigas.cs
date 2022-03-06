using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Regigigas Specie to store common natural stats of all Regigigass
	#region SpecieRegigigas
	public class SpecieRegigigas : PokemonSpecie
	{
#nullable enable
		private static SpecieRegigigas? _instance = null;
#nullable restore
        public static SpecieRegigigas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegigigas();
                }
                return _instance;
            }
        }

		#region SpecieRegigigas Builder
		public SpecieRegigigas() : base(
			"Regigigas",
			3.7,
			420.0,
			110, // HPs
			160, 110, // Attack & Defense
			80, 110, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Regigigas Pokemon Class
	#region Regigigas
	public class Regigigas : Pokemon
	{
		#region Regigigas Builders
		/// <summary>
		/// Regigigas Builder waiting for a Nickname & a Level
		/// </summary>
		public Regigigas(string nickname, int level)
		: base(
				486,
				SpecieRegigigas.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regigigas Builder only waiting for a Level
		/// </summary>
		public Regigigas(int level)
		: base(
				486,
				SpecieRegigigas.Instance, // Pokemon Specie
				"Regigigas", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Regigigas Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Regigigas() : base(
			486,
			SpecieRegigigas.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}