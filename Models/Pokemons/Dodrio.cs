using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dodrio Specie to store common natural stats of all Dodrios
	#region SpecieDodrio
	public class SpecieDodrio : PokemonSpecie
	{
#nullable enable
		private static SpecieDodrio? _instance = null;
#nullable restore
        public static SpecieDodrio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDodrio();
                }
                return _instance;
            }
        }

		#region SpecieDodrio Builder
		public SpecieDodrio() : base(
			"Dodrio",
			60, // HPs
			110, 70, // Attack & Defense
			60, 60, // Special Attack & Defense
			110		
		)
		{
			this._height = 18;
			this._weight = 852;
		}
		#endregion
	}
	#endregion

	//Dodrio Pokemon Class
	#region Dodrio
	public class Dodrio : Pokemon
	{
		#region Dodrio Builders
		/// <summary>
		/// Dodrio Builder waiting for a Nickname & a Level
		/// </summary>
		public Dodrio(string nickname, int level)
		: base(
				85,
				SpecieDodrio.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dodrio Builder only waiting for a Level
		/// </summary>
		public Dodrio(int level)
		: base(
				85,
				SpecieDodrio.Instance, // Pokemon Specie
				"Dodrio", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dodrio Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dodrio() : base(
			85,
			SpecieDodrio.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}