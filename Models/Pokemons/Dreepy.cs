using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dreepy Specie to store common natural stats of all Dreepys
	#region SpecieDreepy
	public class SpecieDreepy : PokemonSpecie
	{
#nullable enable
		private static SpecieDreepy? _instance = null;
#nullable restore
        public static SpecieDreepy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDreepy();
                }
                return _instance;
            }
        }

		#region SpecieDreepy Builder
		public SpecieDreepy() : base(
			"Dreepy",
			28, // HPs
			60, 30, // Attack & Defense
			40, 30, // Special Attack & Defense
			82		
		)
		{
			this._height = 5;
			this._weight = 20;
		}
		#endregion
	}
	#endregion

	//Dreepy Pokemon Class
	#region Dreepy
	public class Dreepy : Pokemon
	{
		#region Dreepy Builders
		/// <summary>
		/// Dreepy Builder waiting for a Nickname & a Level
		/// </summary>
		public Dreepy(string nickname, int level)
		: base(
				885,
				SpecieDreepy.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dreepy Builder only waiting for a Level
		/// </summary>
		public Dreepy(int level)
		: base(
				885,
				SpecieDreepy.Instance, // Pokemon Specie
				"Dreepy", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dreepy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dreepy() : base(
			885,
			SpecieDreepy.Instance, // Pokemon Specie
			Dragon.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}