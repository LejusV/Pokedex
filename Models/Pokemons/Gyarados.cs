using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gyarados Specie to store common natural stats of all Gyaradoss
	#region SpecieGyarados
	public class SpecieGyarados : PokemonSpecie
	{
#nullable enable
		private static SpecieGyarados? _instance = null;
#nullable restore
        public static SpecieGyarados Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGyarados();
                }
                return _instance;
            }
        }

		#region SpecieGyarados Builder
		public SpecieGyarados() : base(
			"Gyarados",
			95, // HPs
			125, 79, // Attack & Defense
			60, 100, // Special Attack & Defense
			81		
		)
		{
			this._height = 65;
			this._weight = 2350;
		}
		#endregion
	}
	#endregion

	//Gyarados Pokemon Class
	#region Gyarados
	public class Gyarados : Pokemon
	{
		#region Gyarados Builders
		/// <summary>
		/// Gyarados Builder waiting for a Nickname & a Level
		/// </summary>
		public Gyarados(string nickname, int level)
		: base(
				130,
				SpecieGyarados.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gyarados Builder only waiting for a Level
		/// </summary>
		public Gyarados(int level)
		: base(
				130,
				SpecieGyarados.Instance, // Pokemon Specie
				"Gyarados", level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gyarados Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gyarados() : base(
			130,
			SpecieGyarados.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}