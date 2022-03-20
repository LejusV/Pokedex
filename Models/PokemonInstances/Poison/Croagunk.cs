using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Croagunk PokemonInstance Class
	#region Croagunk
	public class Croagunk : PokemonInstance
	{
		#region Croagunk Constructors
		/// <summary>
		/// Croagunk Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Croagunk(string nickname, int level)
		: base(
				CroagunkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croagunk Constructor only waiting for a Level
		/// </summary>
		public Croagunk(int level)
		: this( "Croagunk", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croagunk Constructor waiting for no params
		/// </summary>
		/*
		public Croagunk() : this( "Croagunk", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}