using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Blacephalon Specie to store common natural stats of all Blacephalons
	#region SpecieBlacephalon
	public class SpecieBlacephalon : PokemonSpecie
	{
#nullable enable
		private static SpecieBlacephalon? _instance = null;
#nullable restore
        public static SpecieBlacephalon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlacephalon();
                }
                return _instance;
            }
        }

		#region SpecieBlacephalon Builder
		public SpecieBlacephalon() : base(
			"Blacephalon",
			53, // HPs
			127, 53, // Attack & Defense
			151, 79, // Special Attack & Defense
			107		
		)
		{
			this._height = 18;
			this._weight = 130;
		}
		#endregion
	}
	#endregion

	//Blacephalon Pokemon Class
	#region Blacephalon
	public class Blacephalon : Pokemon
	{
		#region Blacephalon Builders
		/// <summary>
		/// Blacephalon Builder waiting for a Nickname & a Level
		/// </summary>
		public Blacephalon(string nickname, int level)
		: base(
				806,
				SpecieBlacephalon.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blacephalon Builder only waiting for a Level
		/// </summary>
		public Blacephalon(int level)
		: base(
				806,
				SpecieBlacephalon.Instance, // Pokemon Specie
				"Blacephalon", level,
				Fire.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Blacephalon Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Blacephalon() : base(
			806,
			SpecieBlacephalon.Instance, // Pokemon Specie
			Fire.Instance, Ghost.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}