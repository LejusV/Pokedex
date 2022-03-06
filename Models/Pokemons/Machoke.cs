using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Machoke Specie to store common natural stats of all Machokes
	#region SpecieMachoke
	public class SpecieMachoke : PokemonSpecie
	{
#nullable enable
		private static SpecieMachoke? _instance = null;
#nullable restore
        public static SpecieMachoke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMachoke();
                }
                return _instance;
            }
        }

		#region SpecieMachoke Builder
		public SpecieMachoke() : base(
			"Machoke",
			1.5,
			70.5,
			80, // HPs
			100, 70, // Attack & Defense
			50, 60, // Special Attack & Defense
			45		
		)
		{}
		#endregion
	}
	#endregion

	//Machoke Pokemon Class
	#region Machoke
	public class Machoke : Pokemon
	{
		#region Machoke Builders
		/// <summary>
		/// Machoke Builder waiting for a Nickname & a Level
		/// </summary>
		public Machoke(string nickname, int level)
		: base(
				67,
				SpecieMachoke.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machoke Builder only waiting for a Level
		/// </summary>
		public Machoke(int level)
		: base(
				67,
				SpecieMachoke.Instance, // Pokemon Specie
				"Machoke", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machoke Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Machoke() : base(
			67,
			SpecieMachoke.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}