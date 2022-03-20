using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Honchkrow PokemonInstance Class
	#region Honchkrow
	public class Honchkrow : PokemonInstance
	{
		#region Honchkrow Constructors
		/// <summary>
		/// Honchkrow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Honchkrow(string nickname, int level)
		: base(
				HonchkrowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honchkrow Constructor only waiting for a Level
		/// </summary>
		public Honchkrow(int level)
		: this( "Honchkrow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Honchkrow Constructor waiting for no params
		/// </summary>
		/*
		public Honchkrow() : this( "Honchkrow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}