using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rookidee Specie to store common natural stats of all Rookidees
	#region SpecieRookidee
	public class SpecieRookidee : PokemonSpecie
	{
#nullable enable
		private static SpecieRookidee? _instance = null;
#nullable restore
        public static SpecieRookidee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRookidee();
                }
                return _instance;
            }
        }

		#region SpecieRookidee Builder
		public SpecieRookidee() : base(
			"Rookidee",
			38, // HPs
			47, 35, // Attack & Defense
			33, 35, // Special Attack & Defense
			57			
		) {}
		#endregion
	}
	#endregion

	//Rookidee Pokemon Class
	#region Rookidee
	public class Rookidee : Pokemon
	{
		#region Rookidee Builders
		/// <summary>
		/// Rookidee Builder waiting for a Nickname & a Level
		/// </summary>
		public Rookidee(string nickname, int level)
		: base(
				821,
				SpecieRookidee.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rookidee Builder only waiting for a Level
		/// </summary>
		public Rookidee(int level)
		: base(
				821,
				SpecieRookidee.Instance, // Pokemon Specie
				"Rookidee", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rookidee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Rookidee() : base(
			821,
			SpecieRookidee.Instance, // Pokemon Specie
			Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}