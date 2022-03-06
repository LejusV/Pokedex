using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Hippowdon Specie to store common natural stats of all Hippowdons
	#region SpecieHippowdon
	public class SpecieHippowdon : PokemonSpecie
	{
#nullable enable
		private static SpecieHippowdon? _instance = null;
#nullable restore
        public static SpecieHippowdon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHippowdon();
                }
                return _instance;
            }
        }

		#region SpecieHippowdon Builder
		public SpecieHippowdon() : base(
			"Hippowdon",
			108, // HPs
			112, 118, // Attack & Defense
			68, 72, // Special Attack & Defense
			47		
		)
		{
			this._height = 20;
			this._weight = 3000;
		}
		#endregion
	}
	#endregion

	//Hippowdon Pokemon Class
	#region Hippowdon
	public class Hippowdon : Pokemon
	{
		#region Hippowdon Builders
		/// <summary>
		/// Hippowdon Builder waiting for a Nickname & a Level
		/// </summary>
		public Hippowdon(string nickname, int level)
		: base(
				450,
				SpecieHippowdon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippowdon Builder only waiting for a Level
		/// </summary>
		public Hippowdon(int level)
		: base(
				450,
				SpecieHippowdon.Instance, // Pokemon Specie
				"Hippowdon", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hippowdon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Hippowdon() : base(
			450,
			SpecieHippowdon.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}