using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mightyena Specie to store common natural stats of all Mightyenas
	#region SpecieMightyena
	public class SpecieMightyena : PokemonSpecie
	{
#nullable enable
		private static SpecieMightyena? _instance = null;
#nullable restore
        public static SpecieMightyena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMightyena();
                }
                return _instance;
            }
        }

		#region SpecieMightyena Builder
		public SpecieMightyena() : base(
			"Mightyena",
			70, // HPs
			90, 70, // Attack & Defense
			60, 60, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Mightyena Pokemon Class
	#region Mightyena
	public class Mightyena : Pokemon
	{
		#region Mightyena Builders
		/// <summary>
		/// Mightyena Builder waiting for a Nickname & a Level
		/// </summary>
		public Mightyena(string nickname, int level)
		: base(
				262,
				SpecieMightyena.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mightyena Builder only waiting for a Level
		/// </summary>
		public Mightyena(int level)
		: base(
				262,
				SpecieMightyena.Instance, // Pokemon Specie
				"Mightyena", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mightyena Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Mightyena() : base(
			262,
			SpecieMightyena.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
		#endregion
	}
	#endregion
}