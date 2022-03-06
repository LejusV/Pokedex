using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Golem Specie to store common natural stats of all Golems
	#region SpecieGolem
	public class SpecieGolem : PokemonSpecie
	{
#nullable enable
		private static SpecieGolem? _instance = null;
#nullable restore
        public static SpecieGolem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolem();
                }
                return _instance;
            }
        }

		#region SpecieGolem Builder
		public SpecieGolem() : base(
			"Golem",
			1.4,
			300.0,
			80, // HPs
			120, 130, // Attack & Defense
			55, 65, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Golem Pokemon Class
	#region Golem
	public class Golem : Pokemon
	{
		#region Golem Builders
		/// <summary>
		/// Golem Builder waiting for a Nickname & a Level
		/// </summary>
		public Golem(string nickname, int level)
		: base(
				76,
				SpecieGolem.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golem Builder only waiting for a Level
		/// </summary>
		public Golem(int level)
		: base(
				76,
				SpecieGolem.Instance, // Pokemon Specie
				"Golem", level,
				Rock.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Golem Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Golem() : base(
			76,
			SpecieGolem.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}