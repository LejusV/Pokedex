using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Primeape PokemonInstance Class
	#region Primeape
	public class Primeape : PokemonInstance
	{
		#region Primeape Constructors
		/// <summary>
		/// Primeape Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Primeape(string nickname, int level)
		: base(
				PrimeapeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primeape Constructor only waiting for a Level
		/// </summary>
		public Primeape(int level)
		: this( "Primeape", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primeape Constructor waiting for no params
		/// </summary>
		/*
		public Primeape() : this( "Primeape", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}