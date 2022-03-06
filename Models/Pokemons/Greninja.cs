using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Greninja Specie to store common natural stats of all Greninjas
	#region SpecieGreninja
	public class SpecieGreninja : PokemonSpecie
	{
#nullable enable
		private static SpecieGreninja? _instance = null;
#nullable restore
        public static SpecieGreninja Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGreninja();
                }
                return _instance;
            }
        }

		#region SpecieGreninja Builder
		public SpecieGreninja() : base(
			"Greninja",
			1.5,
			40.0,
			72, // HPs
			95, 67, // Attack & Defense
			103, 71, // Special Attack & Defense
			122		
		)
		{}
		#endregion
	}
	#endregion

	//Greninja Pokemon Class
	#region Greninja
	public class Greninja : Pokemon
	{
		#region Greninja Builders
		/// <summary>
		/// Greninja Builder waiting for a Nickname & a Level
		/// </summary>
		public Greninja(string nickname, int level)
		: base(
				658,
				SpecieGreninja.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greninja Builder only waiting for a Level
		/// </summary>
		public Greninja(int level)
		: base(
				658,
				SpecieGreninja.Instance, // Pokemon Specie
				"Greninja", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Greninja Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Greninja() : base(
			658,
			SpecieGreninja.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}