using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Caterpie Specie to store common natural stats of all Caterpies
	#region SpecieCaterpie
	public class SpecieCaterpie : PokemonSpecie
	{
#nullable enable
		private static SpecieCaterpie? _instance = null;
#nullable restore
        public static SpecieCaterpie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCaterpie();
                }
                return _instance;
            }
        }

		#region SpecieCaterpie Builder
		public SpecieCaterpie() : base(
			"Caterpie",
			45, // HPs
			30, 35, // Attack & Defense
			20, 20, // Special Attack & Defense
			45		
		)
		{
			this._height = 3;
			this._weight = 29;
		}
		#endregion
	}
	#endregion

	//Caterpie Pokemon Class
	#region Caterpie
	public class Caterpie : Pokemon
	{
		#region Caterpie Builders
		/// <summary>
		/// Caterpie Builder waiting for a Nickname & a Level
		/// </summary>
		public Caterpie(string nickname, int level)
		: base(
				10,
				SpecieCaterpie.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Caterpie Builder only waiting for a Level
		/// </summary>
		public Caterpie(int level)
		: base(
				10,
				SpecieCaterpie.Instance, // Pokemon Specie
				"Caterpie", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Caterpie Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Caterpie() : base(
			10,
			SpecieCaterpie.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}