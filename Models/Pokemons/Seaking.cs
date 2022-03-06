using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Seaking Specie to store common natural stats of all Seakings
	#region SpecieSeaking
	public class SpecieSeaking : PokemonSpecie
	{
#nullable enable
		private static SpecieSeaking? _instance = null;
#nullable restore
        public static SpecieSeaking Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeaking();
                }
                return _instance;
            }
        }

		#region SpecieSeaking Builder
		public SpecieSeaking() : base(
			"Seaking",
			80, // HPs
			92, 65, // Attack & Defense
			65, 80, // Special Attack & Defense
			68		
		)
		{
			this._height = 13;
			this._weight = 390;
		}
		#endregion
	}
	#endregion

	//Seaking Pokemon Class
	#region Seaking
	public class Seaking : Pokemon
	{
		#region Seaking Builders
		/// <summary>
		/// Seaking Builder waiting for a Nickname & a Level
		/// </summary>
		public Seaking(string nickname, int level)
		: base(
				119,
				SpecieSeaking.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seaking Builder only waiting for a Level
		/// </summary>
		public Seaking(int level)
		: base(
				119,
				SpecieSeaking.Instance, // Pokemon Specie
				"Seaking", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seaking Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Seaking() : base(
			119,
			SpecieSeaking.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}