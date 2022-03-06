using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Baltoy Specie to store common natural stats of all Baltoys
	#region SpecieBaltoy
	public class SpecieBaltoy : PokemonSpecie
	{
#nullable enable
		private static SpecieBaltoy? _instance = null;
#nullable restore
        public static SpecieBaltoy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBaltoy();
                }
                return _instance;
            }
        }

		#region SpecieBaltoy Builder
		public SpecieBaltoy() : base(
			"Baltoy",
			40, // HPs
			40, 55, // Attack & Defense
			40, 70, // Special Attack & Defense
			55		
		)
		{
			this._height = 5;
			this._weight = 215;
		}
		#endregion
	}
	#endregion

	//Baltoy Pokemon Class
	#region Baltoy
	public class Baltoy : Pokemon
	{
		#region Baltoy Builders
		/// <summary>
		/// Baltoy Builder waiting for a Nickname & a Level
		/// </summary>
		public Baltoy(string nickname, int level)
		: base(
				343,
				SpecieBaltoy.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Baltoy Builder only waiting for a Level
		/// </summary>
		public Baltoy(int level)
		: base(
				343,
				SpecieBaltoy.Instance, // Pokemon Specie
				"Baltoy", level,
				Ground.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Baltoy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Baltoy() : base(
			343,
			SpecieBaltoy.Instance, // Pokemon Specie
			Ground.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}