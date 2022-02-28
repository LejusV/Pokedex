using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Diglett Specie to store common natural stats of all Digletts
	#region SpecieDiglett
	public class SpecieDiglett : PokemonSpecie
	{
#nullable enable
		private static SpecieDiglett? _instance = null;
#nullable restore
        public static SpecieDiglett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDiglett();
                }
                return _instance;
            }
        }

		#region SpecieDiglett Builder
		public SpecieDiglett() : base(
			"Diglett",
			10, // HPs
			55, 25, // Attack & Defense
			35, 45, // Special Attack & Defense
			95			
		) {}
		#endregion
	}
	#endregion

	//Diglett Pokemon Class
	#region Diglett
	public class Diglett : Pokemon
	{
		#region Diglett Builders
		/// <summary>
		/// Diglett Builder waiting for a Nickname & a Level
		/// </summary>
		public Diglett(string nickname, int level)
		: base(
				50,
				SpecieDiglett.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diglett Builder only waiting for a Level
		/// </summary>
		public Diglett(int level)
		: base(
				50,
				SpecieDiglett.Instance, // Pokemon Specie
				"Diglett", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diglett Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Diglett() : base(
			50,
			SpecieDiglett.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
		#endregion
	}
	#endregion
}