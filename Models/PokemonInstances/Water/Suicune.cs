using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Suicune PokemonInstance Class
	#region Suicune
	public class Suicune : PokemonInstance
	{
		#region Suicune Constructors
		/// <summary>
		/// Suicune Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Suicune(string nickname, int level)
		: base(
				SuicuneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Suicune Constructor only waiting for a Level
		/// </summary>
		public Suicune(int level)
		: this( "Suicune", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Suicune Constructor waiting for no params
		/// </summary>
		/*
		public Suicune() : this( "Suicune", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}