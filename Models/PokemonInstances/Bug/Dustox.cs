using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dustox PokemonInstance Class
	#region Dustox
	public class Dustox : PokemonInstance
	{
		#region Dustox Constructors
		/// <summary>
		/// Dustox Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dustox(string nickname, int level)
		: base(
				DustoxSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dustox Constructor only waiting for a Level
		/// </summary>
		public Dustox(int level)
		: this( "Dustox", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dustox Constructor waiting for no params
		/// </summary>
		/*
		public Dustox() : this( "Dustox", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}