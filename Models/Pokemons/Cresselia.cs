using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cresselia Specie to store common natural stats of all Cresselias
	#region SpecieCresselia
	public class SpecieCresselia : PokemonSpecie
	{
#nullable enable
		private static SpecieCresselia? _instance = null;
#nullable restore
        public static SpecieCresselia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCresselia();
                }
                return _instance;
            }
        }

		#region SpecieCresselia Builder
		public SpecieCresselia() : base(
			"Cresselia",
			120, // HPs
			70, 120, // Attack & Defense
			75, 130, // Special Attack & Defense
			85			
		) {}
		#endregion
	}
	#endregion

	//Cresselia Pokemon Class
	#region Cresselia
	public class Cresselia : Pokemon
	{
		#region Cresselia Builders
		/// <summary>
		/// Cresselia Builder waiting for a Nickname & a Level
		/// </summary>
		public Cresselia(string nickname, int level)
		: base(
				488,
				SpecieCresselia.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cresselia Builder only waiting for a Level
		/// </summary>
		public Cresselia(int level)
		: base(
				488,
				SpecieCresselia.Instance, // Pokemon Specie
				"Cresselia", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cresselia Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cresselia() : base(
			488,
			SpecieCresselia.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}