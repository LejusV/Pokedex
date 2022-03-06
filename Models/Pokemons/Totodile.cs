using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Totodile Specie to store common natural stats of all Totodiles
	#region SpecieTotodile
	public class SpecieTotodile : PokemonSpecie
	{
#nullable enable
		private static SpecieTotodile? _instance = null;
#nullable restore
        public static SpecieTotodile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTotodile();
                }
                return _instance;
            }
        }

		#region SpecieTotodile Builder
		public SpecieTotodile() : base(
			"Totodile",
			50, // HPs
			65, 64, // Attack & Defense
			44, 48, // Special Attack & Defense
			43		
		)
		{
			this._height = 6;
			this._weight = 95;
		}
		#endregion
	}
	#endregion

	//Totodile Pokemon Class
	#region Totodile
	public class Totodile : Pokemon
	{
		#region Totodile Builders
		/// <summary>
		/// Totodile Builder waiting for a Nickname & a Level
		/// </summary>
		public Totodile(string nickname, int level)
		: base(
				158,
				SpecieTotodile.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Totodile Builder only waiting for a Level
		/// </summary>
		public Totodile(int level)
		: base(
				158,
				SpecieTotodile.Instance, // Pokemon Specie
				"Totodile", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Totodile Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Totodile() : base(
			158,
			SpecieTotodile.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}