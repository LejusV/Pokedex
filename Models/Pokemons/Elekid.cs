using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Elekid Specie to store common natural stats of all Elekids
	#region SpecieElekid
	public class SpecieElekid : PokemonSpecie
	{
#nullable enable
		private static SpecieElekid? _instance = null;
#nullable restore
        public static SpecieElekid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElekid();
                }
                return _instance;
            }
        }

		#region SpecieElekid Builder
		public SpecieElekid() : base(
			"Elekid",
			0.6,
			23.5,
			45, // HPs
			63, 37, // Attack & Defense
			65, 55, // Special Attack & Defense
			95		
		)
		{}
		#endregion
	}
	#endregion

	//Elekid Pokemon Class
	#region Elekid
	public class Elekid : Pokemon
	{
		#region Elekid Builders
		/// <summary>
		/// Elekid Builder waiting for a Nickname & a Level
		/// </summary>
		public Elekid(string nickname, int level)
		: base(
				239,
				SpecieElekid.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elekid Builder only waiting for a Level
		/// </summary>
		public Elekid(int level)
		: base(
				239,
				SpecieElekid.Instance, // Pokemon Specie
				"Elekid", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elekid Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Elekid() : base(
			239,
			SpecieElekid.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}