using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Phantump PokemonInstance Class
	#region Phantump
	public class Phantump : PokemonInstance
	{
		#region Phantump Constructors
		/// <summary>
		/// Phantump Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Phantump(string nickname, int level)
		: base(
				PhantumpSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phantump Constructor only waiting for a Level
		/// </summary>
		public Phantump(int level)
		: this( "Phantump", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Phantump Constructor waiting for no params
		/// </summary>
		/*
		public Phantump() : this( "Phantump", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}