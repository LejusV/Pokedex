using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zeraora Specie to store common natural stats of all Zeraoras
	#region SpecieZeraora
	public class SpecieZeraora : PokemonSpecie
	{
#nullable enable
		private static SpecieZeraora? _instance = null;
#nullable restore
        public static SpecieZeraora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZeraora();
                }
                return _instance;
            }
        }

		#region SpecieZeraora Builder
		public SpecieZeraora() : base(
			"Zeraora",
			88, // HPs
			112, 75, // Attack & Defense
			102, 80, // Special Attack & Defense
			143		
		)
		{
			this._height = 15;
			this._weight = 445;
		}
		#endregion
	}
	#endregion

	//Zeraora Pokemon Class
	#region Zeraora
	public class Zeraora : Pokemon
	{
		#region Zeraora Builders
		/// <summary>
		/// Zeraora Builder waiting for a Nickname & a Level
		/// </summary>
		public Zeraora(string nickname, int level)
		: base(
				807,
				SpecieZeraora.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zeraora Builder only waiting for a Level
		/// </summary>
		public Zeraora(int level)
		: base(
				807,
				SpecieZeraora.Instance, // Pokemon Specie
				"Zeraora", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zeraora Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zeraora() : base(
			807,
			SpecieZeraora.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}