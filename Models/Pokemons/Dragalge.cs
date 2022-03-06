using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Dragalge Specie to store common natural stats of all Dragalges
	#region SpecieDragalge
	public class SpecieDragalge : PokemonSpecie
	{
#nullable enable
		private static SpecieDragalge? _instance = null;
#nullable restore
        public static SpecieDragalge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragalge();
                }
                return _instance;
            }
        }

		#region SpecieDragalge Builder
		public SpecieDragalge() : base(
			"Dragalge",
			1.8,
			81.5,
			65, // HPs
			75, 90, // Attack & Defense
			97, 123, // Special Attack & Defense
			44		
		)
		{}
		#endregion
	}
	#endregion

	//Dragalge Pokemon Class
	#region Dragalge
	public class Dragalge : Pokemon
	{
		#region Dragalge Builders
		/// <summary>
		/// Dragalge Builder waiting for a Nickname & a Level
		/// </summary>
		public Dragalge(string nickname, int level)
		: base(
				691,
				SpecieDragalge.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragalge Builder only waiting for a Level
		/// </summary>
		public Dragalge(int level)
		: base(
				691,
				SpecieDragalge.Instance, // Pokemon Specie
				"Dragalge", level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dragalge Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Dragalge() : base(
			691,
			SpecieDragalge.Instance, // Pokemon Specie
			Poison.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}