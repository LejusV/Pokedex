using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Larvesta Specie to store common natural stats of all Larvestas
	#region SpecieLarvesta
	public class SpecieLarvesta : PokemonSpecie
	{
#nullable enable
		private static SpecieLarvesta? _instance = null;
#nullable restore
        public static SpecieLarvesta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLarvesta();
                }
                return _instance;
            }
        }

		#region SpecieLarvesta Builder
		public SpecieLarvesta() : base(
			"Larvesta",
			55, // HPs
			85, 55, // Attack & Defense
			50, 55, // Special Attack & Defense
			60			
		) {}
		#endregion
	}
	#endregion

	//Larvesta Pokemon Class
	#region Larvesta
	public class Larvesta : Pokemon
	{
		#region Larvesta Builders
		/// <summary>
		/// Larvesta Builder waiting for a Nickname & a Level
		/// </summary>
		public Larvesta(string nickname, int level)
		: base(
				636,
				SpecieLarvesta.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvesta Builder only waiting for a Level
		/// </summary>
		public Larvesta(int level)
		: base(
				636,
				SpecieLarvesta.Instance, // Pokemon Specie
				"Larvesta", level,
				Bug.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Larvesta Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Larvesta() : base(
			636,
			SpecieLarvesta.Instance, // Pokemon Specie
			Bug.Instance, Fire.Instance			
		) {}
		#endregion
	}
	#endregion
}