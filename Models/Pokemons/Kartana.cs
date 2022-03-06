using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kartana Specie to store common natural stats of all Kartanas
	#region SpecieKartana
	public class SpecieKartana : PokemonSpecie
	{
#nullable enable
		private static SpecieKartana? _instance = null;
#nullable restore
        public static SpecieKartana Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKartana();
                }
                return _instance;
            }
        }

		#region SpecieKartana Builder
		public SpecieKartana() : base(
			"Kartana",
			0.3,
			0.1,
			59, // HPs
			181, 131, // Attack & Defense
			59, 31, // Special Attack & Defense
			109		
		)
		{}
		#endregion
	}
	#endregion

	//Kartana Pokemon Class
	#region Kartana
	public class Kartana : Pokemon
	{
		#region Kartana Builders
		/// <summary>
		/// Kartana Builder waiting for a Nickname & a Level
		/// </summary>
		public Kartana(string nickname, int level)
		: base(
				798,
				SpecieKartana.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kartana Builder only waiting for a Level
		/// </summary>
		public Kartana(int level)
		: base(
				798,
				SpecieKartana.Instance, // Pokemon Specie
				"Kartana", level,
				Grass.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kartana Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kartana() : base(
			798,
			SpecieKartana.Instance, // Pokemon Specie
			Grass.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}