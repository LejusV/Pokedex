using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chikorita PokemonInstance Class
	#region Chikorita
	public class Chikorita : PokemonInstance
	{
		#region Chikorita Constructors
		/// <summary>
		/// Chikorita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chikorita(string nickname, int level)
		: base(
				ChikoritaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chikorita Constructor only waiting for a Level
		/// </summary>
		public Chikorita(int level)
		: this( "Chikorita", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chikorita Constructor waiting for no params
		/// </summary>
		/*
		public Chikorita() : this( "Chikorita", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}