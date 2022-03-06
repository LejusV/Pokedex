using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Incineroar Specie to store common natural stats of all Incineroars
	#region SpecieIncineroar
	public class SpecieIncineroar : PokemonSpecie
	{
#nullable enable
		private static SpecieIncineroar? _instance = null;
#nullable restore
        public static SpecieIncineroar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIncineroar();
                }
                return _instance;
            }
        }

		#region SpecieIncineroar Builder
		public SpecieIncineroar() : base(
			"Incineroar",
			95, // HPs
			115, 90, // Attack & Defense
			80, 90, // Special Attack & Defense
			60		
		)
		{
			this._height = 18;
			this._weight = 830;
		}
		#endregion
	}
	#endregion

	//Incineroar Pokemon Class
	#region Incineroar
	public class Incineroar : Pokemon
	{
		#region Incineroar Builders
		/// <summary>
		/// Incineroar Builder waiting for a Nickname & a Level
		/// </summary>
		public Incineroar(string nickname, int level)
		: base(
				727,
				SpecieIncineroar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Incineroar Builder only waiting for a Level
		/// </summary>
		public Incineroar(int level)
		: base(
				727,
				SpecieIncineroar.Instance, // Pokemon Specie
				"Incineroar", level,
				Fire.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Incineroar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Incineroar() : base(
			727,
			SpecieIncineroar.Instance, // Pokemon Specie
			Fire.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}