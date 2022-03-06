using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Cubone Specie to store common natural stats of all Cubones
	#region SpecieCubone
	public class SpecieCubone : PokemonSpecie
	{
#nullable enable
		private static SpecieCubone? _instance = null;
#nullable restore
        public static SpecieCubone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCubone();
                }
                return _instance;
            }
        }

		#region SpecieCubone Builder
		public SpecieCubone() : base(
			"Cubone",
			50, // HPs
			50, 95, // Attack & Defense
			40, 50, // Special Attack & Defense
			35		
		)
		{
			this._height = 4;
			this._weight = 65;
		}
		#endregion
	}
	#endregion

	//Cubone Pokemon Class
	#region Cubone
	public class Cubone : Pokemon
	{
		#region Cubone Builders
		/// <summary>
		/// Cubone Builder waiting for a Nickname & a Level
		/// </summary>
		public Cubone(string nickname, int level)
		: base(
				104,
				SpecieCubone.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubone Builder only waiting for a Level
		/// </summary>
		public Cubone(int level)
		: base(
				104,
				SpecieCubone.Instance, // Pokemon Specie
				"Cubone", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cubone Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Cubone() : base(
			104,
			SpecieCubone.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}