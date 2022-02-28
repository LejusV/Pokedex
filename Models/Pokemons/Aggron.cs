using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aggron Specie to store common natural stats of all Aggrons
	#region SpecieAggron
	public class SpecieAggron : PokemonSpecie
	{
#nullable enable
		private static SpecieAggron? _instance = null;
#nullable restore
        public static SpecieAggron Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAggron();
                }
                return _instance;
            }
        }

		#region SpecieAggron Builder
		public SpecieAggron() : base(
			"Aggron",
			70, // HPs
			110, 180, // Attack & Defense
			60, 60, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Aggron Pokemon Class
	#region Aggron
	public class Aggron : Pokemon
	{
		#region Aggron Builders
		/// <summary>
		/// Aggron Builder waiting for a Nickname & a Level
		/// </summary>
		public Aggron(string nickname, int level)
		: base(
				306,
				SpecieAggron.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aggron Builder only waiting for a Level
		/// </summary>
		public Aggron(int level)
		: base(
				306,
				SpecieAggron.Instance, // Pokemon Specie
				"Aggron", level,
				Steel.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aggron Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Aggron() : base(
			306,
			SpecieAggron.Instance, // Pokemon Specie
			Steel.Instance, Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}