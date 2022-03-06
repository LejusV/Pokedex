using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Psyduck Specie to store common natural stats of all Psyducks
	#region SpeciePsyduck
	public class SpeciePsyduck : PokemonSpecie
	{
#nullable enable
		private static SpeciePsyduck? _instance = null;
#nullable restore
        public static SpeciePsyduck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePsyduck();
                }
                return _instance;
            }
        }

		#region SpeciePsyduck Builder
		public SpeciePsyduck() : base(
			"Psyduck",
			0.8,
			19.6,
			50, // HPs
			52, 48, // Attack & Defense
			65, 50, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Psyduck Pokemon Class
	#region Psyduck
	public class Psyduck : Pokemon
	{
		#region Psyduck Builders
		/// <summary>
		/// Psyduck Builder waiting for a Nickname & a Level
		/// </summary>
		public Psyduck(string nickname, int level)
		: base(
				54,
				SpeciePsyduck.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Psyduck Builder only waiting for a Level
		/// </summary>
		public Psyduck(int level)
		: base(
				54,
				SpeciePsyduck.Instance, // Pokemon Specie
				"Psyduck", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Psyduck Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Psyduck() : base(
			54,
			SpeciePsyduck.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}