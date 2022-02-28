using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magneton Specie to store common natural stats of all Magnetons
	#region SpecieMagneton
	public class SpecieMagneton : PokemonSpecie
	{
#nullable enable
		private static SpecieMagneton? _instance = null;
#nullable restore
        public static SpecieMagneton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagneton();
                }
                return _instance;
            }
        }

		#region SpecieMagneton Builder
		public SpecieMagneton() : base(
			"Magneton",
			50, // HPs
			60, 95, // Attack & Defense
			120, 70, // Special Attack & Defense
			70			
		) {}
		#endregion
	}
	#endregion

	//Magneton Pokemon Class
	#region Magneton
	public class Magneton : Pokemon
	{
		#region Magneton Builders
		/// <summary>
		/// Magneton Builder waiting for a Nickname & a Level
		/// </summary>
		public Magneton(string nickname, int level)
		: base(
				82,
				SpecieMagneton.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magneton Builder only waiting for a Level
		/// </summary>
		public Magneton(int level)
		: base(
				82,
				SpecieMagneton.Instance, // Pokemon Specie
				"Magneton", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magneton Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Magneton() : base(
			82,
			SpecieMagneton.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
		#endregion
	}
	#endregion
}