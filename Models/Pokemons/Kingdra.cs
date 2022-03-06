using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kingdra Specie to store common natural stats of all Kingdras
	#region SpecieKingdra
	public class SpecieKingdra : PokemonSpecie
	{
#nullable enable
		private static SpecieKingdra? _instance = null;
#nullable restore
        public static SpecieKingdra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKingdra();
                }
                return _instance;
            }
        }

		#region SpecieKingdra Builder
		public SpecieKingdra() : base(
			"Kingdra",
			1.8,
			152.0,
			75, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			85		
		)
		{}
		#endregion
	}
	#endregion

	//Kingdra Pokemon Class
	#region Kingdra
	public class Kingdra : Pokemon
	{
		#region Kingdra Builders
		/// <summary>
		/// Kingdra Builder waiting for a Nickname & a Level
		/// </summary>
		public Kingdra(string nickname, int level)
		: base(
				230,
				SpecieKingdra.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingdra Builder only waiting for a Level
		/// </summary>
		public Kingdra(int level)
		: base(
				230,
				SpecieKingdra.Instance, // Pokemon Specie
				"Kingdra", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kingdra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kingdra() : base(
			230,
			SpecieKingdra.Instance, // Pokemon Specie
			Water.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}