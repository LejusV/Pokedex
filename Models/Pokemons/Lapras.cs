using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lapras Specie to store common natural stats of all Laprass
	#region SpecieLapras
	public class SpecieLapras : PokemonSpecie
	{
#nullable enable
		private static SpecieLapras? _instance = null;
#nullable restore
        public static SpecieLapras Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLapras();
                }
                return _instance;
            }
        }

		#region SpecieLapras Builder
		public SpecieLapras() : base(
			"Lapras",
			130, // HPs
			85, 80, // Attack & Defense
			85, 95, // Special Attack & Defense
			60		
		)
		{
			this._height = 25;
			this._weight = 2200;
		}
		#endregion
	}
	#endregion

	//Lapras Pokemon Class
	#region Lapras
	public class Lapras : Pokemon
	{
		#region Lapras Builders
		/// <summary>
		/// Lapras Builder waiting for a Nickname & a Level
		/// </summary>
		public Lapras(string nickname, int level)
		: base(
				131,
				SpecieLapras.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lapras Builder only waiting for a Level
		/// </summary>
		public Lapras(int level)
		: base(
				131,
				SpecieLapras.Instance, // Pokemon Specie
				"Lapras", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lapras Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lapras() : base(
			131,
			SpecieLapras.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}