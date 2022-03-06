using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Duraludon Specie to store common natural stats of all Duraludons
	#region SpecieDuraludon
	public class SpecieDuraludon : PokemonSpecie
	{
#nullable enable
		private static SpecieDuraludon? _instance = null;
#nullable restore
        public static SpecieDuraludon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDuraludon();
                }
                return _instance;
            }
        }

		#region SpecieDuraludon Builder
		public SpecieDuraludon() : base(
			"Duraludon",
			70, // HPs
			95, 115, // Attack & Defense
			120, 50, // Special Attack & Defense
			85		
		)
		{
			this._height = 18;
			this._weight = 400;
		}
		#endregion
	}
	#endregion

	//Duraludon Pokemon Class
	#region Duraludon
	public class Duraludon : Pokemon
	{
		#region Duraludon Builders
		/// <summary>
		/// Duraludon Builder waiting for a Nickname & a Level
		/// </summary>
		public Duraludon(string nickname, int level)
		: base(
				884,
				SpecieDuraludon.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duraludon Builder only waiting for a Level
		/// </summary>
		public Duraludon(int level)
		: base(
				884,
				SpecieDuraludon.Instance, // Pokemon Specie
				"Duraludon", level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duraludon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Duraludon() : base(
			884,
			SpecieDuraludon.Instance, // Pokemon Specie
			Steel.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}