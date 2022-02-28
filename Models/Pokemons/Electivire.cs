using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Electivire Specie to store common natural stats of all Electivires
	#region SpecieElectivire
	public class SpecieElectivire : PokemonSpecie
	{
#nullable enable
		private static SpecieElectivire? _instance = null;
#nullable restore
        public static SpecieElectivire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectivire();
                }
                return _instance;
            }
        }

		#region SpecieElectivire Builder
		public SpecieElectivire() : base(
			"Electivire",
			75, // HPs
			123, 67, // Attack & Defense
			95, 85, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Electivire Pokemon Class
	#region Electivire
	public class Electivire : Pokemon
	{
		#region Electivire Builders
		/// <summary>
		/// Electivire Builder waiting for a Nickname & a Level
		/// </summary>
		public Electivire(string nickname, int level)
		: base(
				466,
				SpecieElectivire.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electivire Builder only waiting for a Level
		/// </summary>
		public Electivire(int level)
		: base(
				466,
				SpecieElectivire.Instance, // Pokemon Specie
				"Electivire", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electivire Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Electivire() : base(
			466,
			SpecieElectivire.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		#endregion
	}
	#endregion
}