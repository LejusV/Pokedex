using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Garbodor Specie to store common natural stats of all Garbodors
	#region SpecieGarbodor
	public class SpecieGarbodor : PokemonSpecie
	{
#nullable enable
		private static SpecieGarbodor? _instance = null;
#nullable restore
        public static SpecieGarbodor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGarbodor();
                }
                return _instance;
            }
        }

		#region SpecieGarbodor Builder
		public SpecieGarbodor() : base(
			"Garbodor",
			1.9,
			107.3,
			80, // HPs
			95, 82, // Attack & Defense
			60, 82, // Special Attack & Defense
			75		
		)
		{}
		#endregion
	}
	#endregion

	//Garbodor Pokemon Class
	#region Garbodor
	public class Garbodor : Pokemon
	{
		#region Garbodor Builders
		/// <summary>
		/// Garbodor Builder waiting for a Nickname & a Level
		/// </summary>
		public Garbodor(string nickname, int level)
		: base(
				569,
				SpecieGarbodor.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garbodor Builder only waiting for a Level
		/// </summary>
		public Garbodor(int level)
		: base(
				569,
				SpecieGarbodor.Instance, // Pokemon Specie
				"Garbodor", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garbodor Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Garbodor() : base(
			569,
			SpecieGarbodor.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}