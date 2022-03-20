using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Braixen PokemonInstance Class
	#region Braixen
	public class Braixen : PokemonInstance
	{
		#region Braixen Constructors
		/// <summary>
		/// Braixen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Braixen(string nickname, int level)
		: base(
				BraixenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braixen Constructor only waiting for a Level
		/// </summary>
		public Braixen(int level)
		: this( "Braixen", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Braixen Constructor waiting for no params
		/// </summary>
		/*
		public Braixen() : this( "Braixen", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}