using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Delibird PokemonInstance Class
	#region Delibird
	public class Delibird : PokemonInstance
	{
		#region Delibird Constructors
		/// <summary>
		/// Delibird Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Delibird(string nickname, int level)
		: base(
				DelibirdSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delibird Constructor only waiting for a Level
		/// </summary>
		public Delibird(int level)
		: this( "Delibird", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Delibird Constructor waiting for no params
		/// </summary>
		/*
		public Delibird() : this( "Delibird", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}