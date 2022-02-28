using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Camerupt Specie to store common natural stats of all Camerupts
	#region SpecieCamerupt
	public class SpecieCamerupt : PokemonSpecie
	{
#nullable enable
		private static SpecieCamerupt? _instance = null;
#nullable restore
        public static SpecieCamerupt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCamerupt();
                }
                return _instance;
            }
        }

		#region SpecieCamerupt Builder
		public SpecieCamerupt() : base(
			"Camerupt",
			70, // HPs
			100, 70, // Attack & Defense
			105, 75, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Camerupt Pokemon Class
	#region Camerupt
	public class Camerupt : Pokemon
	{
		#region Camerupt Builders
		/// <summary>
		/// Camerupt Builder waiting for a Nickname & a Level
		/// </summary>
		public Camerupt(string nickname, int level)
		: base(
				323,
				SpecieCamerupt.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Camerupt Builder only waiting for a Level
		/// </summary>
		public Camerupt(int level)
		: base(
				323,
				SpecieCamerupt.Instance, // Pokemon Specie
				"Camerupt", level,
				Fire.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Camerupt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Camerupt() : base(
			323,
			SpecieCamerupt.Instance, // Pokemon Specie
			Fire.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}