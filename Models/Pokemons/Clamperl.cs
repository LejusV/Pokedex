using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Clamperl Specie to store common natural stats of all Clamperls
	#region SpecieClamperl
	public class SpecieClamperl : PokemonSpecie
	{
#nullable enable
		private static SpecieClamperl? _instance = null;
#nullable restore
        public static SpecieClamperl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClamperl();
                }
                return _instance;
            }
        }

		#region SpecieClamperl Builder
		public SpecieClamperl() : base(
			"Clamperl",
			0.4,
			52.5,
			35, // HPs
			64, 85, // Attack & Defense
			74, 55, // Special Attack & Defense
			32		
		)
		{}
		#endregion
	}
	#endregion

	//Clamperl Pokemon Class
	#region Clamperl
	public class Clamperl : Pokemon
	{
		#region Clamperl Builders
		/// <summary>
		/// Clamperl Builder waiting for a Nickname & a Level
		/// </summary>
		public Clamperl(string nickname, int level)
		: base(
				366,
				SpecieClamperl.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clamperl Builder only waiting for a Level
		/// </summary>
		public Clamperl(int level)
		: base(
				366,
				SpecieClamperl.Instance, // Pokemon Specie
				"Clamperl", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clamperl Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Clamperl() : base(
			366,
			SpecieClamperl.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}