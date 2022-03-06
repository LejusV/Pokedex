using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Wynaut Specie to store common natural stats of all Wynauts
	#region SpecieWynaut
	public class SpecieWynaut : PokemonSpecie
	{
#nullable enable
		private static SpecieWynaut? _instance = null;
#nullable restore
        public static SpecieWynaut Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWynaut();
                }
                return _instance;
            }
        }

		#region SpecieWynaut Builder
		public SpecieWynaut() : base(
			"Wynaut",
			0.6,
			14.0,
			95, // HPs
			23, 48, // Attack & Defense
			23, 48, // Special Attack & Defense
			23		
		)
		{}
		#endregion
	}
	#endregion

	//Wynaut Pokemon Class
	#region Wynaut
	public class Wynaut : Pokemon
	{
		#region Wynaut Builders
		/// <summary>
		/// Wynaut Builder waiting for a Nickname & a Level
		/// </summary>
		public Wynaut(string nickname, int level)
		: base(
				360,
				SpecieWynaut.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wynaut Builder only waiting for a Level
		/// </summary>
		public Wynaut(int level)
		: base(
				360,
				SpecieWynaut.Instance, // Pokemon Specie
				"Wynaut", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Wynaut Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Wynaut() : base(
			360,
			SpecieWynaut.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}