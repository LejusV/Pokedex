using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Shelgon Specie to store common natural stats of all Shelgons
	#region SpecieShelgon
	public class SpecieShelgon : PokemonSpecie
	{
#nullable enable
		private static SpecieShelgon? _instance = null;
#nullable restore
        public static SpecieShelgon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShelgon();
                }
                return _instance;
            }
        }

		#region SpecieShelgon Builder
		public SpecieShelgon() : base(
			"Shelgon",
			1.1,
			110.5,
			65, // HPs
			95, 100, // Attack & Defense
			60, 50, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Shelgon Pokemon Class
	#region Shelgon
	public class Shelgon : Pokemon
	{
		#region Shelgon Builders
		/// <summary>
		/// Shelgon Builder waiting for a Nickname & a Level
		/// </summary>
		public Shelgon(string nickname, int level)
		: base(
				372,
				SpecieShelgon.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelgon Builder only waiting for a Level
		/// </summary>
		public Shelgon(int level)
		: base(
				372,
				SpecieShelgon.Instance, // Pokemon Specie
				"Shelgon", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Shelgon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Shelgon() : base(
			372,
			SpecieShelgon.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}