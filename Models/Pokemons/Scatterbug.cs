using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scatterbug Specie to store common natural stats of all Scatterbugs
	#region SpecieScatterbug
	public class SpecieScatterbug : PokemonSpecie
	{
#nullable enable
		private static SpecieScatterbug? _instance = null;
#nullable restore
        public static SpecieScatterbug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScatterbug();
                }
                return _instance;
            }
        }

		#region SpecieScatterbug Builder
		public SpecieScatterbug() : base(
			"Scatterbug",
			38, // HPs
			35, 40, // Attack & Defense
			27, 25, // Special Attack & Defense
			35			
		) {}
		#endregion
	}
	#endregion

	//Scatterbug Pokemon Class
	#region Scatterbug
	public class Scatterbug : Pokemon
	{
		#region Scatterbug Builders
		/// <summary>
		/// Scatterbug Builder waiting for a Nickname & a Level
		/// </summary>
		public Scatterbug(string nickname, int level)
		: base(
				664,
				SpecieScatterbug.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scatterbug Builder only waiting for a Level
		/// </summary>
		public Scatterbug(int level)
		: base(
				664,
				SpecieScatterbug.Instance, // Pokemon Specie
				"Scatterbug", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scatterbug Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Scatterbug() : base(
			664,
			SpecieScatterbug.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
		#endregion
	}
	#endregion
}