using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Xerneas Specie to store common natural stats of all Xerneass
	#region SpecieXerneas
	public class SpecieXerneas : PokemonSpecie
	{
#nullable enable
		private static SpecieXerneas? _instance = null;
#nullable restore
        public static SpecieXerneas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieXerneas();
                }
                return _instance;
            }
        }

		#region SpecieXerneas Builder
		public SpecieXerneas() : base(
			"Xerneas",
			126, // HPs
			131, 95, // Attack & Defense
			131, 98, // Special Attack & Defense
			99		
		)
		{
			this._height = 30;
			this._weight = 2150;
		}
		#endregion
	}
	#endregion

	//Xerneas Pokemon Class
	#region Xerneas
	public class Xerneas : Pokemon
	{
		#region Xerneas Builders
		/// <summary>
		/// Xerneas Builder waiting for a Nickname & a Level
		/// </summary>
		public Xerneas(string nickname, int level)
		: base(
				716,
				SpecieXerneas.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xerneas Builder only waiting for a Level
		/// </summary>
		public Xerneas(int level)
		: base(
				716,
				SpecieXerneas.Instance, // Pokemon Specie
				"Xerneas", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xerneas Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Xerneas() : base(
			716,
			SpecieXerneas.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}