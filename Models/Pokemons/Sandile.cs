using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandile Specie to store common natural stats of all Sandiles
	#region SpecieSandile
	public class SpecieSandile : PokemonSpecie
	{
#nullable enable
		private static SpecieSandile? _instance = null;
#nullable restore
        public static SpecieSandile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandile();
                }
                return _instance;
            }
        }

		#region SpecieSandile Builder
		public SpecieSandile() : base(
			"Sandile",
			50, // HPs
			72, 35, // Attack & Defense
			35, 35, // Special Attack & Defense
			65			
		) {}
		#endregion
	}
	#endregion

	//Sandile Pokemon Class
	#region Sandile
	public class Sandile : Pokemon
	{
		#region Sandile Builders
		/// <summary>
		/// Sandile Builder waiting for a Nickname & a Level
		/// </summary>
		public Sandile(string nickname, int level)
		: base(
				551,
				SpecieSandile.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandile Builder only waiting for a Level
		/// </summary>
		public Sandile(int level)
		: base(
				551,
				SpecieSandile.Instance, // Pokemon Specie
				"Sandile", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sandile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Sandile() : base(
			551,
			SpecieSandile.Instance, // Pokemon Specie
			Ground.Instance, Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}