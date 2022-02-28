using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Archeops Specie to store common natural stats of all Archeopss
	#region SpecieArcheops
	public class SpecieArcheops : PokemonSpecie
	{
#nullable enable
		private static SpecieArcheops? _instance = null;
#nullable restore
        public static SpecieArcheops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArcheops();
                }
                return _instance;
            }
        }

		#region SpecieArcheops Builder
		public SpecieArcheops() : base(
			"Archeops",
			75, // HPs
			140, 65, // Attack & Defense
			112, 65, // Special Attack & Defense
			110			
		) {}
		#endregion
	}
	#endregion

	//Archeops Pokemon Class
	#region Archeops
	public class Archeops : Pokemon
	{
		#region Archeops Builders
		/// <summary>
		/// Archeops Builder waiting for a Nickname & a Level
		/// </summary>
		public Archeops(string nickname, int level)
		: base(
				567,
				SpecieArcheops.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archeops Builder only waiting for a Level
		/// </summary>
		public Archeops(int level)
		: base(
				567,
				SpecieArcheops.Instance, // Pokemon Specie
				"Archeops", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archeops Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Archeops() : base(
			567,
			SpecieArcheops.Instance, // Pokemon Specie
			Rock.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}