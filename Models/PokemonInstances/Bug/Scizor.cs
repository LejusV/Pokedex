using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Scizor PokemonInstance Class
	#region Scizor
	public class Scizor : PokemonInstance
	{
		#region Scizor Constructors
		/// <summary>
		/// Scizor Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Scizor(string nickname, int level)
		: base(
				ScizorSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scizor Constructor only waiting for a Level
		/// </summary>
		public Scizor(int level)
		: this( "Scizor", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Scizor Constructor waiting for no params
		/// </summary>
		/*
		public Scizor() : this( "Scizor", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}