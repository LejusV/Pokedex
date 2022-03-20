using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bellsprout PokemonInstance Class
	#region Bellsprout
	public class Bellsprout : PokemonInstance
	{
		#region Bellsprout Constructors
		/// <summary>
		/// Bellsprout Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bellsprout(string nickname, int level)
		: base(
				BellsproutSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellsprout Constructor only waiting for a Level
		/// </summary>
		public Bellsprout(int level)
		: this( "Bellsprout", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bellsprout Constructor waiting for no params
		/// </summary>
		/*
		public Bellsprout() : this( "Bellsprout", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}