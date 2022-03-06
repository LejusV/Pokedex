using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Manaphy Specie to store common natural stats of all Manaphys
	#region SpecieManaphy
	public class SpecieManaphy : PokemonSpecie
	{
#nullable enable
		private static SpecieManaphy? _instance = null;
#nullable restore
        public static SpecieManaphy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieManaphy();
                }
                return _instance;
            }
        }

		#region SpecieManaphy Builder
		public SpecieManaphy() : base(
			"Manaphy",
			0.3,
			1.4,
			100, // HPs
			100, 100, // Attack & Defense
			100, 100, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Manaphy Pokemon Class
	#region Manaphy
	public class Manaphy : Pokemon
	{
		#region Manaphy Builders
		/// <summary>
		/// Manaphy Builder waiting for a Nickname & a Level
		/// </summary>
		public Manaphy(string nickname, int level)
		: base(
				490,
				SpecieManaphy.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manaphy Builder only waiting for a Level
		/// </summary>
		public Manaphy(int level)
		: base(
				490,
				SpecieManaphy.Instance, // Pokemon Specie
				"Manaphy", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Manaphy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Manaphy() : base(
			490,
			SpecieManaphy.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}