using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Raboot Specie to store common natural stats of all Raboots
	#region SpecieRaboot
	public class SpecieRaboot : PokemonSpecie
	{
#nullable enable
		private static SpecieRaboot? _instance = null;
#nullable restore
        public static SpecieRaboot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRaboot();
                }
                return _instance;
            }
        }

		#region SpecieRaboot Builder
		public SpecieRaboot() : base(
			"Raboot",
			65, // HPs
			86, 60, // Attack & Defense
			55, 60, // Special Attack & Defense
			94		
		)
		{
			this._height = 6;
			this._weight = 90;
		}
		#endregion
	}
	#endregion

	//Raboot Pokemon Class
	#region Raboot
	public class Raboot : Pokemon
	{
		#region Raboot Builders
		/// <summary>
		/// Raboot Builder waiting for a Nickname & a Level
		/// </summary>
		public Raboot(string nickname, int level)
		: base(
				814,
				SpecieRaboot.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raboot Builder only waiting for a Level
		/// </summary>
		public Raboot(int level)
		: base(
				814,
				SpecieRaboot.Instance, // Pokemon Specie
				"Raboot", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Raboot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Raboot() : base(
			814,
			SpecieRaboot.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}