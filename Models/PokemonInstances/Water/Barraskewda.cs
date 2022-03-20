using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Barraskewda PokemonInstance Class
	#region Barraskewda
	public class Barraskewda : PokemonInstance
	{
		#region Barraskewda Constructors
		/// <summary>
		/// Barraskewda Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Barraskewda(string nickname, int level)
		: base(
				BarraskewdaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barraskewda Constructor only waiting for a Level
		/// </summary>
		public Barraskewda(int level)
		: this( "Barraskewda", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Barraskewda Constructor waiting for no params
		/// </summary>
		/*
		public Barraskewda() : this( "Barraskewda", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}