using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cosmog Specie to store common natural stats of all Cosmogs
	#region SpecieCosmog
	public class SpecieCosmog : PokemonSpecie
	{
#nullable enable
		private static SpecieCosmog? _instance = null;
#nullable restore
        public static SpecieCosmog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCosmog();
                }
                return _instance;
            }
        }

		#region SpecieCosmog Builder
		public SpecieCosmog() : base(
			"Cosmog",
			43, // HPs
			29, 31, // Attack & Defense
			29, 31, // Special Attack & Defense
			37			
		) {}
		#endregion
	}
	#endregion

	//Cosmog Pokemon Class
	#region Cosmog
	public class Cosmog : Pokemon
	{
		#region Cosmog Builders
		/// <summary>
		/// Cosmog Builder waiting for a Nickname & a Level
		/// </summary>
		public Cosmog(string nickname, int level)
		: base(
				789,
				SpecieCosmog.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmog Builder only waiting for a Level
		/// </summary>
		public Cosmog(int level)
		: base(
				789,
				SpecieCosmog.Instance, // Pokemon Specie
				"Cosmog", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cosmog Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Cosmog() : base(
			789,
			SpecieCosmog.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
		#endregion
	}
	#endregion
}