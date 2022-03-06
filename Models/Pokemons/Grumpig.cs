using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Grumpig Specie to store common natural stats of all Grumpigs
	#region SpecieGrumpig
	public class SpecieGrumpig : PokemonSpecie
	{
#nullable enable
		private static SpecieGrumpig? _instance = null;
#nullable restore
        public static SpecieGrumpig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrumpig();
                }
                return _instance;
            }
        }

		#region SpecieGrumpig Builder
		public SpecieGrumpig() : base(
			"Grumpig",
			80, // HPs
			45, 65, // Attack & Defense
			90, 110, // Special Attack & Defense
			80		
		)
		{
			this._height = 9;
			this._weight = 715;
		}
		#endregion
	}
	#endregion

	//Grumpig Pokemon Class
	#region Grumpig
	public class Grumpig : Pokemon
	{
		#region Grumpig Builders
		/// <summary>
		/// Grumpig Builder waiting for a Nickname & a Level
		/// </summary>
		public Grumpig(string nickname, int level)
		: base(
				326,
				SpecieGrumpig.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grumpig Builder only waiting for a Level
		/// </summary>
		public Grumpig(int level)
		: base(
				326,
				SpecieGrumpig.Instance, // Pokemon Specie
				"Grumpig", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grumpig Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Grumpig() : base(
			326,
			SpecieGrumpig.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}