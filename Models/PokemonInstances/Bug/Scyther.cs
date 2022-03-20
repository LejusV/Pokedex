using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scyther PokemonInstance Class
	#region Scyther
	public class Scyther : PokemonInstance
	{
		#region Scyther Constructors
		/// <summary>
		/// Scyther Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scyther(string nickname, int level)
		: base(
				ScytherSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scyther Constructor only waiting for a Level
		/// </summary>
		public Scyther(int level)
		: this( "Scyther", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scyther Constructor waiting for no params
		/// </summary>
		/*
		public Scyther() : this( "Scyther", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}