using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tyrunt PokemonInstance Class
	#region Tyrunt
	public class Tyrunt : PokemonInstance
	{
		#region Tyrunt Constructors
		/// <summary>
		/// Tyrunt Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tyrunt(string nickname, int level)
		: base(
				TyruntSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrunt Constructor only waiting for a Level
		/// </summary>
		public Tyrunt(int level)
		: this( "Tyrunt", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tyrunt Constructor waiting for no params
		/// </summary>
		/*
		public Tyrunt() : this( "Tyrunt", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}