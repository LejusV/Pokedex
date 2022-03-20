using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bounsweet PokemonInstance Class
	#region Bounsweet
	public class Bounsweet : PokemonInstance
	{
		#region Bounsweet Constructors
		/// <summary>
		/// Bounsweet Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bounsweet(string nickname, int level)
		: base(
				BounsweetSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bounsweet Constructor only waiting for a Level
		/// </summary>
		public Bounsweet(int level)
		: this( "Bounsweet", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bounsweet Constructor waiting for no params
		/// </summary>
		/*
		public Bounsweet() : this( "Bounsweet", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}