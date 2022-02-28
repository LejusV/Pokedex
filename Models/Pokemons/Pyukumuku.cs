using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pyukumuku Specie to store common natural stats of all Pyukumukus
	#region SpeciePyukumuku
	public class SpeciePyukumuku : PokemonSpecie
	{
#nullable enable
		private static SpeciePyukumuku? _instance = null;
#nullable restore
        public static SpeciePyukumuku Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePyukumuku();
                }
                return _instance;
            }
        }

		#region SpeciePyukumuku Builder
		public SpeciePyukumuku() : base(
			"Pyukumuku",
			55, // HPs
			60, 130, // Attack & Defense
			30, 130, // Special Attack & Defense
			5			
		) {}
		#endregion
	}
	#endregion

	//Pyukumuku Pokemon Class
	#region Pyukumuku
	public class Pyukumuku : Pokemon
	{
		#region Pyukumuku Builders
		/// <summary>
		/// Pyukumuku Builder waiting for a Nickname & a Level
		/// </summary>
		public Pyukumuku(string nickname, int level)
		: base(
				771,
				SpeciePyukumuku.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyukumuku Builder only waiting for a Level
		/// </summary>
		public Pyukumuku(int level)
		: base(
				771,
				SpeciePyukumuku.Instance, // Pokemon Specie
				"Pyukumuku", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyukumuku Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pyukumuku() : base(
			771,
			SpeciePyukumuku.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		#endregion
	}
	#endregion
}