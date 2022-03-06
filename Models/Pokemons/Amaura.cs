using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Amaura Specie to store common natural stats of all Amauras
	#region SpecieAmaura
	public class SpecieAmaura : PokemonSpecie
	{
#nullable enable
		private static SpecieAmaura? _instance = null;
#nullable restore
        public static SpecieAmaura Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmaura();
                }
                return _instance;
            }
        }

		#region SpecieAmaura Builder
		public SpecieAmaura() : base(
			"Amaura",
			77, // HPs
			59, 50, // Attack & Defense
			67, 63, // Special Attack & Defense
			46		
		)
		{
			this._height = 13;
			this._weight = 252;
		}
		#endregion
	}
	#endregion

	//Amaura Pokemon Class
	#region Amaura
	public class Amaura : Pokemon
	{
		#region Amaura Builders
		/// <summary>
		/// Amaura Builder waiting for a Nickname & a Level
		/// </summary>
		public Amaura(string nickname, int level)
		: base(
				698,
				SpecieAmaura.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amaura Builder only waiting for a Level
		/// </summary>
		public Amaura(int level)
		: base(
				698,
				SpecieAmaura.Instance, // Pokemon Specie
				"Amaura", level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Amaura Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Amaura() : base(
			698,
			SpecieAmaura.Instance, // Pokemon Specie
			Rock.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}