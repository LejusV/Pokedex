using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Turtonator Specie to store common natural stats of all Turtonators
	#region SpecieTurtonator
	public class SpecieTurtonator : PokemonSpecie
	{
#nullable enable
		private static SpecieTurtonator? _instance = null;
#nullable restore
        public static SpecieTurtonator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTurtonator();
                }
                return _instance;
            }
        }

		#region SpecieTurtonator Builder
		public SpecieTurtonator() : base(
			"Turtonator",
			60, // HPs
			78, 135, // Attack & Defense
			91, 85, // Special Attack & Defense
			36			
		) {}
		#endregion
	}
	#endregion

	//Turtonator Pokemon Class
	#region Turtonator
	public class Turtonator : Pokemon
	{
		#region Turtonator Builders
		/// <summary>
		/// Turtonator Builder waiting for a Nickname & a Level
		/// </summary>
		public Turtonator(string nickname, int level)
		: base(
				776,
				SpecieTurtonator.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtonator Builder only waiting for a Level
		/// </summary>
		public Turtonator(int level)
		: base(
				776,
				SpecieTurtonator.Instance, // Pokemon Specie
				"Turtonator", level,
				Fire.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Turtonator Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Turtonator() : base(
			776,
			SpecieTurtonator.Instance, // Pokemon Specie
			Fire.Instance, Dragon.Instance			
		) {}
		#endregion
	}
	#endregion
}