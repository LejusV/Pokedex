using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Arbok PokemonInstance Class
	#region Arbok
	public class Arbok : PokemonInstance
	{
		#region Arbok Constructors
		/// <summary>
		/// Arbok Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Arbok(string nickname, int level)
		: base(
				ArbokSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arbok Constructor only waiting for a Level
		/// </summary>
		public Arbok(int level)
		: this( "Arbok", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Arbok Constructor waiting for no params
		/// </summary>
		/*
		public Arbok() : this( "Arbok", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}