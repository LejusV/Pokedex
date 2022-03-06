using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Sawsbuck Specie to store common natural stats of all Sawsbucks
	#region SpecieSawsbuck
	public class SpecieSawsbuck : PokemonSpecie
	{
#nullable enable
		private static SpecieSawsbuck? _instance = null;
#nullable restore
        public static SpecieSawsbuck Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSawsbuck();
                }
                return _instance;
            }
        }

		#region SpecieSawsbuck Builder
		public SpecieSawsbuck() : base(
			"Sawsbuck",
			1.9,
			92.5,
			80, // HPs
			100, 70, // Attack & Defense
			60, 70, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Sawsbuck Pokemon Class
	#region Sawsbuck
	public class Sawsbuck : Pokemon
	{
		#region Sawsbuck Builders
		/// <summary>
		/// Sawsbuck Builder waiting for a Nickname & a Level
		/// </summary>
		public Sawsbuck(string nickname, int level)
		: base(
				586,
				SpecieSawsbuck.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawsbuck Builder only waiting for a Level
		/// </summary>
		public Sawsbuck(int level)
		: base(
				586,
				SpecieSawsbuck.Instance, // Pokemon Specie
				"Sawsbuck", level,
				Normal.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sawsbuck Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Sawsbuck() : base(
			586,
			SpecieSawsbuck.Instance, // Pokemon Specie
			Normal.Instance, Grass.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}