using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Kabutops Specie to store common natural stats of all Kabutopss
	#region SpecieKabutops
	public class SpecieKabutops : PokemonSpecie
	{
#nullable enable
		private static SpecieKabutops? _instance = null;
#nullable restore
        public static SpecieKabutops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKabutops();
                }
                return _instance;
            }
        }

		#region SpecieKabutops Builder
		public SpecieKabutops() : base(
			"Kabutops",
			60, // HPs
			115, 105, // Attack & Defense
			65, 70, // Special Attack & Defense
			80		
		)
		{
			this._height = 13;
			this._weight = 405;
		}
		#endregion
	}
	#endregion

	//Kabutops Pokemon Class
	#region Kabutops
	public class Kabutops : Pokemon
	{
		#region Kabutops Builders
		/// <summary>
		/// Kabutops Builder waiting for a Nickname & a Level
		/// </summary>
		public Kabutops(string nickname, int level)
		: base(
				141,
				SpecieKabutops.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabutops Builder only waiting for a Level
		/// </summary>
		public Kabutops(int level)
		: base(
				141,
				SpecieKabutops.Instance, // Pokemon Specie
				"Kabutops", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Kabutops Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Kabutops() : base(
			141,
			SpecieKabutops.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}