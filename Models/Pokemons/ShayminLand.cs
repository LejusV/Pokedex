using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shaymin-Land Specie to store common natural stats of all Shaymin-Lands
	#region SpecieShaymin-Land
	public class SpecieShayminLand : PokemonSpecie
	{
#nullable enable
		private static SpecieShayminLand? _instance = null;
#nullable restore
        public static SpecieShayminLand Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShayminLand();
                }
                return _instance;
            }
        }

		#region SpecieShaymin-Land Builder
		public SpecieShayminLand() : base(
			"Shaymin-Land",
			0.2,
			2.1,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Shaymin-Land Pokemon Class
	#region Shaymin-Land
	public class ShayminLand : Pokemon
	{
		#region Shaymin-Land Builders
		/// <summary>
		/// Shaymin-Land Builder waiting for a Nickname & a Level
		/// </summary>
		public ShayminLand(string nickname, int level)
		: base(
				492,
				SpecieShayminLand.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shaymin-Land Builder only waiting for a Level
		/// </summary>
		public ShayminLand(int level)
		: base(
				492,
				SpecieShayminLand.Instance, // Pokemon Specie
				"Shaymin-Land", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shaymin-Land Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public ShayminLand() : base(
			492,
			SpecieShayminLand.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}