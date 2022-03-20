using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Sceptile PokemonInstance Class
	#region Sceptile
	public class Sceptile : PokemonInstance
	{
		#region Sceptile Constructors
		/// <summary>
		/// Sceptile Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Sceptile(string nickname, int level)
		: base(
				SceptileSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sceptile Constructor only waiting for a Level
		/// </summary>
		public Sceptile(int level)
		: this( "Sceptile", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sceptile Constructor waiting for no params
		/// </summary>
		/*
		public Sceptile() : this( "Sceptile", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}