using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Chesnaught Specie to store common natural stats of all Chesnaughts
	#region SpecieChesnaught
	public class SpecieChesnaught : PokemonSpecie
	{
#nullable enable
		private static SpecieChesnaught? _instance = null;
#nullable restore
        public static SpecieChesnaught Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChesnaught();
                }
                return _instance;
            }
        }

		#region SpecieChesnaught Builder
		public SpecieChesnaught() : base(
			"Chesnaught",
			88, // HPs
			107, 122, // Attack & Defense
			74, 75, // Special Attack & Defense
			64		
		)
		{
			this._height = 16;
			this._weight = 900;
		}
		#endregion
	}
	#endregion

	//Chesnaught Pokemon Class
	#region Chesnaught
	public class Chesnaught : Pokemon
	{
		#region Chesnaught Builders
		/// <summary>
		/// Chesnaught Builder waiting for a Nickname & a Level
		/// </summary>
		public Chesnaught(string nickname, int level)
		: base(
				652,
				SpecieChesnaught.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chesnaught Builder only waiting for a Level
		/// </summary>
		public Chesnaught(int level)
		: base(
				652,
				SpecieChesnaught.Instance, // Pokemon Specie
				"Chesnaught", level,
				Grass.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chesnaught Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Chesnaught() : base(
			652,
			SpecieChesnaught.Instance, // Pokemon Specie
			Grass.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}