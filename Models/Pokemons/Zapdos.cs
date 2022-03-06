using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Zapdos Specie to store common natural stats of all Zapdoss
	#region SpecieZapdos
	public class SpecieZapdos : PokemonSpecie
	{
#nullable enable
		private static SpecieZapdos? _instance = null;
#nullable restore
        public static SpecieZapdos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZapdos();
                }
                return _instance;
            }
        }

		#region SpecieZapdos Builder
		public SpecieZapdos() : base(
			"Zapdos",
			90, // HPs
			90, 85, // Attack & Defense
			125, 90, // Special Attack & Defense
			100		
		)
		{
			this._height = 16;
			this._weight = 526;
		}
		#endregion
	}
	#endregion

	//Zapdos Pokemon Class
	#region Zapdos
	public class Zapdos : Pokemon
	{
		#region Zapdos Builders
		/// <summary>
		/// Zapdos Builder waiting for a Nickname & a Level
		/// </summary>
		public Zapdos(string nickname, int level)
		: base(
				145,
				SpecieZapdos.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zapdos Builder only waiting for a Level
		/// </summary>
		public Zapdos(int level)
		: base(
				145,
				SpecieZapdos.Instance, // Pokemon Specie
				"Zapdos", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Zapdos Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Zapdos() : base(
			145,
			SpecieZapdos.Instance, // Pokemon Specie
			Electric.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}