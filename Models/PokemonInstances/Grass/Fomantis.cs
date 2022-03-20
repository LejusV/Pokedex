using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Fomantis PokemonInstance Class
	#region Fomantis
	public class Fomantis : PokemonInstance
	{
		#region Fomantis Constructors
		/// <summary>
		/// Fomantis Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Fomantis(string nickname, int level)
		: base(
				FomantisSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fomantis Constructor only waiting for a Level
		/// </summary>
		public Fomantis(int level)
		: this( "Fomantis", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Fomantis Constructor waiting for no params
		/// </summary>
		/*
		public Fomantis() : this( "Fomantis", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}