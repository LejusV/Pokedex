using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rufflet Specie to store common natural stats of all Rufflets
	#region SpecieRufflet
	public class SpecieRufflet : PokemonSpecie
	{
#nullable enable
		private static SpecieRufflet? _instance = null;
#nullable restore
        public static SpecieRufflet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRufflet();
                }
                return _instance;
            }
        }

		#region SpecieRufflet Builder
		public SpecieRufflet() : base(
			"Rufflet",
			70, // HPs
			83, 50, // Attack & Defense
			37, 50, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Rufflet Pokemon Class
	#region Rufflet
	public class Rufflet : Pokemon
	{
		#region Rufflet Builders
		/// <summary>
		/// Rufflet Builder waiting for a Nickname & a Level
		/// </summary>
		public Rufflet(string nickname, int level)
		: base(
				627,
				SpecieRufflet.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rufflet Builder only waiting for a Level
		/// </summary>
		public Rufflet(int level)
		: base(
				627,
				SpecieRufflet.Instance, // Pokemon Specie
				"Rufflet", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rufflet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rufflet() : base(
			627,
			SpecieRufflet.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}