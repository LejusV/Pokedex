using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Anorith PokemonInstance Class
	#region Anorith
	public class Anorith : PokemonInstance
	{
		#region Anorith Constructors
		/// <summary>
		/// Anorith Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Anorith(string nickname, int level)
		: base(
				AnorithSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Anorith Constructor only waiting for a Level
		/// </summary>
		public Anorith(int level)
		: this( "Anorith", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Anorith Constructor waiting for no params
		/// </summary>
		/*
		public Anorith() : this( "Anorith", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}