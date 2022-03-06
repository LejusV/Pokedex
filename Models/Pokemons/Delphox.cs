using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Delphox Specie to store common natural stats of all Delphoxs
	#region SpecieDelphox
	public class SpecieDelphox : PokemonSpecie
	{
#nullable enable
		private static SpecieDelphox? _instance = null;
#nullable restore
        public static SpecieDelphox Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDelphox();
                }
                return _instance;
            }
        }

		#region SpecieDelphox Builder
		public SpecieDelphox() : base(
			"Delphox",
			1.5,
			39.0,
			75, // HPs
			69, 72, // Attack & Defense
			114, 100, // Special Attack & Defense
			104		
		)
		{}
		#endregion
	}
	#endregion

	//Delphox Pokemon Class
	#region Delphox
	public class Delphox : Pokemon
	{
		#region Delphox Builders
		/// <summary>
		/// Delphox Builder waiting for a Nickname & a Level
		/// </summary>
		public Delphox(string nickname, int level)
		: base(
				655,
				SpecieDelphox.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delphox Builder only waiting for a Level
		/// </summary>
		public Delphox(int level)
		: base(
				655,
				SpecieDelphox.Instance, // Pokemon Specie
				"Delphox", level,
				Fire.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delphox Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Delphox() : base(
			655,
			SpecieDelphox.Instance, // Pokemon Specie
			Fire.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}