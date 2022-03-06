using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sewaddle Specie to store common natural stats of all Sewaddles
	#region SpecieSewaddle
	public class SpecieSewaddle : PokemonSpecie
	{
#nullable enable
		private static SpecieSewaddle? _instance = null;
#nullable restore
        public static SpecieSewaddle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSewaddle();
                }
                return _instance;
            }
        }

		#region SpecieSewaddle Builder
		public SpecieSewaddle() : base(
			"Sewaddle",
			0.3,
			2.5,
			45, // HPs
			53, 70, // Attack & Defense
			40, 60, // Special Attack & Defense
			42		
		)
		{}
		#endregion
	}
	#endregion

	//Sewaddle Pokemon Class
	#region Sewaddle
	public class Sewaddle : Pokemon
	{
		#region Sewaddle Builders
		/// <summary>
		/// Sewaddle Builder waiting for a Nickname & a Level
		/// </summary>
		public Sewaddle(string nickname, int level)
		: base(
				540,
				SpecieSewaddle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sewaddle Builder only waiting for a Level
		/// </summary>
		public Sewaddle(int level)
		: base(
				540,
				SpecieSewaddle.Instance, // Pokemon Specie
				"Sewaddle", level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sewaddle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sewaddle() : base(
			540,
			SpecieSewaddle.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}