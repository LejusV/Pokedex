using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sealeo Specie to store common natural stats of all Sealeos
	#region SpecieSealeo
	public class SpecieSealeo : PokemonSpecie
	{
#nullable enable
		private static SpecieSealeo? _instance = null;
#nullable restore
        public static SpecieSealeo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSealeo();
                }
                return _instance;
            }
        }

		#region SpecieSealeo Builder
		public SpecieSealeo() : base(
			"Sealeo",
			90, // HPs
			60, 70, // Attack & Defense
			75, 70, // Special Attack & Defense
			45			
		) {}
		#endregion
	}
	#endregion

	//Sealeo Pokemon Class
	#region Sealeo
	public class Sealeo : Pokemon
	{
		#region Sealeo Builders
		/// <summary>
		/// Sealeo Builder waiting for a Nickname & a Level
		/// </summary>
		public Sealeo(string nickname, int level)
		: base(
				364,
				SpecieSealeo.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sealeo Builder only waiting for a Level
		/// </summary>
		public Sealeo(int level)
		: base(
				364,
				SpecieSealeo.Instance, // Pokemon Specie
				"Sealeo", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sealeo Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Sealeo() : base(
			364,
			SpecieSealeo.Instance, // Pokemon Specie
			Ice.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}