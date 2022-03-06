using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Tranquill Specie to store common natural stats of all Tranquills
	#region SpecieTranquill
	public class SpecieTranquill : PokemonSpecie
	{
#nullable enable
		private static SpecieTranquill? _instance = null;
#nullable restore
        public static SpecieTranquill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTranquill();
                }
                return _instance;
            }
        }

		#region SpecieTranquill Builder
		public SpecieTranquill() : base(
			"Tranquill",
			62, // HPs
			77, 62, // Attack & Defense
			50, 42, // Special Attack & Defense
			65		
		)
		{
			this._height = 6;
			this._weight = 150;
		}
		#endregion
	}
	#endregion

	//Tranquill Pokemon Class
	#region Tranquill
	public class Tranquill : Pokemon
	{
		#region Tranquill Builders
		/// <summary>
		/// Tranquill Builder waiting for a Nickname & a Level
		/// </summary>
		public Tranquill(string nickname, int level)
		: base(
				520,
				SpecieTranquill.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tranquill Builder only waiting for a Level
		/// </summary>
		public Tranquill(int level)
		: base(
				520,
				SpecieTranquill.Instance, // Pokemon Specie
				"Tranquill", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tranquill Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Tranquill() : base(
			520,
			SpecieTranquill.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}