using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Jirachi PokemonInstance Class
	#region Jirachi
	public class Jirachi : PokemonInstance
	{
		#region Jirachi Constructors
		/// <summary>
		/// Jirachi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Jirachi(string nickname, int level)
		: base(
				JirachiSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jirachi Constructor only waiting for a Level
		/// </summary>
		public Jirachi(int level)
		: this( "Jirachi", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Jirachi Constructor waiting for no params
		/// </summary>
		/*
		public Jirachi() : this( "Jirachi", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}