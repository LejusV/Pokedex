using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Diggersby Specie to store common natural stats of all Diggersbys
	#region SpecieDiggersby
	public class SpecieDiggersby : PokemonSpecie
	{
#nullable enable
		private static SpecieDiggersby? _instance = null;
#nullable restore
        public static SpecieDiggersby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDiggersby();
                }
                return _instance;
            }
        }

		#region SpecieDiggersby Builder
		public SpecieDiggersby() : base(
			"Diggersby",
			85, // HPs
			56, 77, // Attack & Defense
			50, 77, // Special Attack & Defense
			78			
		) {}
		#endregion
	}
	#endregion

	//Diggersby Pokemon Class
	#region Diggersby
	public class Diggersby : Pokemon
	{
		#region Diggersby Builders
		/// <summary>
		/// Diggersby Builder waiting for a Nickname & a Level
		/// </summary>
		public Diggersby(string nickname, int level)
		: base(
				660,
				SpecieDiggersby.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diggersby Builder only waiting for a Level
		/// </summary>
		public Diggersby(int level)
		: base(
				660,
				SpecieDiggersby.Instance, // Pokemon Specie
				"Diggersby", level,
				Normal.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diggersby Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Diggersby() : base(
			660,
			SpecieDiggersby.Instance, // Pokemon Specie
			Normal.Instance, Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}