using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tangela Specie to store common natural stats of all Tangelas
	#region SpecieTangela
	public class SpecieTangela : PokemonSpecie
	{
#nullable enable
		private static SpecieTangela? _instance = null;
#nullable restore
        public static SpecieTangela Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTangela();
                }
                return _instance;
            }
        }

		#region SpecieTangela Builder
		public SpecieTangela() : base(
			"Tangela",
			1.0,
			35.0,
			65, // HPs
			55, 115, // Attack & Defense
			100, 40, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Tangela Pokemon Class
	#region Tangela
	public class Tangela : Pokemon
	{
		#region Tangela Builders
		/// <summary>
		/// Tangela Builder waiting for a Nickname & a Level
		/// </summary>
		public Tangela(string nickname, int level)
		: base(
				114,
				SpecieTangela.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangela Builder only waiting for a Level
		/// </summary>
		public Tangela(int level)
		: base(
				114,
				SpecieTangela.Instance, // Pokemon Specie
				"Tangela", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tangela Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tangela() : base(
			114,
			SpecieTangela.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}