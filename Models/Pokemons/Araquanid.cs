using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Araquanid Specie to store common natural stats of all Araquanids
	#region SpecieAraquanid
	public class SpecieAraquanid : PokemonSpecie
	{
#nullable enable
		private static SpecieAraquanid? _instance = null;
#nullable restore
        public static SpecieAraquanid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAraquanid();
                }
                return _instance;
            }
        }

		#region SpecieAraquanid Builder
		public SpecieAraquanid() : base(
			"Araquanid",
			1.8,
			82.0,
			68, // HPs
			70, 92, // Attack & Defense
			50, 132, // Special Attack & Defense
			42		
		)
		{}
		#endregion
	}
	#endregion

	//Araquanid Pokemon Class
	#region Araquanid
	public class Araquanid : Pokemon
	{
		#region Araquanid Builders
		/// <summary>
		/// Araquanid Builder waiting for a Nickname & a Level
		/// </summary>
		public Araquanid(string nickname, int level)
		: base(
				752,
				SpecieAraquanid.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Araquanid Builder only waiting for a Level
		/// </summary>
		public Araquanid(int level)
		: base(
				752,
				SpecieAraquanid.Instance, // Pokemon Specie
				"Araquanid", level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Araquanid Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Araquanid() : base(
			752,
			SpecieAraquanid.Instance, // Pokemon Specie
			Water.Instance, Bug.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}