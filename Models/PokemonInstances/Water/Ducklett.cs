using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ducklett PokemonInstance Class
	#region Ducklett
	public class Ducklett : PokemonInstance
	{
		#region Ducklett Constructors
		/// <summary>
		/// Ducklett Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ducklett(string nickname, int level)
		: base(
				DucklettSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ducklett Constructor only waiting for a Level
		/// </summary>
		public Ducklett(int level)
		: this( "Ducklett", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ducklett Constructor waiting for no params
		/// </summary>
		/*
		public Ducklett() : this( "Ducklett", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}