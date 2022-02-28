using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chespin Specie to store common natural stats of all Chespins
	#region SpecieChespin
	public class SpecieChespin : PokemonSpecie
	{
#nullable enable
		private static SpecieChespin? _instance = null;
#nullable restore
        public static SpecieChespin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChespin();
                }
                return _instance;
            }
        }

		#region SpecieChespin Builder
		public SpecieChespin() : base(
			"Chespin",
			56, // HPs
			61, 65, // Attack & Defense
			48, 45, // Special Attack & Defense
			38			
		) {}
		#endregion
	}
	#endregion

	//Chespin Pokemon Class
	#region Chespin
	public class Chespin : Pokemon
	{
		#region Chespin Builders
		/// <summary>
		/// Chespin Builder waiting for a Nickname & a Level
		/// </summary>
		public Chespin(string nickname, int level)
		: base(
				650,
				SpecieChespin.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chespin Builder only waiting for a Level
		/// </summary>
		public Chespin(int level)
		: base(
				650,
				SpecieChespin.Instance, // Pokemon Specie
				"Chespin", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chespin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Chespin() : base(
			650,
			SpecieChespin.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		#endregion
	}
	#endregion
}