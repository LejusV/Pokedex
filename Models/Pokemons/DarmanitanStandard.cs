using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Darmanitan-Standard Specie to store common natural stats of all Darmanitan-Standards
	#region SpecieDarmanitan-Standard
	public class SpecieDarmanitanStandard : PokemonSpecie
	{
#nullable enable
		private static SpecieDarmanitanStandard? _instance = null;
#nullable restore
        public static SpecieDarmanitanStandard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDarmanitanStandard();
                }
                return _instance;
            }
        }

		#region SpecieDarmanitan-Standard Builder
		public SpecieDarmanitanStandard() : base(
			"Darmanitan-Standard",
			105, // HPs
			140, 55, // Attack & Defense
			30, 55, // Special Attack & Defense
			95		
		)
		{
			this._height = 13;
			this._weight = 929;
		}
		#endregion
	}
	#endregion

	//Darmanitan-Standard Pokemon Class
	#region Darmanitan-Standard
	public class DarmanitanStandard : Pokemon
	{
		#region Darmanitan-Standard Builders
		/// <summary>
		/// Darmanitan-Standard Builder waiting for a Nickname & a Level
		/// </summary>
		public DarmanitanStandard(string nickname, int level)
		: base(
				555,
				SpecieDarmanitanStandard.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darmanitan-Standard Builder only waiting for a Level
		/// </summary>
		public DarmanitanStandard(int level)
		: base(
				555,
				SpecieDarmanitanStandard.Instance, // Pokemon Specie
				"Darmanitan-Standard", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Darmanitan-Standard Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public DarmanitanStandard() : base(
			555,
			SpecieDarmanitanStandard.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}