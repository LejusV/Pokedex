using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Elgyem PokemonInstance Class
	#region Elgyem
	public class Elgyem : PokemonInstance
	{
		#region Elgyem Constructors
		/// <summary>
		/// Elgyem Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Elgyem(string nickname, int level)
		: base(
				ElgyemSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elgyem Constructor only waiting for a Level
		/// </summary>
		public Elgyem(int level)
		: this( "Elgyem", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elgyem Constructor waiting for no params
		/// </summary>
		/*
		public Elgyem() : this( "Elgyem", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}