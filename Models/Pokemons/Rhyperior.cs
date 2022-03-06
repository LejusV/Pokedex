using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rhyperior Specie to store common natural stats of all Rhyperiors
	#region SpecieRhyperior
	public class SpecieRhyperior : PokemonSpecie
	{
#nullable enable
		private static SpecieRhyperior? _instance = null;
#nullable restore
        public static SpecieRhyperior Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRhyperior();
                }
                return _instance;
            }
        }

		#region SpecieRhyperior Builder
		public SpecieRhyperior() : base(
			"Rhyperior",
			2.4,
			282.8,
			115, // HPs
			140, 130, // Attack & Defense
			55, 55, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Rhyperior Pokemon Class
	#region Rhyperior
	public class Rhyperior : Pokemon
	{
		#region Rhyperior Builders
		/// <summary>
		/// Rhyperior Builder waiting for a Nickname & a Level
		/// </summary>
		public Rhyperior(string nickname, int level)
		: base(
				464,
				SpecieRhyperior.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyperior Builder only waiting for a Level
		/// </summary>
		public Rhyperior(int level)
		: base(
				464,
				SpecieRhyperior.Instance, // Pokemon Specie
				"Rhyperior", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhyperior Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rhyperior() : base(
			464,
			SpecieRhyperior.Instance, // Pokemon Specie
			Ground.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}