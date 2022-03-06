using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Goldeen Specie to store common natural stats of all Goldeens
	#region SpecieGoldeen
	public class SpecieGoldeen : PokemonSpecie
	{
#nullable enable
		private static SpecieGoldeen? _instance = null;
#nullable restore
        public static SpecieGoldeen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGoldeen();
                }
                return _instance;
            }
        }

		#region SpecieGoldeen Builder
		public SpecieGoldeen() : base(
			"Goldeen",
			0.6,
			15.0,
			45, // HPs
			67, 60, // Attack & Defense
			35, 50, // Special Attack & Defense
			63		
		)
		{}
		#endregion
	}
	#endregion

	//Goldeen Pokemon Class
	#region Goldeen
	public class Goldeen : Pokemon
	{
		#region Goldeen Builders
		/// <summary>
		/// Goldeen Builder waiting for a Nickname & a Level
		/// </summary>
		public Goldeen(string nickname, int level)
		: base(
				118,
				SpecieGoldeen.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goldeen Builder only waiting for a Level
		/// </summary>
		public Goldeen(int level)
		: base(
				118,
				SpecieGoldeen.Instance, // Pokemon Specie
				"Goldeen", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Goldeen Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Goldeen() : base(
			118,
			SpecieGoldeen.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}