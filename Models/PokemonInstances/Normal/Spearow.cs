using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Spearow PokemonInstance Class
	#region Spearow
	public class Spearow : PokemonInstance
	{
		#region Spearow Constructors
		/// <summary>
		/// Spearow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Spearow(string nickname, int level)
		: base(
				SpearowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spearow Constructor only waiting for a Level
		/// </summary>
		public Spearow(int level)
		: this( "Spearow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Spearow Constructor waiting for no params
		/// </summary>
		/*
		public Spearow() : this( "Spearow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}