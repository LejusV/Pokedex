using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Monferno Specie to store common natural stats of all Monfernos
	#region SpecieMonferno
	public class SpecieMonferno : PokemonSpecie
	{
#nullable enable
		private static SpecieMonferno? _instance = null;
#nullable restore
        public static SpecieMonferno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMonferno();
                }
                return _instance;
            }
        }

		#region SpecieMonferno Builder
		public SpecieMonferno() : base(
			"Monferno",
			64, // HPs
			78, 52, // Attack & Defense
			78, 52, // Special Attack & Defense
			81		
		)
		{
			this._height = 9;
			this._weight = 220;
		}
		#endregion
	}
	#endregion

	//Monferno Pokemon Class
	#region Monferno
	public class Monferno : Pokemon
	{
		#region Monferno Builders
		/// <summary>
		/// Monferno Builder waiting for a Nickname & a Level
		/// </summary>
		public Monferno(string nickname, int level)
		: base(
				391,
				SpecieMonferno.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Monferno Builder only waiting for a Level
		/// </summary>
		public Monferno(int level)
		: base(
				391,
				SpecieMonferno.Instance, // Pokemon Specie
				"Monferno", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Monferno Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Monferno() : base(
			391,
			SpecieMonferno.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}