using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dustox Specie to store common natural stats of all Dustoxs
	#region SpecieDustox
	public class SpecieDustox : PokemonSpecie
	{
#nullable enable
		private static SpecieDustox? _instance = null;
#nullable restore
        public static SpecieDustox Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDustox();
                }
                return _instance;
            }
        }

		#region SpecieDustox Builder
		public SpecieDustox() : base(
			"Dustox",
			60, // HPs
			50, 70, // Attack & Defense
			50, 90, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Dustox Pokemon Class
	#region Dustox
	public class Dustox : Pokemon
	{
		#region Dustox Builders
		/// <summary>
		/// Dustox Builder waiting for a Nickname & a Level
		/// </summary>
		public Dustox(string nickname, int level)
		: base(
				269,
				SpecieDustox.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dustox Builder only waiting for a Level
		/// </summary>
		public Dustox(int level)
		: base(
				269,
				SpecieDustox.Instance, // Pokemon Specie
				"Dustox", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dustox Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Dustox() : base(
			269,
			SpecieDustox.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}