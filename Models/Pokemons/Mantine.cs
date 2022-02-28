using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mantine Specie to store common natural stats of all Mantines
	#region SpecieMantine
	public class SpecieMantine : PokemonSpecie
	{
#nullable enable
		private static SpecieMantine? _instance = null;
#nullable restore
        public static SpecieMantine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMantine();
                }
                return _instance;
            }
        }

		#region SpecieMantine Builder
		public SpecieMantine() : base(
			"Mantine",
			85, // HPs
			40, 70, // Attack & Defense
			80, 140, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Mantine Pokemon Class
	#region Mantine
	public class Mantine : Pokemon
	{
		#region Mantine Builders
		/// <summary>
		/// Mantine Builder waiting for a Nickname & a Level
		/// </summary>
		public Mantine(string nickname, int level)
		: base(
				226,
				SpecieMantine.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantine Builder only waiting for a Level
		/// </summary>
		public Mantine(int level)
		: base(
				226,
				SpecieMantine.Instance, // Pokemon Specie
				"Mantine", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mantine Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mantine() : base(
			226,
			SpecieMantine.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}