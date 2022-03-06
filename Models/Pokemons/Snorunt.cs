using Pokedex.Models;
using Pokedex.Models.PokemonTypes;

namespace Pokedex.Models.Pokemons
{
	//Snorunt Specie to store common natural stats of all Snorunts
	#region SpecieSnorunt
	public class SpecieSnorunt : PokemonSpecie
	{
#nullable enable
		private static SpecieSnorunt? _instance = null;
#nullable restore
        public static SpecieSnorunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnorunt();
                }
                return _instance;
            }
        }

		#region SpecieSnorunt Builder
		public SpecieSnorunt() : base(
			"Snorunt",
			0.7,
			16.8,
			50, // HPs
			50, 50, // Attack & Defense
			50, 50, // Special Attack & Defense
			50		
		)
		{}
		#endregion
	}
	#endregion

	//Snorunt Pokemon Class
	#region Snorunt
	public class Snorunt : Pokemon
	{
		#region Snorunt Builders
		/// <summary>
		/// Snorunt Builder waiting for a Nickname & a Level
		/// </summary>
		public Snorunt(string nickname, int level)
		: base(
				361,
				SpecieSnorunt.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorunt Builder only waiting for a Level
		/// </summary>
		public Snorunt(int level)
		: base(
				361,
				SpecieSnorunt.Instance, // Pokemon Specie
				"Snorunt", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Snorunt Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		/*
		public Snorunt() : base(
			361,
			SpecieSnorunt.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}