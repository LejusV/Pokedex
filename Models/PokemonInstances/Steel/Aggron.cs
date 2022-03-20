using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aggron PokemonInstance Class
	#region Aggron
	public class Aggron : PokemonInstance
	{
		#region Aggron Constructors
		/// <summary>
		/// Aggron Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Aggron(string nickname, int level)
		: base(
				AggronSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aggron Constructor only waiting for a Level
		/// </summary>
		public Aggron(int level)
		: this( "Aggron", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aggron Constructor waiting for no params
		/// </summary>
		/*
		public Aggron() : this( "Aggron", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}