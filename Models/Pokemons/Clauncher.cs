using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Clauncher Specie to store common natural stats of all Claunchers
	#region SpecieClauncher
	public class SpecieClauncher : PokemonSpecie
	{
#nullable enable
		private static SpecieClauncher? _instance = null;
#nullable restore
        public static SpecieClauncher Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClauncher();
                }
                return _instance;
            }
        }

		#region SpecieClauncher Builder
		public SpecieClauncher() : base(
			"Clauncher",
			50, // HPs
			53, 62, // Attack & Defense
			58, 63, // Special Attack & Defense
			44		
		)
		{
			this._height = 5;
			this._weight = 83;
		}
		#endregion
	}
	#endregion

	//Clauncher Pokemon Class
	#region Clauncher
	public class Clauncher : Pokemon
	{
		#region Clauncher Builders
		/// <summary>
		/// Clauncher Builder waiting for a Nickname & a Level
		/// </summary>
		public Clauncher(string nickname, int level)
		: base(
				692,
				SpecieClauncher.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clauncher Builder only waiting for a Level
		/// </summary>
		public Clauncher(int level)
		: base(
				692,
				SpecieClauncher.Instance, // Pokemon Specie
				"Clauncher", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clauncher Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Clauncher() : base(
			692,
			SpecieClauncher.Instance, // Pokemon Specie
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}