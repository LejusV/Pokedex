using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bastiodon Specie to store common natural stats of all Bastiodons
	#region SpecieBastiodon
	public class SpecieBastiodon : PokemonSpecie
	{
#nullable enable
		private static SpecieBastiodon? _instance = null;
#nullable restore
        public static SpecieBastiodon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBastiodon();
                }
                return _instance;
            }
        }

		#region SpecieBastiodon Builder
		public SpecieBastiodon() : base(
			"Bastiodon",
			60, // HPs
			52, 168, // Attack & Defense
			47, 138, // Special Attack & Defense
			30		
		)
		{
			this._height = 13;
			this._weight = 1495;
		}
		#endregion
	}
	#endregion

	//Bastiodon Pokemon Class
	#region Bastiodon
	public class Bastiodon : Pokemon
	{
		#region Bastiodon Builders
		/// <summary>
		/// Bastiodon Builder waiting for a Nickname & a Level
		/// </summary>
		public Bastiodon(string nickname, int level)
		: base(
				411,
				SpecieBastiodon.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bastiodon Builder only waiting for a Level
		/// </summary>
		public Bastiodon(int level)
		: base(
				411,
				SpecieBastiodon.Instance, // Pokemon Specie
				"Bastiodon", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bastiodon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bastiodon() : base(
			411,
			SpecieBastiodon.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}