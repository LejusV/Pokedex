using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bisharp PokemonInstance Class
	#region Bisharp
	public class Bisharp : PokemonInstance
	{
		#region Bisharp Constructors
		/// <summary>
		/// Bisharp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bisharp(string nickname, int level)
		: base(
				BisharpSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bisharp Constructor only waiting for a Level
		/// </summary>
		public Bisharp(int level)
		: this( "Bisharp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bisharp Constructor waiting for no params
		/// </summary>
		/*
		public Bisharp() : this( "Bisharp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}