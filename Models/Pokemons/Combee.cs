using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Combee Specie to store common natural stats of all Combees
	#region SpecieCombee
	public class SpecieCombee : PokemonSpecie
	{
#nullable enable
		private static SpecieCombee? _instance = null;
#nullable restore
        public static SpecieCombee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCombee();
                }
                return _instance;
            }
        }

		#region SpecieCombee Builder
		public SpecieCombee() : base(
			"Combee",
			0.3,
			5.5,
			30, // HPs
			30, 42, // Attack & Defense
			30, 42, // Special Attack & Defense
			70		
		)
		{}
		#endregion
	}
	#endregion

	//Combee Pokemon Class
	#region Combee
	public class Combee : Pokemon
	{
		#region Combee Builders
		/// <summary>
		/// Combee Builder waiting for a Nickname & a Level
		/// </summary>
		public Combee(string nickname, int level)
		: base(
				415,
				SpecieCombee.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combee Builder only waiting for a Level
		/// </summary>
		public Combee(int level)
		: base(
				415,
				SpecieCombee.Instance, // Pokemon Specie
				"Combee", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Combee Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Combee() : base(
			415,
			SpecieCombee.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}