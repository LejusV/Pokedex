using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sandygast Specie to store common natural stats of all Sandygasts
	#region SpecieSandygast
	public class SpecieSandygast : PokemonSpecie
	{
#nullable enable
		private static SpecieSandygast? _instance = null;
#nullable restore
        public static SpecieSandygast Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandygast();
                }
                return _instance;
            }
        }

		#region SpecieSandygast Builder
		public SpecieSandygast() : base(
			"Sandygast",
			55, // HPs
			55, 80, // Attack & Defense
			70, 45, // Special Attack & Defense
			15		
		)
		{
			this._height = 5;
			this._weight = 700;
		}
		#endregion
	}
	#endregion

	//Sandygast Pokemon Class
	#region Sandygast
	public class Sandygast : Pokemon
	{
		#region Sandygast Builders
		/// <summary>
		/// Sandygast Builder waiting for a Nickname & a Level
		/// </summary>
		public Sandygast(string nickname, int level)
		: base(
				769,
				SpecieSandygast.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandygast Builder only waiting for a Level
		/// </summary>
		public Sandygast(int level)
		: base(
				769,
				SpecieSandygast.Instance, // Pokemon Specie
				"Sandygast", level,
				Ghost.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandygast Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sandygast() : base(
			769,
			SpecieSandygast.Instance, // Pokemon Specie
			Ghost.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}