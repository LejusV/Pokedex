using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Arceus Specie to store common natural stats of all Arceuss
	#region SpecieArceus
	public class SpecieArceus : PokemonSpecie
	{
#nullable enable
		private static SpecieArceus? _instance = null;
#nullable restore
        public static SpecieArceus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArceus();
                }
                return _instance;
            }
        }

		#region SpecieArceus Builder
		public SpecieArceus() : base(
			"Arceus",
			120, // HPs
			120, 120, // Attack & Defense
			120, 120, // Special Attack & Defense
			120		
		)
		{
			this._height = 32;
			this._weight = 3200;
		}
		#endregion
	}
	#endregion

	//Arceus Pokemon Class
	#region Arceus
	public class Arceus : Pokemon
	{
		#region Arceus Builders
		/// <summary>
		/// Arceus Builder waiting for a Nickname & a Level
		/// </summary>
		public Arceus(string nickname, int level)
		: base(
				493,
				SpecieArceus.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arceus Builder only waiting for a Level
		/// </summary>
		public Arceus(int level)
		: base(
				493,
				SpecieArceus.Instance, // Pokemon Specie
				"Arceus", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arceus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Arceus() : base(
			493,
			SpecieArceus.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}