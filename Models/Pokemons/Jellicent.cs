using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jellicent Specie to store common natural stats of all Jellicents
	#region SpecieJellicent
	public class SpecieJellicent : PokemonSpecie
	{
#nullable enable
		private static SpecieJellicent? _instance = null;
#nullable restore
        public static SpecieJellicent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJellicent();
                }
                return _instance;
            }
        }

		#region SpecieJellicent Builder
		public SpecieJellicent() : base(
			"Jellicent",
			100, // HPs
			60, 70, // Attack & Defense
			85, 105, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Jellicent Pokemon Class
	#region Jellicent
	public class Jellicent : Pokemon
	{
		#region Jellicent Builders
		/// <summary>
		/// Jellicent Builder waiting for a Nickname & a Level
		/// </summary>
		public Jellicent(string nickname, int level)
		: base(
				593,
				SpecieJellicent.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jellicent Builder only waiting for a Level
		/// </summary>
		public Jellicent(int level)
		: base(
				593,
				SpecieJellicent.Instance, // Pokemon Specie
				"Jellicent", level,
				Water.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jellicent Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Jellicent() : base(
			593,
			SpecieJellicent.Instance, // Pokemon Specie
			Water.Instance, Ghost.Instance			
		) {}
		#endregion
	}
	#endregion
}