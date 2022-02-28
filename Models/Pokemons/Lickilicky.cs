using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lickilicky Specie to store common natural stats of all Lickilickys
	#region SpecieLickilicky
	public class SpecieLickilicky : PokemonSpecie
	{
#nullable enable
		private static SpecieLickilicky? _instance = null;
#nullable restore
        public static SpecieLickilicky Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLickilicky();
                }
                return _instance;
            }
        }

		#region SpecieLickilicky Builder
		public SpecieLickilicky() : base(
			"Lickilicky",
			110, // HPs
			85, 95, // Attack & Defense
			80, 95, // Special Attack & Defense
			50			
		) {}
		#endregion
	}
	#endregion

	//Lickilicky Pokemon Class
	#region Lickilicky
	public class Lickilicky : Pokemon
	{
		#region Lickilicky Builders
		/// <summary>
		/// Lickilicky Builder waiting for a Nickname & a Level
		/// </summary>
		public Lickilicky(string nickname, int level)
		: base(
				463,
				SpecieLickilicky.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickilicky Builder only waiting for a Level
		/// </summary>
		public Lickilicky(int level)
		: base(
				463,
				SpecieLickilicky.Instance, // Pokemon Specie
				"Lickilicky", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lickilicky Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Lickilicky() : base(
			463,
			SpecieLickilicky.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}