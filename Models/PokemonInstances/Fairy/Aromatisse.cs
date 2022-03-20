using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Aromatisse PokemonInstance Class
	#region Aromatisse
	public class Aromatisse : PokemonInstance
	{
		#region Aromatisse Constructors
		/// <summary>
		/// Aromatisse Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Aromatisse(string nickname, int level)
		: base(
				AromatisseSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aromatisse Constructor only waiting for a Level
		/// </summary>
		public Aromatisse(int level)
		: this( "Aromatisse", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aromatisse Constructor waiting for no params
		/// </summary>
		/*
		public Aromatisse() : this( "Aromatisse", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}