using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vulpix Specie to store common natural stats of all Vulpixs
	#region SpecieVulpix
	public class SpecieVulpix : PokemonSpecie
	{
#nullable enable
		private static SpecieVulpix? _instance = null;
#nullable restore
        public static SpecieVulpix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVulpix();
                }
                return _instance;
            }
        }

		#region SpecieVulpix Builder
		public SpecieVulpix() : base(
			"Vulpix",
			0.6,
			9.9,
			38, // HPs
			41, 40, // Attack & Defense
			50, 65, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Vulpix Pokemon Class
	#region Vulpix
	public class Vulpix : Pokemon
	{
		#region Vulpix Builders
		/// <summary>
		/// Vulpix Builder waiting for a Nickname & a Level
		/// </summary>
		public Vulpix(string nickname, int level)
		: base(
				37,
				SpecieVulpix.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vulpix Builder only waiting for a Level
		/// </summary>
		public Vulpix(int level)
		: base(
				37,
				SpecieVulpix.Instance, // Pokemon Specie
				"Vulpix", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vulpix Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vulpix() : base(
			37,
			SpecieVulpix.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}