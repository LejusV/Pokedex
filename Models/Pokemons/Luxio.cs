using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Luxio Specie to store common natural stats of all Luxios
	#region SpecieLuxio
	public class SpecieLuxio : PokemonSpecie
	{
#nullable enable
		private static SpecieLuxio? _instance = null;
#nullable restore
        public static SpecieLuxio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLuxio();
                }
                return _instance;
            }
        }

		#region SpecieLuxio Builder
		public SpecieLuxio() : base(
			"Luxio",
			0.9,
			30.5,
			60, // HPs
			85, 49, // Attack & Defense
			60, 49, // Special Attack & Defense
			60		
		)
		{}
		#endregion
	}
	#endregion

	//Luxio Pokemon Class
	#region Luxio
	public class Luxio : Pokemon
	{
		#region Luxio Builders
		/// <summary>
		/// Luxio Builder waiting for a Nickname & a Level
		/// </summary>
		public Luxio(string nickname, int level)
		: base(
				404,
				SpecieLuxio.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxio Builder only waiting for a Level
		/// </summary>
		public Luxio(int level)
		: base(
				404,
				SpecieLuxio.Instance, // Pokemon Specie
				"Luxio", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luxio Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Luxio() : base(
			404,
			SpecieLuxio.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}