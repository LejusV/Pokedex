using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Palkia Specie to store common natural stats of all Palkias
	#region SpeciePalkia
	public class SpeciePalkia : PokemonSpecie
	{
#nullable enable
		private static SpeciePalkia? _instance = null;
#nullable restore
        public static SpeciePalkia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePalkia();
                }
                return _instance;
            }
        }

		#region SpeciePalkia Builder
		public SpeciePalkia() : base(
			"Palkia",
			4.2,
			336.0,
			90, // HPs
			120, 100, // Attack & Defense
			150, 120, // Special Attack & Defense
			100		
		)
		{}
		#endregion
	}
	#endregion

	//Palkia Pokemon Class
	#region Palkia
	public class Palkia : Pokemon
	{
		#region Palkia Builders
		/// <summary>
		/// Palkia Builder waiting for a Nickname & a Level
		/// </summary>
		public Palkia(string nickname, int level)
		: base(
				484,
				SpeciePalkia.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palkia Builder only waiting for a Level
		/// </summary>
		public Palkia(int level)
		: base(
				484,
				SpeciePalkia.Instance, // Pokemon Specie
				"Palkia", level,
				Water.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Palkia Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Palkia() : base(
			484,
			SpeciePalkia.Instance, // Pokemon Specie
			Water.Instance, Dragon.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}