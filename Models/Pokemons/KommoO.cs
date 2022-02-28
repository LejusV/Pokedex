using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kommo-O Specie to store common natural stats of all Kommo-Os
	#region SpecieKommo-O
	public class SpecieKommoO : PokemonSpecie
	{
#nullable enable
		private static SpecieKommoO? _instance = null;
#nullable restore
        public static SpecieKommoO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKommoO();
                }
                return _instance;
            }
        }

		#region SpecieKommo-O Builder
		public SpecieKommoO() : base(
			"Kommo-O",
			75, // HPs
			110, 125, // Attack & Defense
			100, 105, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Kommo-O Pokemon Class
	#region Kommo-O
	public class KommoO : Pokemon
	{
		#region Kommo-O Builders
		/// <summary>
		/// Kommo-O Builder waiting for a Nickname & a Level
		/// </summary>
		public KommoO(string nickname, int level)
		: base(
				784,
				SpecieKommoO.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kommo-O Builder only waiting for a Level
		/// </summary>
		public KommoO(int level)
		: base(
				784,
				SpecieKommoO.Instance, // Pokemon Specie
				"Kommo-O", level,
				Dragon.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kommo-O Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public KommoO() : base(
			784,
			SpecieKommoO.Instance, // Pokemon Specie
			Dragon.Instance, Fighting.Instance			
		) {}
		#endregion
	}
	#endregion
}