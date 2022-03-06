using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Omanyte Specie to store common natural stats of all Omanytes
	#region SpecieOmanyte
	public class SpecieOmanyte : PokemonSpecie
	{
#nullable enable
		private static SpecieOmanyte? _instance = null;
#nullable restore
        public static SpecieOmanyte Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOmanyte();
                }
                return _instance;
            }
        }

		#region SpecieOmanyte Builder
		public SpecieOmanyte() : base(
			"Omanyte",
			35, // HPs
			40, 100, // Attack & Defense
			90, 55, // Special Attack & Defense
			35		
		)
		{
			this._height = 4;
			this._weight = 75;
		}
		#endregion
	}
	#endregion

	//Omanyte Pokemon Class
	#region Omanyte
	public class Omanyte : Pokemon
	{
		#region Omanyte Builders
		/// <summary>
		/// Omanyte Builder waiting for a Nickname & a Level
		/// </summary>
		public Omanyte(string nickname, int level)
		: base(
				138,
				SpecieOmanyte.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omanyte Builder only waiting for a Level
		/// </summary>
		public Omanyte(int level)
		: base(
				138,
				SpecieOmanyte.Instance, // Pokemon Specie
				"Omanyte", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Omanyte Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Omanyte() : base(
			138,
			SpecieOmanyte.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}