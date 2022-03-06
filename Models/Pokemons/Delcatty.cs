using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Delcatty Specie to store common natural stats of all Delcattys
	#region SpecieDelcatty
	public class SpecieDelcatty : PokemonSpecie
	{
#nullable enable
		private static SpecieDelcatty? _instance = null;
#nullable restore
        public static SpecieDelcatty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDelcatty();
                }
                return _instance;
            }
        }

		#region SpecieDelcatty Builder
		public SpecieDelcatty() : base(
			"Delcatty",
			70, // HPs
			65, 65, // Attack & Defense
			55, 55, // Special Attack & Defense
			90		
		)
		{
			this._height = 11;
			this._weight = 326;
		}
		#endregion
	}
	#endregion

	//Delcatty Pokemon Class
	#region Delcatty
	public class Delcatty : Pokemon
	{
		#region Delcatty Builders
		/// <summary>
		/// Delcatty Builder waiting for a Nickname & a Level
		/// </summary>
		public Delcatty(string nickname, int level)
		: base(
				301,
				SpecieDelcatty.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delcatty Builder only waiting for a Level
		/// </summary>
		public Delcatty(int level)
		: base(
				301,
				SpecieDelcatty.Instance, // Pokemon Specie
				"Delcatty", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delcatty Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Delcatty() : base(
			301,
			SpecieDelcatty.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}