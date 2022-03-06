using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Houndoom Specie to store common natural stats of all Houndooms
	#region SpecieHoundoom
	public class SpecieHoundoom : PokemonSpecie
	{
#nullable enable
		private static SpecieHoundoom? _instance = null;
#nullable restore
        public static SpecieHoundoom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoundoom();
                }
                return _instance;
            }
        }

		#region SpecieHoundoom Builder
		public SpecieHoundoom() : base(
			"Houndoom",
			1.4,
			35.0,
			75, // HPs
			90, 50, // Attack & Defense
			110, 80, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Houndoom Pokemon Class
	#region Houndoom
	public class Houndoom : Pokemon
	{
		#region Houndoom Builders
		/// <summary>
		/// Houndoom Builder waiting for a Nickname & a Level
		/// </summary>
		public Houndoom(string nickname, int level)
		: base(
				229,
				SpecieHoundoom.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndoom Builder only waiting for a Level
		/// </summary>
		public Houndoom(int level)
		: base(
				229,
				SpecieHoundoom.Instance, // Pokemon Specie
				"Houndoom", level,
				Dark.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Houndoom Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Houndoom() : base(
			229,
			SpecieHoundoom.Instance, // Pokemon Specie
			Dark.Instance, Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}