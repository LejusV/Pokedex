using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Lampent Specie to store common natural stats of all Lampents
	#region SpecieLampent
	public class SpecieLampent : PokemonSpecie
	{
#nullable enable
		private static SpecieLampent? _instance = null;
#nullable restore
        public static SpecieLampent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLampent();
                }
                return _instance;
            }
        }

		#region SpecieLampent Builder
		public SpecieLampent() : base(
			"Lampent",
			0.6,
			13.0,
			60, // HPs
			40, 60, // Attack & Defense
			95, 60, // Special Attack & Defense
			55		
		)
		{}
		#endregion
	}
	#endregion

	//Lampent Pokemon Class
	#region Lampent
	public class Lampent : Pokemon
	{
		#region Lampent Builders
		/// <summary>
		/// Lampent Builder waiting for a Nickname & a Level
		/// </summary>
		public Lampent(string nickname, int level)
		: base(
				608,
				SpecieLampent.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lampent Builder only waiting for a Level
		/// </summary>
		public Lampent(int level)
		: base(
				608,
				SpecieLampent.Instance, // Pokemon Specie
				"Lampent", level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lampent Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Lampent() : base(
			608,
			SpecieLampent.Instance, // Pokemon Specie
			Ghost.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}