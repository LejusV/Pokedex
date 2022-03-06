using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Porygon Specie to store common natural stats of all Porygons
	#region SpeciePorygon
	public class SpeciePorygon : PokemonSpecie
	{
#nullable enable
		private static SpeciePorygon? _instance = null;
#nullable restore
        public static SpeciePorygon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePorygon();
                }
                return _instance;
            }
        }

		#region SpeciePorygon Builder
		public SpeciePorygon() : base(
			"Porygon",
			0.8,
			36.5,
			65, // HPs
			60, 70, // Attack & Defense
			85, 75, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Porygon Pokemon Class
	#region Porygon
	public class Porygon : Pokemon
	{
		#region Porygon Builders
		/// <summary>
		/// Porygon Builder waiting for a Nickname & a Level
		/// </summary>
		public Porygon(string nickname, int level)
		: base(
				137,
				SpeciePorygon.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon Builder only waiting for a Level
		/// </summary>
		public Porygon(int level)
		: base(
				137,
				SpeciePorygon.Instance, // Pokemon Specie
				"Porygon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Porygon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Porygon() : base(
			137,
			SpeciePorygon.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}