using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Alomomola Specie to store common natural stats of all Alomomolas
	#region SpecieAlomomola
	public class SpecieAlomomola : PokemonSpecie
	{
#nullable enable
		private static SpecieAlomomola? _instance = null;
#nullable restore
        public static SpecieAlomomola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAlomomola();
                }
                return _instance;
            }
        }

		#region SpecieAlomomola Builder
		public SpecieAlomomola() : base(
			"Alomomola",
			1.2,
			31.6,
			165, // HPs
			75, 80, // Attack & Defense
			40, 45, // Special Attack & Defense
			65		
		)
		{}
		#endregion
	}
	#endregion

	//Alomomola Pokemon Class
	#region Alomomola
	public class Alomomola : Pokemon
	{
		#region Alomomola Builders
		/// <summary>
		/// Alomomola Builder waiting for a Nickname & a Level
		/// </summary>
		public Alomomola(string nickname, int level)
		: base(
				594,
				SpecieAlomomola.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alomomola Builder only waiting for a Level
		/// </summary>
		public Alomomola(int level)
		: base(
				594,
				SpecieAlomomola.Instance, // Pokemon Specie
				"Alomomola", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alomomola Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Alomomola() : base(
			594,
			SpecieAlomomola.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}