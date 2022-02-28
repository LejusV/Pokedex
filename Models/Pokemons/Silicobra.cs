using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Silicobra Specie to store common natural stats of all Silicobras
	#region SpecieSilicobra
	public class SpecieSilicobra : PokemonSpecie
	{
#nullable enable
		private static SpecieSilicobra? _instance = null;
#nullable restore
        public static SpecieSilicobra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSilicobra();
                }
                return _instance;
            }
        }

		#region SpecieSilicobra Builder
		public SpecieSilicobra() : base(
			"Silicobra",
			52, // HPs
			57, 75, // Attack & Defense
			35, 50, // Special Attack & Defense
			46			
		) {}
		#endregion
	}
	#endregion

	//Silicobra Pokemon Class
	#region Silicobra
	public class Silicobra : Pokemon
	{
		#region Silicobra Builders
		/// <summary>
		/// Silicobra Builder waiting for a Nickname & a Level
		/// </summary>
		public Silicobra(string nickname, int level)
		: base(
				843,
				SpecieSilicobra.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silicobra Builder only waiting for a Level
		/// </summary>
		public Silicobra(int level)
		: base(
				843,
				SpecieSilicobra.Instance, // Pokemon Specie
				"Silicobra", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Silicobra Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Silicobra() : base(
			843,
			SpecieSilicobra.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}