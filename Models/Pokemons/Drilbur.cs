using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drilbur Specie to store common natural stats of all Drilburs
	#region SpecieDrilbur
	public class SpecieDrilbur : PokemonSpecie
	{
#nullable enable
		private static SpecieDrilbur? _instance = null;
#nullable restore
        public static SpecieDrilbur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrilbur();
                }
                return _instance;
            }
        }

		#region SpecieDrilbur Builder
		public SpecieDrilbur() : base(
			"Drilbur",
			60, // HPs
			85, 40, // Attack & Defense
			30, 45, // Special Attack & Defense
			68			
		) {}
		#endregion
	}
	#endregion

	//Drilbur Pokemon Class
	#region Drilbur
	public class Drilbur : Pokemon
	{
		#region Drilbur Builders
		/// <summary>
		/// Drilbur Builder waiting for a Nickname & a Level
		/// </summary>
		public Drilbur(string nickname, int level)
		: base(
				529,
				SpecieDrilbur.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drilbur Builder only waiting for a Level
		/// </summary>
		public Drilbur(int level)
		: base(
				529,
				SpecieDrilbur.Instance, // Pokemon Specie
				"Drilbur", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Drilbur Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Drilbur() : base(
			529,
			SpecieDrilbur.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}