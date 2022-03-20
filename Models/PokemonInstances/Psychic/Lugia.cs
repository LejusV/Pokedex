using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lugia PokemonInstance Class
	#region Lugia
	public class Lugia : PokemonInstance
	{
		#region Lugia Constructors
		/// <summary>
		/// Lugia Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lugia(string nickname, int level)
		: base(
				LugiaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lugia Constructor only waiting for a Level
		/// </summary>
		public Lugia(int level)
		: this( "Lugia", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lugia Constructor waiting for no params
		/// </summary>
		/*
		public Lugia() : this( "Lugia", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}