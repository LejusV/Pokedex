using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chatot Specie to store common natural stats of all Chatots
	#region SpecieChatot
	public class SpecieChatot : PokemonSpecie
	{
#nullable enable
		private static SpecieChatot? _instance = null;
#nullable restore
        public static SpecieChatot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChatot();
                }
                return _instance;
            }
        }

		#region SpecieChatot Builder
		public SpecieChatot() : base(
			"Chatot",
			76, // HPs
			65, 45, // Attack & Defense
			92, 42, // Special Attack & Defense
			91			
		) {}
		#endregion
	}
	#endregion

	//Chatot Pokemon Class
	#region Chatot
	public class Chatot : Pokemon
	{
		#region Chatot Builders
		/// <summary>
		/// Chatot Builder waiting for a Nickname & a Level
		/// </summary>
		public Chatot(string nickname, int level)
		: base(
				441,
				SpecieChatot.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chatot Builder only waiting for a Level
		/// </summary>
		public Chatot(int level)
		: base(
				441,
				SpecieChatot.Instance, // Pokemon Specie
				"Chatot", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chatot Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Chatot() : base(
			441,
			SpecieChatot.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}