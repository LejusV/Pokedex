using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Corvisquire Specie to store common natural stats of all Corvisquires
	#region SpecieCorvisquire
	public class SpecieCorvisquire : PokemonSpecie
	{
#nullable enable
		private static SpecieCorvisquire? _instance = null;
#nullable restore
        public static SpecieCorvisquire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorvisquire();
                }
                return _instance;
            }
        }

		#region SpecieCorvisquire Builder
		public SpecieCorvisquire() : base(
			"Corvisquire",
			0.8,
			16.0,
			68, // HPs
			67, 55, // Attack & Defense
			43, 55, // Special Attack & Defense
			77		
		)
		{}
		#endregion
	}
	#endregion

	//Corvisquire Pokemon Class
	#region Corvisquire
	public class Corvisquire : Pokemon
	{
		#region Corvisquire Builders
		/// <summary>
		/// Corvisquire Builder waiting for a Nickname & a Level
		/// </summary>
		public Corvisquire(string nickname, int level)
		: base(
				822,
				SpecieCorvisquire.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corvisquire Builder only waiting for a Level
		/// </summary>
		public Corvisquire(int level)
		: base(
				822,
				SpecieCorvisquire.Instance, // Pokemon Specie
				"Corvisquire", level,
				Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corvisquire Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Corvisquire() : base(
			822,
			SpecieCorvisquire.Instance, // Pokemon Specie
			Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}