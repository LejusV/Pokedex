using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Drowzee Specie to store common natural stats of all Drowzees
	#region SpecieDrowzee
	public class SpecieDrowzee : PokemonSpecie
	{
#nullable enable
		private static SpecieDrowzee? _instance = null;
#nullable restore
        public static SpecieDrowzee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrowzee();
                }
                return _instance;
            }
        }

		#region SpecieDrowzee Builder
		public SpecieDrowzee() : base(
			"Drowzee",
			1.0,
			32.4,
			60, // HPs
			48, 45, // Attack & Defense
			43, 90, // Special Attack & Defense
			42		
		)
		{}
		#endregion
	}
	#endregion

	//Drowzee Pokemon Class
	#region Drowzee
	public class Drowzee : Pokemon
	{
		#region Drowzee Builders
		/// <summary>
		/// Drowzee Builder waiting for a Nickname & a Level
		/// </summary>
		public Drowzee(string nickname, int level)
		: base(
				96,
				SpecieDrowzee.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drowzee Builder only waiting for a Level
		/// </summary>
		public Drowzee(int level)
		: base(
				96,
				SpecieDrowzee.Instance, // Pokemon Specie
				"Drowzee", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drowzee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Drowzee() : base(
			96,
			SpecieDrowzee.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}