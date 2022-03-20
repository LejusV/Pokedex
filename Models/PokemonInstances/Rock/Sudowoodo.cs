using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sudowoodo PokemonInstance Class
	#region Sudowoodo
	public class Sudowoodo : PokemonInstance
	{
		#region Sudowoodo Constructors
		/// <summary>
		/// Sudowoodo Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sudowoodo(string nickname, int level)
		: base(
				SudowoodoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sudowoodo Constructor only waiting for a Level
		/// </summary>
		public Sudowoodo(int level)
		: this( "Sudowoodo", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sudowoodo Constructor waiting for no params
		/// </summary>
		/*
		public Sudowoodo() : this( "Sudowoodo", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}