using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lycanroc-Midday Specie to store common natural stats of all Lycanroc-Middays
	#region SpecieLycanroc-Midday
	public class SpecieLycanrocMidday : PokemonSpecie
	{
#nullable enable
		private static SpecieLycanrocMidday? _instance = null;
#nullable restore
        public static SpecieLycanrocMidday Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLycanrocMidday();
                }
                return _instance;
            }
        }

		#region SpecieLycanroc-Midday Builder
		public SpecieLycanrocMidday() : base(
			"Lycanroc-Midday",
			75, // HPs
			115, 65, // Attack & Defense
			55, 65, // Special Attack & Defense
			112			
		) {}
		#endregion
	}
	#endregion

	//Lycanroc-Midday Pokemon Class
	#region Lycanroc-Midday
	public class LycanrocMidday : Pokemon
	{
		#region Lycanroc-Midday Builders
		/// <summary>
		/// Lycanroc-Midday Builder waiting for a Nickname & a Level
		/// </summary>
		public LycanrocMidday(string nickname, int level)
		: base(
				745,
				SpecieLycanrocMidday.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lycanroc-Midday Builder only waiting for a Level
		/// </summary>
		public LycanrocMidday(int level)
		: base(
				745,
				SpecieLycanrocMidday.Instance, // Pokemon Specie
				"Lycanroc-Midday", level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lycanroc-Midday Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public LycanrocMidday() : base(
			745,
			SpecieLycanrocMidday.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}