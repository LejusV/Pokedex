using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Vespiquen Specie to store common natural stats of all Vespiquens
	#region SpecieVespiquen
	public class SpecieVespiquen : PokemonSpecie
	{
#nullable enable
		private static SpecieVespiquen? _instance = null;
#nullable restore
        public static SpecieVespiquen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVespiquen();
                }
                return _instance;
            }
        }

		#region SpecieVespiquen Builder
		public SpecieVespiquen() : base(
			"Vespiquen",
			70, // HPs
			80, 102, // Attack & Defense
			80, 102, // Special Attack & Defense
			40		
		)
		{
			this._height = 12;
			this._weight = 385;
		}
		#endregion
	}
	#endregion

	//Vespiquen Pokemon Class
	#region Vespiquen
	public class Vespiquen : Pokemon
	{
		#region Vespiquen Builders
		/// <summary>
		/// Vespiquen Builder waiting for a Nickname & a Level
		/// </summary>
		public Vespiquen(string nickname, int level)
		: base(
				416,
				SpecieVespiquen.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vespiquen Builder only waiting for a Level
		/// </summary>
		public Vespiquen(int level)
		: base(
				416,
				SpecieVespiquen.Instance, // Pokemon Specie
				"Vespiquen", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vespiquen Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Vespiquen() : base(
			416,
			SpecieVespiquen.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}