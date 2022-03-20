using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jigglypuff PokemonInstance Class
	#region Jigglypuff
	public class Jigglypuff : PokemonInstance
	{
		#region Jigglypuff Constructors
		/// <summary>
		/// Jigglypuff Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Jigglypuff(string nickname, int level)
		: base(
				JigglypuffSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jigglypuff Constructor only waiting for a Level
		/// </summary>
		public Jigglypuff(int level)
		: this( "Jigglypuff", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jigglypuff Constructor waiting for no params
		/// </summary>
		/*
		public Jigglypuff() : this( "Jigglypuff", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}