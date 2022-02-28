using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxapex Specie to store common natural stats of all Toxapexs
	#region SpecieToxapex
	public class SpecieToxapex : PokemonSpecie
	{
#nullable enable
		private static SpecieToxapex? _instance = null;
#nullable restore
        public static SpecieToxapex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxapex();
                }
                return _instance;
            }
        }

		#region SpecieToxapex Builder
		public SpecieToxapex() : base(
			"Toxapex",
			50, // HPs
			63, 152, // Attack & Defense
			53, 142, // Special Attack & Defense
			35			
		) {}
		#endregion
	}
	#endregion

	//Toxapex Pokemon Class
	#region Toxapex
	public class Toxapex : Pokemon
	{
		#region Toxapex Builders
		/// <summary>
		/// Toxapex Builder waiting for a Nickname & a Level
		/// </summary>
		public Toxapex(string nickname, int level)
		: base(
				748,
				SpecieToxapex.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxapex Builder only waiting for a Level
		/// </summary>
		public Toxapex(int level)
		: base(
				748,
				SpecieToxapex.Instance, // Pokemon Specie
				"Toxapex", level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxapex Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Toxapex() : base(
			748,
			SpecieToxapex.Instance, // Pokemon Specie
			Poison.Instance, Water.Instance			
		) {}
		#endregion
	}
	#endregion
}