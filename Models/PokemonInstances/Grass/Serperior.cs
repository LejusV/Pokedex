using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Serperior PokemonInstance Class
	#region Serperior
	public class Serperior : PokemonInstance
	{
		#region Serperior Constructors
		/// <summary>
		/// Serperior Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Serperior(string nickname, int level)
		: base(
				SerperiorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Serperior Constructor only waiting for a Level
		/// </summary>
		public Serperior(int level)
		: this( "Serperior", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Serperior Constructor waiting for no params
		/// </summary>
		/*
		public Serperior() : this( "Serperior", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}