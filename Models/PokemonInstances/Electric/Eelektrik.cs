using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Eelektrik PokemonInstance Class
	#region Eelektrik
	public class Eelektrik : PokemonInstance
	{
		#region Eelektrik Constructors
		/// <summary>
		/// Eelektrik Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Eelektrik(string nickname, int level)
		: base(
				EelektrikSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektrik Constructor only waiting for a Level
		/// </summary>
		public Eelektrik(int level)
		: this( "Eelektrik", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Eelektrik Constructor waiting for no params
		/// </summary>
		/*
		public Eelektrik() : this( "Eelektrik", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}