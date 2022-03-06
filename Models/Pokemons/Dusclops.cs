using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dusclops Specie to store common natural stats of all Dusclopss
	#region SpecieDusclops
	public class SpecieDusclops : PokemonSpecie
	{
#nullable enable
		private static SpecieDusclops? _instance = null;
#nullable restore
        public static SpecieDusclops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDusclops();
                }
                return _instance;
            }
        }

		#region SpecieDusclops Builder
		public SpecieDusclops() : base(
			"Dusclops",
			1.6,
			30.6,
			40, // HPs
			70, 130, // Attack & Defense
			60, 130, // Special Attack & Defense
			25		
		)
		{}
		#endregion
	}
	#endregion

	//Dusclops Pokemon Class
	#region Dusclops
	public class Dusclops : Pokemon
	{
		#region Dusclops Builders
		/// <summary>
		/// Dusclops Builder waiting for a Nickname & a Level
		/// </summary>
		public Dusclops(string nickname, int level)
		: base(
				356,
				SpecieDusclops.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusclops Builder only waiting for a Level
		/// </summary>
		public Dusclops(int level)
		: base(
				356,
				SpecieDusclops.Instance, // Pokemon Specie
				"Dusclops", level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dusclops Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dusclops() : base(
			356,
			SpecieDusclops.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}