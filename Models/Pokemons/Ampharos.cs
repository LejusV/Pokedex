using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ampharos Specie to store common natural stats of all Amphaross
	#region SpecieAmpharos
	public class SpecieAmpharos : PokemonSpecie
	{
#nullable enable
		private static SpecieAmpharos? _instance = null;
#nullable restore
        public static SpecieAmpharos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmpharos();
                }
                return _instance;
            }
        }

		#region SpecieAmpharos Builder
		public SpecieAmpharos() : base(
			"Ampharos",
			90, // HPs
			75, 85, // Attack & Defense
			115, 90, // Special Attack & Defense
			55		
		)
		{
			this._height = 14;
			this._weight = 615;
		}
		#endregion
	}
	#endregion

	//Ampharos Pokemon Class
	#region Ampharos
	public class Ampharos : Pokemon
	{
		#region Ampharos Builders
		/// <summary>
		/// Ampharos Builder waiting for a Nickname & a Level
		/// </summary>
		public Ampharos(string nickname, int level)
		: base(
				181,
				SpecieAmpharos.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ampharos Builder only waiting for a Level
		/// </summary>
		public Ampharos(int level)
		: base(
				181,
				SpecieAmpharos.Instance, // Pokemon Specie
				"Ampharos", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ampharos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ampharos() : base(
			181,
			SpecieAmpharos.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}