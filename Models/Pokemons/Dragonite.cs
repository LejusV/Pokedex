using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dragonite Specie to store common natural stats of all Dragonites
	#region SpecieDragonite
	public class SpecieDragonite : PokemonSpecie
	{
#nullable enable
		private static SpecieDragonite? _instance = null;
#nullable restore
        public static SpecieDragonite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragonite();
                }
                return _instance;
            }
        }

		#region SpecieDragonite Builder
		public SpecieDragonite() : base(
			"Dragonite",
			2.2,
			210.0,
			91, // HPs
			134, 95, // Attack & Defense
			100, 100, // Special Attack & Defense
			80		
		)
		{}
		#endregion
	}
	#endregion

	//Dragonite Pokemon Class
	#region Dragonite
	public class Dragonite : Pokemon
	{
		#region Dragonite Builders
		/// <summary>
		/// Dragonite Builder waiting for a Nickname & a Level
		/// </summary>
		public Dragonite(string nickname, int level)
		: base(
				149,
				SpecieDragonite.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonite Builder only waiting for a Level
		/// </summary>
		public Dragonite(int level)
		: base(
				149,
				SpecieDragonite.Instance, // Pokemon Specie
				"Dragonite", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragonite Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dragonite() : base(
			149,
			SpecieDragonite.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}