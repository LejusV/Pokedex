using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Litleo Specie to store common natural stats of all Litleos
	#region SpecieLitleo
	public class SpecieLitleo : PokemonSpecie
	{
#nullable enable
		private static SpecieLitleo? _instance = null;
#nullable restore
        public static SpecieLitleo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLitleo();
                }
                return _instance;
            }
        }

		#region SpecieLitleo Builder
		public SpecieLitleo() : base(
			"Litleo",
			0.6,
			13.5,
			62, // HPs
			50, 58, // Attack & Defense
			73, 54, // Special Attack & Defense
			72		
		)
		{}
		#endregion
	}
	#endregion

	//Litleo Pokemon Class
	#region Litleo
	public class Litleo : Pokemon
	{
		#region Litleo Builders
		/// <summary>
		/// Litleo Builder waiting for a Nickname & a Level
		/// </summary>
		public Litleo(string nickname, int level)
		: base(
				667,
				SpecieLitleo.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litleo Builder only waiting for a Level
		/// </summary>
		public Litleo(int level)
		: base(
				667,
				SpecieLitleo.Instance, // Pokemon Specie
				"Litleo", level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litleo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Litleo() : base(
			667,
			SpecieLitleo.Instance, // Pokemon Specie
			Fire.Instance, Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}