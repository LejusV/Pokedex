using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skorupi Specie to store common natural stats of all Skorupis
	#region SpecieSkorupi
	public class SpecieSkorupi : PokemonSpecie
	{
#nullable enable
		private static SpecieSkorupi? _instance = null;
#nullable restore
        public static SpecieSkorupi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkorupi();
                }
                return _instance;
            }
        }

		#region SpecieSkorupi Builder
		public SpecieSkorupi() : base(
			"Skorupi",
			40, // HPs
			50, 90, // Attack & Defense
			30, 55, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Skorupi Pokemon Class
	#region Skorupi
	public class Skorupi : Pokemon
	{
		#region Skorupi Builders
		/// <summary>
		/// Skorupi Builder waiting for a Nickname & a Level
		/// </summary>
		public Skorupi(string nickname, int level)
		: base(
				451,
				SpecieSkorupi.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skorupi Builder only waiting for a Level
		/// </summary>
		public Skorupi(int level)
		: base(
				451,
				SpecieSkorupi.Instance, // Pokemon Specie
				"Skorupi", level,
				Poison.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Skorupi Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Skorupi() : base(
			451,
			SpecieSkorupi.Instance, // Pokemon Specie
			Poison.Instance, Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}