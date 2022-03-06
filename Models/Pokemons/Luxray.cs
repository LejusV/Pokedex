using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Luxray Specie to store common natural stats of all Luxrays
	#region SpecieLuxray
	public class SpecieLuxray : PokemonSpecie
	{
#nullable enable
		private static SpecieLuxray? _instance = null;
#nullable restore
        public static SpecieLuxray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLuxray();
                }
                return _instance;
            }
        }

		#region SpecieLuxray Builder
		public SpecieLuxray() : base(
			"Luxray",
			80, // HPs
			120, 79, // Attack & Defense
			95, 79, // Special Attack & Defense
			70		
		)
		{
			this._height = 14;
			this._weight = 420;
		}
		#endregion
	}
	#endregion

	//Luxray Pokemon Class
	#region Luxray
	public class Luxray : Pokemon
	{
		#region Luxray Builders
		/// <summary>
		/// Luxray Builder waiting for a Nickname & a Level
		/// </summary>
		public Luxray(string nickname, int level)
		: base(
				405,
				SpecieLuxray.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxray Builder only waiting for a Level
		/// </summary>
		public Luxray(int level)
		: base(
				405,
				SpecieLuxray.Instance, // Pokemon Specie
				"Luxray", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxray Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Luxray() : base(
			405,
			SpecieLuxray.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}