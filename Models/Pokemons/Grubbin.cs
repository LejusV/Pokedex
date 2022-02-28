using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grubbin Specie to store common natural stats of all Grubbins
	#region SpecieGrubbin
	public class SpecieGrubbin : PokemonSpecie
	{
#nullable enable
		private static SpecieGrubbin? _instance = null;
#nullable restore
        public static SpecieGrubbin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrubbin();
                }
                return _instance;
            }
        }

		#region SpecieGrubbin Builder
		public SpecieGrubbin() : base(
			"Grubbin",
			47, // HPs
			62, 45, // Attack & Defense
			55, 45, // Special Attack & Defense
			46			
		) {}
		#endregion
	}
	#endregion

	//Grubbin Pokemon Class
	#region Grubbin
	public class Grubbin : Pokemon
	{
		#region Grubbin Builders
		/// <summary>
		/// Grubbin Builder waiting for a Nickname & a Level
		/// </summary>
		public Grubbin(string nickname, int level)
		: base(
				736,
				SpecieGrubbin.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grubbin Builder only waiting for a Level
		/// </summary>
		public Grubbin(int level)
		: base(
				736,
				SpecieGrubbin.Instance, // Pokemon Specie
				"Grubbin", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Grubbin Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Grubbin() : base(
			736,
			SpecieGrubbin.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}