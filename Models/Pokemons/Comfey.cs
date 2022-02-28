using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Comfey Specie to store common natural stats of all Comfeys
	#region SpecieComfey
	public class SpecieComfey : PokemonSpecie
	{
#nullable enable
		private static SpecieComfey? _instance = null;
#nullable restore
        public static SpecieComfey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieComfey();
                }
                return _instance;
            }
        }

		#region SpecieComfey Builder
		public SpecieComfey() : base(
			"Comfey",
			51, // HPs
			52, 90, // Attack & Defense
			82, 110, // Special Attack & Defense
			100			
		) {}
		#endregion
	}
	#endregion

	//Comfey Pokemon Class
	#region Comfey
	public class Comfey : Pokemon
	{
		#region Comfey Builders
		/// <summary>
		/// Comfey Builder waiting for a Nickname & a Level
		/// </summary>
		public Comfey(string nickname, int level)
		: base(
				764,
				SpecieComfey.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Comfey Builder only waiting for a Level
		/// </summary>
		public Comfey(int level)
		: base(
				764,
				SpecieComfey.Instance, // Pokemon Specie
				"Comfey", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Comfey Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Comfey() : base(
			764,
			SpecieComfey.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
		#endregion
	}
	#endregion
}