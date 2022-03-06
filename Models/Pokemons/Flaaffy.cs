using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Flaaffy Specie to store common natural stats of all Flaaffys
	#region SpecieFlaaffy
	public class SpecieFlaaffy : PokemonSpecie
	{
#nullable enable
		private static SpecieFlaaffy? _instance = null;
#nullable restore
        public static SpecieFlaaffy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlaaffy();
                }
                return _instance;
            }
        }

		#region SpecieFlaaffy Builder
		public SpecieFlaaffy() : base(
			"Flaaffy",
			0.8,
			13.3,
			70, // HPs
			55, 55, // Attack & Defense
			80, 60, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Flaaffy Pokemon Class
	#region Flaaffy
	public class Flaaffy : Pokemon
	{
		#region Flaaffy Builders
		/// <summary>
		/// Flaaffy Builder waiting for a Nickname & a Level
		/// </summary>
		public Flaaffy(string nickname, int level)
		: base(
				180,
				SpecieFlaaffy.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flaaffy Builder only waiting for a Level
		/// </summary>
		public Flaaffy(int level)
		: base(
				180,
				SpecieFlaaffy.Instance, // Pokemon Specie
				"Flaaffy", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flaaffy Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Flaaffy() : base(
			180,
			SpecieFlaaffy.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}