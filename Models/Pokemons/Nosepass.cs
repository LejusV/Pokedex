using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Nosepass Specie to store common natural stats of all Nosepasss
	#region SpecieNosepass
	public class SpecieNosepass : PokemonSpecie
	{
#nullable enable
		private static SpecieNosepass? _instance = null;
#nullable restore
        public static SpecieNosepass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNosepass();
                }
                return _instance;
            }
        }

		#region SpecieNosepass Builder
		public SpecieNosepass() : base(
			"Nosepass",
			30, // HPs
			45, 135, // Attack & Defense
			45, 90, // Special Attack & Defense
			30		
		)
		{
			this._height = 10;
			this._weight = 970;
		}
		#endregion
	}
	#endregion

	//Nosepass Pokemon Class
	#region Nosepass
	public class Nosepass : Pokemon
	{
		#region Nosepass Builders
		/// <summary>
		/// Nosepass Builder waiting for a Nickname & a Level
		/// </summary>
		public Nosepass(string nickname, int level)
		: base(
				299,
				SpecieNosepass.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nosepass Builder only waiting for a Level
		/// </summary>
		public Nosepass(int level)
		: base(
				299,
				SpecieNosepass.Instance, // Pokemon Specie
				"Nosepass", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nosepass Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Nosepass() : base(
			299,
			SpecieNosepass.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}