using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Archen PokemonInstance Class
	#region Archen
	public class Archen : PokemonInstance
	{
		#region Archen Constructors
		/// <summary>
		/// Archen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Archen(string nickname, int level)
		: base(
				ArchenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archen Constructor only waiting for a Level
		/// </summary>
		public Archen(int level)
		: this( "Archen", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archen Constructor waiting for no params
		/// </summary>
		/*
		public Archen() : this( "Archen", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}