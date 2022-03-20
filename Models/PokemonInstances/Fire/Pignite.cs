using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pignite PokemonInstance Class
	#region Pignite
	public class Pignite : PokemonInstance
	{
		#region Pignite Constructors
		/// <summary>
		/// Pignite Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Pignite(string nickname, int level)
		: base(
				PigniteSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pignite Constructor only waiting for a Level
		/// </summary>
		public Pignite(int level)
		: this( "Pignite", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pignite Constructor waiting for no params
		/// </summary>
		/*
		public Pignite() : this( "Pignite", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}