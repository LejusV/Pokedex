using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Braviary Specie to store common natural stats of all Braviarys
	#region SpecieBraviary
	public class SpecieBraviary : PokemonSpecie
	{
#nullable enable
		private static SpecieBraviary? _instance = null;
#nullable restore
        public static SpecieBraviary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBraviary();
                }
                return _instance;
            }
        }

		#region SpecieBraviary Builder
		public SpecieBraviary() : base(
			"Braviary",
			100, // HPs
			123, 75, // Attack & Defense
			57, 75, // Special Attack & Defense
			80			
		) {}
		#endregion
	}
	#endregion

	//Braviary Pokemon Class
	#region Braviary
	public class Braviary : Pokemon
	{
		#region Braviary Builders
		/// <summary>
		/// Braviary Builder waiting for a Nickname & a Level
		/// </summary>
		public Braviary(string nickname, int level)
		: base(
				628,
				SpecieBraviary.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braviary Builder only waiting for a Level
		/// </summary>
		public Braviary(int level)
		: base(
				628,
				SpecieBraviary.Instance, // Pokemon Specie
				"Braviary", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braviary Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Braviary() : base(
			628,
			SpecieBraviary.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
		#endregion
	}
	#endregion
}