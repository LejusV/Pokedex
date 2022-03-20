using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Makuhita PokemonInstance Class
	#region Makuhita
	public class Makuhita : PokemonInstance
	{
		#region Makuhita Constructors
		/// <summary>
		/// Makuhita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Makuhita(string nickname, int level)
		: base(
				MakuhitaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Makuhita Constructor only waiting for a Level
		/// </summary>
		public Makuhita(int level)
		: this( "Makuhita", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Makuhita Constructor waiting for no params
		/// </summary>
		/*
		public Makuhita() : this( "Makuhita", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}