using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Litwick Specie to store common natural stats of all Litwicks
	#region SpecieLitwick
	public class SpecieLitwick : PokemonSpecie
	{
#nullable enable
		private static SpecieLitwick? _instance = null;
#nullable restore
        public static SpecieLitwick Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLitwick();
                }
                return _instance;
            }
        }

		#region SpecieLitwick Builder
		public SpecieLitwick() : base(
			"Litwick",
			50, // HPs
			30, 55, // Attack & Defense
			65, 55, // Special Attack & Defense
			20		
		)
		{
			this._height = 3;
			this._weight = 31;
		}
		#endregion
	}
	#endregion

	//Litwick Pokemon Class
	#region Litwick
	public class Litwick : Pokemon
	{
		#region Litwick Builders
		/// <summary>
		/// Litwick Builder waiting for a Nickname & a Level
		/// </summary>
		public Litwick(string nickname, int level)
		: base(
				607,
				SpecieLitwick.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litwick Builder only waiting for a Level
		/// </summary>
		public Litwick(int level)
		: base(
				607,
				SpecieLitwick.Instance, // Pokemon Specie
				"Litwick", level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Litwick Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Litwick() : base(
			607,
			SpecieLitwick.Instance, // Pokemon Specie
			Ghost.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}