using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Bounsweet Specie to store common natural stats of all Bounsweets
	#region SpecieBounsweet
	public class SpecieBounsweet : PokemonSpecie
	{
#nullable enable
		private static SpecieBounsweet? _instance = null;
#nullable restore
        public static SpecieBounsweet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBounsweet();
                }
                return _instance;
            }
        }

		#region SpecieBounsweet Builder
		public SpecieBounsweet() : base(
			"Bounsweet",
			0.3,
			3.2,
			42, // HPs
			30, 38, // Attack & Defense
			30, 38, // Special Attack & Defense
			32		
		)
		{}
		#endregion
	}
	#endregion

	//Bounsweet Pokemon Class
	#region Bounsweet
	public class Bounsweet : Pokemon
	{
		#region Bounsweet Builders
		/// <summary>
		/// Bounsweet Builder waiting for a Nickname & a Level
		/// </summary>
		public Bounsweet(string nickname, int level)
		: base(
				761,
				SpecieBounsweet.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bounsweet Builder only waiting for a Level
		/// </summary>
		public Bounsweet(int level)
		: base(
				761,
				SpecieBounsweet.Instance, // Pokemon Specie
				"Bounsweet", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bounsweet Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Bounsweet() : base(
			761,
			SpecieBounsweet.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}