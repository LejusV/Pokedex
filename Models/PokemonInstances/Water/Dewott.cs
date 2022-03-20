using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dewott PokemonInstance Class
	#region Dewott
	public class Dewott : PokemonInstance
	{
		#region Dewott Constructors
		/// <summary>
		/// Dewott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dewott(string nickname, int level)
		: base(
				DewottSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewott Constructor only waiting for a Level
		/// </summary>
		public Dewott(int level)
		: this( "Dewott", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewott Constructor waiting for no params
		/// </summary>
		/*
		public Dewott() : this( "Dewott", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}