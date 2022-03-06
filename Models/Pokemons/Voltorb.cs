using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Voltorb Specie to store common natural stats of all Voltorbs
	#region SpecieVoltorb
	public class SpecieVoltorb : PokemonSpecie
	{
#nullable enable
		private static SpecieVoltorb? _instance = null;
#nullable restore
        public static SpecieVoltorb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVoltorb();
                }
                return _instance;
            }
        }

		#region SpecieVoltorb Builder
		public SpecieVoltorb() : base(
			"Voltorb",
			40, // HPs
			30, 50, // Attack & Defense
			55, 55, // Special Attack & Defense
			100		
		)
		{
			this._height = 5;
			this._weight = 104;
		}
		#endregion
	}
	#endregion

	//Voltorb Pokemon Class
	#region Voltorb
	public class Voltorb : Pokemon
	{
		#region Voltorb Builders
		/// <summary>
		/// Voltorb Builder waiting for a Nickname & a Level
		/// </summary>
		public Voltorb(string nickname, int level)
		: base(
				100,
				SpecieVoltorb.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Voltorb Builder only waiting for a Level
		/// </summary>
		public Voltorb(int level)
		: base(
				100,
				SpecieVoltorb.Instance, // Pokemon Specie
				"Voltorb", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Voltorb Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Voltorb() : base(
			100,
			SpecieVoltorb.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}