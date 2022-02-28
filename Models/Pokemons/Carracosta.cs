using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carracosta Specie to store common natural stats of all Carracostas
	#region SpecieCarracosta
	public class SpecieCarracosta : PokemonSpecie
	{
#nullable enable
		private static SpecieCarracosta? _instance = null;
#nullable restore
        public static SpecieCarracosta Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarracosta();
                }
                return _instance;
            }
        }

		#region SpecieCarracosta Builder
		public SpecieCarracosta() : base(
			"Carracosta",
			74, // HPs
			108, 133, // Attack & Defense
			83, 65, // Special Attack & Defense
			32			
		) {}
		#endregion
	}
	#endregion

	//Carracosta Pokemon Class
	#region Carracosta
	public class Carracosta : Pokemon
	{
		#region Carracosta Builders
		/// <summary>
		/// Carracosta Builder waiting for a Nickname & a Level
		/// </summary>
		public Carracosta(string nickname, int level)
		: base(
				565,
				SpecieCarracosta.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carracosta Builder only waiting for a Level
		/// </summary>
		public Carracosta(int level)
		: base(
				565,
				SpecieCarracosta.Instance, // Pokemon Specie
				"Carracosta", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carracosta Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Carracosta() : base(
			565,
			SpecieCarracosta.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
		#endregion
	}
	#endregion
}