using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spritzee Specie to store common natural stats of all Spritzees
	#region SpecieSpritzee
	public class SpecieSpritzee : PokemonSpecie
	{
#nullable enable
		private static SpecieSpritzee? _instance = null;
#nullable restore
        public static SpecieSpritzee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpritzee();
                }
                return _instance;
            }
        }

		#region SpecieSpritzee Builder
		public SpecieSpritzee() : base(
			"Spritzee",
			78, // HPs
			52, 60, // Attack & Defense
			63, 65, // Special Attack & Defense
			23			
		) {}
		#endregion
	}
	#endregion

	//Spritzee Pokemon Class
	#region Spritzee
	public class Spritzee : Pokemon
	{
		#region Spritzee Builders
		/// <summary>
		/// Spritzee Builder waiting for a Nickname & a Level
		/// </summary>
		public Spritzee(string nickname, int level)
		: base(
				682,
				SpecieSpritzee.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spritzee Builder only waiting for a Level
		/// </summary>
		public Spritzee(int level)
		: base(
				682,
				SpecieSpritzee.Instance, // Pokemon Specie
				"Spritzee", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spritzee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Spritzee() : base(
			682,
			SpecieSpritzee.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}