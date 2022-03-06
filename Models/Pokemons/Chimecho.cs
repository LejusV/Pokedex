using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chimecho Specie to store common natural stats of all Chimechos
	#region SpecieChimecho
	public class SpecieChimecho : PokemonSpecie
	{
#nullable enable
		private static SpecieChimecho? _instance = null;
#nullable restore
        public static SpecieChimecho Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChimecho();
                }
                return _instance;
            }
        }

		#region SpecieChimecho Builder
		public SpecieChimecho() : base(
			"Chimecho",
			0.6,
			1.0,
			75, // HPs
			50, 80, // Attack & Defense
			95, 90, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Chimecho Pokemon Class
	#region Chimecho
	public class Chimecho : Pokemon
	{
		#region Chimecho Builders
		/// <summary>
		/// Chimecho Builder waiting for a Nickname & a Level
		/// </summary>
		public Chimecho(string nickname, int level)
		: base(
				358,
				SpecieChimecho.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimecho Builder only waiting for a Level
		/// </summary>
		public Chimecho(int level)
		: base(
				358,
				SpecieChimecho.Instance, // Pokemon Specie
				"Chimecho", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chimecho Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chimecho() : base(
			358,
			SpecieChimecho.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}