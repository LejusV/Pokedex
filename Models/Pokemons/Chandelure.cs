using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chandelure Specie to store common natural stats of all Chandelures
	#region SpecieChandelure
	public class SpecieChandelure : PokemonSpecie
	{
#nullable enable
		private static SpecieChandelure? _instance = null;
#nullable restore
        public static SpecieChandelure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChandelure();
                }
                return _instance;
            }
        }

		#region SpecieChandelure Builder
		public SpecieChandelure() : base(
			"Chandelure",
			1.0,
			34.3,
			60, // HPs
			55, 90, // Attack & Defense
			145, 90, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Chandelure Pokemon Class
	#region Chandelure
	public class Chandelure : Pokemon
	{
		#region Chandelure Builders
		/// <summary>
		/// Chandelure Builder waiting for a Nickname & a Level
		/// </summary>
		public Chandelure(string nickname, int level)
		: base(
				609,
				SpecieChandelure.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chandelure Builder only waiting for a Level
		/// </summary>
		public Chandelure(int level)
		: base(
				609,
				SpecieChandelure.Instance, // Pokemon Specie
				"Chandelure", level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chandelure Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chandelure() : base(
			609,
			SpecieChandelure.Instance, // Pokemon Specie
			Ghost.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}