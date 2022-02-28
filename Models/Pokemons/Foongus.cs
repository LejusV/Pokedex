using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Foongus Specie to store common natural stats of all Foonguss
	#region SpecieFoongus
	public class SpecieFoongus : PokemonSpecie
	{
#nullable enable
		private static SpecieFoongus? _instance = null;
#nullable restore
        public static SpecieFoongus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFoongus();
                }
                return _instance;
            }
        }

		#region SpecieFoongus Builder
		public SpecieFoongus() : base(
			"Foongus",
			69, // HPs
			55, 45, // Attack & Defense
			55, 55, // Special Attack & Defense
			15			
		) {}
		#endregion
	}
	#endregion

	//Foongus Pokemon Class
	#region Foongus
	public class Foongus : Pokemon
	{
		#region Foongus Builders
		/// <summary>
		/// Foongus Builder waiting for a Nickname & a Level
		/// </summary>
		public Foongus(string nickname, int level)
		: base(
				590,
				SpecieFoongus.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Foongus Builder only waiting for a Level
		/// </summary>
		public Foongus(int level)
		: base(
				590,
				SpecieFoongus.Instance, // Pokemon Specie
				"Foongus", level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Foongus Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Foongus() : base(
			590,
			SpecieFoongus.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}