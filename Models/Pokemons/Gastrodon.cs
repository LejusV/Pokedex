using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gastrodon Specie to store common natural stats of all Gastrodons
	#region SpecieGastrodon
	public class SpecieGastrodon : PokemonSpecie
	{
#nullable enable
		private static SpecieGastrodon? _instance = null;
#nullable restore
        public static SpecieGastrodon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGastrodon();
                }
                return _instance;
            }
        }

		#region SpecieGastrodon Builder
		public SpecieGastrodon() : base(
			"Gastrodon",
			0.9,
			29.9,
			111, // HPs
			83, 68, // Attack & Defense
			92, 82, // Special Attack & Defense
			39		
		)
		{}
		#endregion
	}
	#endregion

	//Gastrodon Pokemon Class
	#region Gastrodon
	public class Gastrodon : Pokemon
	{
		#region Gastrodon Builders
		/// <summary>
		/// Gastrodon Builder waiting for a Nickname & a Level
		/// </summary>
		public Gastrodon(string nickname, int level)
		: base(
				423,
				SpecieGastrodon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastrodon Builder only waiting for a Level
		/// </summary>
		public Gastrodon(int level)
		: base(
				423,
				SpecieGastrodon.Instance, // Pokemon Specie
				"Gastrodon", level,
				Water.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gastrodon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gastrodon() : base(
			423,
			SpecieGastrodon.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}