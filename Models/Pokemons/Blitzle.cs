using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blitzle Specie to store common natural stats of all Blitzles
	#region SpecieBlitzle
	public class SpecieBlitzle : PokemonSpecie
	{
#nullable enable
		private static SpecieBlitzle? _instance = null;
#nullable restore
        public static SpecieBlitzle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlitzle();
                }
                return _instance;
            }
        }

		#region SpecieBlitzle Builder
		public SpecieBlitzle() : base(
			"Blitzle",
			45, // HPs
			60, 32, // Attack & Defense
			50, 32, // Special Attack & Defense
			76			
		) {}
		#endregion
	}
	#endregion

	//Blitzle Pokemon Class
	#region Blitzle
	public class Blitzle : Pokemon
	{
		#region Blitzle Builders
		/// <summary>
		/// Blitzle Builder waiting for a Nickname & a Level
		/// </summary>
		public Blitzle(string nickname, int level)
		: base(
				522,
				SpecieBlitzle.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blitzle Builder only waiting for a Level
		/// </summary>
		public Blitzle(int level)
		: base(
				522,
				SpecieBlitzle.Instance, // Pokemon Specie
				"Blitzle", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blitzle Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Blitzle() : base(
			522,
			SpecieBlitzle.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}