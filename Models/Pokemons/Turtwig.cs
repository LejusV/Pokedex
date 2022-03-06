using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Turtwig Specie to store common natural stats of all Turtwigs
	#region SpecieTurtwig
	public class SpecieTurtwig : PokemonSpecie
	{
#nullable enable
		private static SpecieTurtwig? _instance = null;
#nullable restore
        public static SpecieTurtwig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTurtwig();
                }
                return _instance;
            }
        }

		#region SpecieTurtwig Builder
		public SpecieTurtwig() : base(
			"Turtwig",
			55, // HPs
			68, 64, // Attack & Defense
			45, 55, // Special Attack & Defense
			31		
		)
		{
			this._height = 4;
			this._weight = 102;
		}
		#endregion
	}
	#endregion

	//Turtwig Pokemon Class
	#region Turtwig
	public class Turtwig : Pokemon
	{
		#region Turtwig Builders
		/// <summary>
		/// Turtwig Builder waiting for a Nickname & a Level
		/// </summary>
		public Turtwig(string nickname, int level)
		: base(
				387,
				SpecieTurtwig.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtwig Builder only waiting for a Level
		/// </summary>
		public Turtwig(int level)
		: base(
				387,
				SpecieTurtwig.Instance, // Pokemon Specie
				"Turtwig", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtwig Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Turtwig() : base(
			387,
			SpecieTurtwig.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}