using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Luvdisc Specie to store common natural stats of all Luvdiscs
	#region SpecieLuvdisc
	public class SpecieLuvdisc : PokemonSpecie
	{
#nullable enable
		private static SpecieLuvdisc? _instance = null;
#nullable restore
        public static SpecieLuvdisc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLuvdisc();
                }
                return _instance;
            }
        }

		#region SpecieLuvdisc Builder
		public SpecieLuvdisc() : base(
			"Luvdisc",
			0.6,
			8.7,
			43, // HPs
			30, 55, // Attack & Defense
			40, 65, // Special Attack & Defense
			97		
		)
		{}
		#endregion
	}
	#endregion

	//Luvdisc Pokemon Class
	#region Luvdisc
	public class Luvdisc : Pokemon
	{
		#region Luvdisc Builders
		/// <summary>
		/// Luvdisc Builder waiting for a Nickname & a Level
		/// </summary>
		public Luvdisc(string nickname, int level)
		: base(
				370,
				SpecieLuvdisc.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luvdisc Builder only waiting for a Level
		/// </summary>
		public Luvdisc(int level)
		: base(
				370,
				SpecieLuvdisc.Instance, // Pokemon Specie
				"Luvdisc", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Luvdisc Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Luvdisc() : base(
			370,
			SpecieLuvdisc.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}