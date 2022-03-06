using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Orbeetle Specie to store common natural stats of all Orbeetles
	#region SpecieOrbeetle
	public class SpecieOrbeetle : PokemonSpecie
	{
#nullable enable
		private static SpecieOrbeetle? _instance = null;
#nullable restore
        public static SpecieOrbeetle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOrbeetle();
                }
                return _instance;
            }
        }

		#region SpecieOrbeetle Builder
		public SpecieOrbeetle() : base(
			"Orbeetle",
			0.4,
			40.8,
			60, // HPs
			45, 110, // Attack & Defense
			80, 120, // Special Attack & Defense
			90		
		)
		{}
		#endregion
	}
	#endregion

	//Orbeetle Pokemon Class
	#region Orbeetle
	public class Orbeetle : Pokemon
	{
		#region Orbeetle Builders
		/// <summary>
		/// Orbeetle Builder waiting for a Nickname & a Level
		/// </summary>
		public Orbeetle(string nickname, int level)
		: base(
				826,
				SpecieOrbeetle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Orbeetle Builder only waiting for a Level
		/// </summary>
		public Orbeetle(int level)
		: base(
				826,
				SpecieOrbeetle.Instance, // Pokemon Specie
				"Orbeetle", level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Orbeetle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Orbeetle() : base(
			826,
			SpecieOrbeetle.Instance, // Pokemon Specie
			Bug.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}