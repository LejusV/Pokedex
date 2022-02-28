using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxel Specie to store common natural stats of all Toxels
	#region SpecieToxel
	public class SpecieToxel : PokemonSpecie
	{
#nullable enable
		private static SpecieToxel? _instance = null;
#nullable restore
        public static SpecieToxel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxel();
                }
                return _instance;
            }
        }

		#region SpecieToxel Builder
		public SpecieToxel() : base(
			"Toxel",
			40, // HPs
			38, 35, // Attack & Defense
			54, 35, // Special Attack & Defense
			40			
		) {}
		#endregion
	}
	#endregion

	//Toxel Pokemon Class
	#region Toxel
	public class Toxel : Pokemon
	{
		#region Toxel Builders
		/// <summary>
		/// Toxel Builder waiting for a Nickname & a Level
		/// </summary>
		public Toxel(string nickname, int level)
		: base(
				848,
				SpecieToxel.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxel Builder only waiting for a Level
		/// </summary>
		public Toxel(int level)
		: base(
				848,
				SpecieToxel.Instance, // Pokemon Specie
				"Toxel", level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxel Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Toxel() : base(
			848,
			SpecieToxel.Instance, // Pokemon Specie
			Electric.Instance, Poison.Instance			
		) {}
		#endregion
	}
	#endregion
}