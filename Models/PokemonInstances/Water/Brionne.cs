using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Brionne PokemonInstance Class
	#region Brionne
	public class Brionne : PokemonInstance
	{
		#region Brionne Constructors
		/// <summary>
		/// Brionne Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Brionne(string nickname, int level)
		: base(
				BrionneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Brionne Constructor only waiting for a Level
		/// </summary>
		public Brionne(int level)
		: this( "Brionne", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Brionne Constructor waiting for no params
		/// </summary>
		/*
		public Brionne() : this( "Brionne", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}