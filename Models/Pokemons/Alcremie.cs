using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Alcremie Specie to store common natural stats of all Alcremies
	#region SpecieAlcremie
	public class SpecieAlcremie : PokemonSpecie
	{
#nullable enable
		private static SpecieAlcremie? _instance = null;
#nullable restore
        public static SpecieAlcremie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAlcremie();
                }
                return _instance;
            }
        }

		#region SpecieAlcremie Builder
		public SpecieAlcremie() : base(
			"Alcremie",
			0.3,
			0.5,
			65, // HPs
			60, 75, // Attack & Defense
			110, 121, // Special Attack & Defense
			64		
		)
		{}
		#endregion
	}
	#endregion

	//Alcremie Pokemon Class
	#region Alcremie
	public class Alcremie : Pokemon
	{
		#region Alcremie Builders
		/// <summary>
		/// Alcremie Builder waiting for a Nickname & a Level
		/// </summary>
		public Alcremie(string nickname, int level)
		: base(
				869,
				SpecieAlcremie.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alcremie Builder only waiting for a Level
		/// </summary>
		public Alcremie(int level)
		: base(
				869,
				SpecieAlcremie.Instance, // Pokemon Specie
				"Alcremie", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alcremie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Alcremie() : base(
			869,
			SpecieAlcremie.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}