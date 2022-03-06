using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Snover Specie to store common natural stats of all Snovers
	#region SpecieSnover
	public class SpecieSnover : PokemonSpecie
	{
#nullable enable
		private static SpecieSnover? _instance = null;
#nullable restore
        public static SpecieSnover Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnover();
                }
                return _instance;
            }
        }

		#region SpecieSnover Builder
		public SpecieSnover() : base(
			"Snover",
			1.0,
			50.5,
			60, // HPs
			62, 50, // Attack & Defense
			62, 60, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Snover Pokemon Class
	#region Snover
	public class Snover : Pokemon
	{
		#region Snover Builders
		/// <summary>
		/// Snover Builder waiting for a Nickname & a Level
		/// </summary>
		public Snover(string nickname, int level)
		: base(
				459,
				SpecieSnover.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snover Builder only waiting for a Level
		/// </summary>
		public Snover(int level)
		: base(
				459,
				SpecieSnover.Instance, // Pokemon Specie
				"Snover", level,
				Grass.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snover Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Snover() : base(
			459,
			SpecieSnover.Instance, // Pokemon Specie
			Grass.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}