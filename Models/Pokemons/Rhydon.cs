using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Rhydon Specie to store common natural stats of all Rhydons
	#region SpecieRhydon
	public class SpecieRhydon : PokemonSpecie
	{
#nullable enable
		private static SpecieRhydon? _instance = null;
#nullable restore
        public static SpecieRhydon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRhydon();
                }
                return _instance;
            }
        }

		#region SpecieRhydon Builder
		public SpecieRhydon() : base(
			"Rhydon",
			1.9,
			120.0,
			105, // HPs
			130, 120, // Attack & Defense
			45, 45, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Rhydon Pokemon Class
	#region Rhydon
	public class Rhydon : Pokemon
	{
		#region Rhydon Builders
		/// <summary>
		/// Rhydon Builder waiting for a Nickname & a Level
		/// </summary>
		public Rhydon(string nickname, int level)
		: base(
				112,
				SpecieRhydon.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhydon Builder only waiting for a Level
		/// </summary>
		public Rhydon(int level)
		: base(
				112,
				SpecieRhydon.Instance, // Pokemon Specie
				"Rhydon", level,
				Ground.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rhydon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Rhydon() : base(
			112,
			SpecieRhydon.Instance, // Pokemon Specie
			Ground.Instance, Rock.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}