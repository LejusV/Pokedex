using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gothita PokemonInstance Class
	#region Gothita
	public class Gothita : PokemonInstance
	{
		#region Gothita Constructors
		/// <summary>
		/// Gothita Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Gothita(string nickname, int level)
		: base(
				GothitaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothita Constructor only waiting for a Level
		/// </summary>
		public Gothita(int level)
		: this( "Gothita", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gothita Constructor waiting for no params
		/// </summary>
		/*
		public Gothita() : this( "Gothita", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}