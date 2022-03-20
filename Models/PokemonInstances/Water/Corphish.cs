using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Corphish PokemonInstance Class
	#region Corphish
	public class Corphish : PokemonInstance
	{
		#region Corphish Constructors
		/// <summary>
		/// Corphish Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Corphish(string nickname, int level)
		: base(
				CorphishSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corphish Constructor only waiting for a Level
		/// </summary>
		public Corphish(int level)
		: this( "Corphish", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Corphish Constructor waiting for no params
		/// </summary>
		/*
		public Corphish() : this( "Corphish", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}