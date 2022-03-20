using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bibarel PokemonInstance Class
	#region Bibarel
	public class Bibarel : PokemonInstance
	{
		#region Bibarel Constructors
		/// <summary>
		/// Bibarel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bibarel(string nickname, int level)
		: base(
				BibarelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bibarel Constructor only waiting for a Level
		/// </summary>
		public Bibarel(int level)
		: this( "Bibarel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bibarel Constructor waiting for no params
		/// </summary>
		/*
		public Bibarel() : this( "Bibarel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}