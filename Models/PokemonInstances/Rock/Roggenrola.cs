using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Roggenrola PokemonInstance Class
	#region Roggenrola
	public class Roggenrola : PokemonInstance
	{
		#region Roggenrola Constructors
		/// <summary>
		/// Roggenrola Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Roggenrola(string nickname, int level)
		: base(
				RoggenrolaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roggenrola Constructor only waiting for a Level
		/// </summary>
		public Roggenrola(int level)
		: this( "Roggenrola", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Roggenrola Constructor waiting for no params
		/// </summary>
		/*
		public Roggenrola() : this( "Roggenrola", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}