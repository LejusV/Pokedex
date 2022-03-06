using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Stantler Specie to store common natural stats of all Stantlers
	#region SpecieStantler
	public class SpecieStantler : PokemonSpecie
	{
#nullable enable
		private static SpecieStantler? _instance = null;
#nullable restore
        public static SpecieStantler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStantler();
                }
                return _instance;
            }
        }

		#region SpecieStantler Builder
		public SpecieStantler() : base(
			"Stantler",
			73, // HPs
			95, 62, // Attack & Defense
			85, 65, // Special Attack & Defense
			85		
		)
		{
			this._height = 14;
			this._weight = 712;
		}
		#endregion
	}
	#endregion

	//Stantler Pokemon Class
	#region Stantler
	public class Stantler : Pokemon
	{
		#region Stantler Builders
		/// <summary>
		/// Stantler Builder waiting for a Nickname & a Level
		/// </summary>
		public Stantler(string nickname, int level)
		: base(
				234,
				SpecieStantler.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stantler Builder only waiting for a Level
		/// </summary>
		public Stantler(int level)
		: base(
				234,
				SpecieStantler.Instance, // Pokemon Specie
				"Stantler", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stantler Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Stantler() : base(
			234,
			SpecieStantler.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}