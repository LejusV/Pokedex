using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blipbug Specie to store common natural stats of all Blipbugs
	#region SpecieBlipbug
	public class SpecieBlipbug : PokemonSpecie
	{
#nullable enable
		private static SpecieBlipbug? _instance = null;
#nullable restore
        public static SpecieBlipbug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlipbug();
                }
                return _instance;
            }
        }

		#region SpecieBlipbug Builder
		public SpecieBlipbug() : base(
			"Blipbug",
			25, // HPs
			20, 20, // Attack & Defense
			25, 45, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Blipbug Pokemon Class
	#region Blipbug
	public class Blipbug : Pokemon
	{
		#region Blipbug Builders
		/// <summary>
		/// Blipbug Builder waiting for a Nickname & a Level
		/// </summary>
		public Blipbug(string nickname, int level)
		: base(
				824,
				SpecieBlipbug.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blipbug Builder only waiting for a Level
		/// </summary>
		public Blipbug(int level)
		: base(
				824,
				SpecieBlipbug.Instance, // Pokemon Specie
				"Blipbug", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blipbug Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Blipbug() : base(
			824,
			SpecieBlipbug.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}