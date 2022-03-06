using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Ribombee Specie to store common natural stats of all Ribombees
	#region SpecieRibombee
	public class SpecieRibombee : PokemonSpecie
	{
#nullable enable
		private static SpecieRibombee? _instance = null;
#nullable restore
        public static SpecieRibombee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRibombee();
                }
                return _instance;
            }
        }

		#region SpecieRibombee Builder
		public SpecieRibombee() : base(
			"Ribombee",
			60, // HPs
			55, 60, // Attack & Defense
			95, 70, // Special Attack & Defense
			124		
		)
		{
			this._height = 2;
			this._weight = 5;
		}
		#endregion
	}
	#endregion

	//Ribombee Pokemon Class
	#region Ribombee
	public class Ribombee : Pokemon
	{
		#region Ribombee Builders
		/// <summary>
		/// Ribombee Builder waiting for a Nickname & a Level
		/// </summary>
		public Ribombee(string nickname, int level)
		: base(
				743,
				SpecieRibombee.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ribombee Builder only waiting for a Level
		/// </summary>
		public Ribombee(int level)
		: base(
				743,
				SpecieRibombee.Instance, // Pokemon Specie
				"Ribombee", level,
				Bug.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ribombee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Ribombee() : base(
			743,
			SpecieRibombee.Instance, // Pokemon Specie
			Bug.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}