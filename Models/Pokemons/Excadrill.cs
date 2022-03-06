using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Excadrill Specie to store common natural stats of all Excadrills
	#region SpecieExcadrill
	public class SpecieExcadrill : PokemonSpecie
	{
#nullable enable
		private static SpecieExcadrill? _instance = null;
#nullable restore
        public static SpecieExcadrill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieExcadrill();
                }
                return _instance;
            }
        }

		#region SpecieExcadrill Builder
		public SpecieExcadrill() : base(
			"Excadrill",
			0.7,
			40.4,
			110, // HPs
			135, 60, // Attack & Defense
			50, 65, // Special Attack & Defense
			88		
		)
		{}
		#endregion
	}
	#endregion

	//Excadrill Pokemon Class
	#region Excadrill
	public class Excadrill : Pokemon
	{
		#region Excadrill Builders
		/// <summary>
		/// Excadrill Builder waiting for a Nickname & a Level
		/// </summary>
		public Excadrill(string nickname, int level)
		: base(
				530,
				SpecieExcadrill.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Excadrill Builder only waiting for a Level
		/// </summary>
		public Excadrill(int level)
		: base(
				530,
				SpecieExcadrill.Instance, // Pokemon Specie
				"Excadrill", level,
				Ground.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Excadrill Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Excadrill() : base(
			530,
			SpecieExcadrill.Instance, // Pokemon Specie
			Ground.Instance, Steel.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}