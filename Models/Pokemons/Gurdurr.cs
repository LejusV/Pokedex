using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Gurdurr Specie to store common natural stats of all Gurdurrs
	#region SpecieGurdurr
	public class SpecieGurdurr : PokemonSpecie
	{
#nullable enable
		private static SpecieGurdurr? _instance = null;
#nullable restore
        public static SpecieGurdurr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGurdurr();
                }
                return _instance;
            }
        }

		#region SpecieGurdurr Builder
		public SpecieGurdurr() : base(
			"Gurdurr",
			1.2,
			40.0,
			85, // HPs
			105, 85, // Attack & Defense
			40, 50, // Special Attack & Defense
			40		
		)
		{}
		#endregion
	}
	#endregion

	//Gurdurr Pokemon Class
	#region Gurdurr
	public class Gurdurr : Pokemon
	{
		#region Gurdurr Builders
		/// <summary>
		/// Gurdurr Builder waiting for a Nickname & a Level
		/// </summary>
		public Gurdurr(string nickname, int level)
		: base(
				533,
				SpecieGurdurr.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gurdurr Builder only waiting for a Level
		/// </summary>
		public Gurdurr(int level)
		: base(
				533,
				SpecieGurdurr.Instance, // Pokemon Specie
				"Gurdurr", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gurdurr Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Gurdurr() : base(
			533,
			SpecieGurdurr.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}