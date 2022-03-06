using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Pansear Specie to store common natural stats of all Pansears
	#region SpeciePansear
	public class SpeciePansear : PokemonSpecie
	{
#nullable enable
		private static SpeciePansear? _instance = null;
#nullable restore
        public static SpeciePansear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePansear();
                }
                return _instance;
            }
        }

		#region SpeciePansear Builder
		public SpeciePansear() : base(
			"Pansear",
			0.6,
			11.0,
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64		
		)
		{}
		#endregion
	}
	#endregion

	//Pansear Pokemon Class
	#region Pansear
	public class Pansear : Pokemon
	{
		#region Pansear Builders
		/// <summary>
		/// Pansear Builder waiting for a Nickname & a Level
		/// </summary>
		public Pansear(string nickname, int level)
		: base(
				513,
				SpeciePansear.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansear Builder only waiting for a Level
		/// </summary>
		public Pansear(int level)
		: base(
				513,
				SpeciePansear.Instance, // Pokemon Specie
				"Pansear", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pansear Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Pansear() : base(
			513,
			SpeciePansear.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}