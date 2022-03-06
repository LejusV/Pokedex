using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dugtrio Specie to store common natural stats of all Dugtrios
	#region SpecieDugtrio
	public class SpecieDugtrio : PokemonSpecie
	{
#nullable enable
		private static SpecieDugtrio? _instance = null;
#nullable restore
        public static SpecieDugtrio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDugtrio();
                }
                return _instance;
            }
        }

		#region SpecieDugtrio Builder
		public SpecieDugtrio() : base(
			"Dugtrio",
			35, // HPs
			100, 50, // Attack & Defense
			50, 70, // Special Attack & Defense
			120		
		)
		{
			this._height = 7;
			this._weight = 333;
		}
		#endregion
	}
	#endregion

	//Dugtrio Pokemon Class
	#region Dugtrio
	public class Dugtrio : Pokemon
	{
		#region Dugtrio Builders
		/// <summary>
		/// Dugtrio Builder waiting for a Nickname & a Level
		/// </summary>
		public Dugtrio(string nickname, int level)
		: base(
				51,
				SpecieDugtrio.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dugtrio Builder only waiting for a Level
		/// </summary>
		public Dugtrio(int level)
		: base(
				51,
				SpecieDugtrio.Instance, // Pokemon Specie
				"Dugtrio", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dugtrio Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dugtrio() : base(
			51,
			SpecieDugtrio.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}