using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Altaria Specie to store common natural stats of all Altarias
	#region SpecieAltaria
	public class SpecieAltaria : PokemonSpecie
	{
#nullable enable
		private static SpecieAltaria? _instance = null;
#nullable restore
        public static SpecieAltaria Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAltaria();
                }
                return _instance;
            }
        }

		#region SpecieAltaria Builder
		public SpecieAltaria() : base(
			"Altaria",
			75, // HPs
			70, 90, // Attack & Defense
			70, 105, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Altaria Pokemon Class
	#region Altaria
	public class Altaria : Pokemon
	{
		#region Altaria Builders
		/// <summary>
		/// Altaria Builder waiting for a Nickname & a Level
		/// </summary>
		public Altaria(string nickname, int level)
		: base(
				334,
				SpecieAltaria.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Altaria Builder only waiting for a Level
		/// </summary>
		public Altaria(int level)
		: base(
				334,
				SpecieAltaria.Instance, // Pokemon Specie
				"Altaria", level,
				Dragon.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Altaria Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Altaria() : base(
			334,
			SpecieAltaria.Instance, // Pokemon Specie
			Dragon.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}