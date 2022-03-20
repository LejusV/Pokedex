using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Flabebe PokemonInstance Class
	#region Flabebe
	public class Flabebe : PokemonInstance
	{
		#region Flabebe Constructors
		/// <summary>
		/// Flabebe Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Flabebe(string nickname, int level)
		: base(
				FlabebeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flabebe Constructor only waiting for a Level
		/// </summary>
		public Flabebe(int level)
		: this( "Flabebe", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flabebe Constructor waiting for no params
		/// </summary>
		/*
		public Flabebe() : this( "Flabebe", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}