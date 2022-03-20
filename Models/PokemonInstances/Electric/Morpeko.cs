using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Morpeko PokemonInstance Class
	#region Morpeko
	public class Morpeko : PokemonInstance
	{
		#region Morpeko Constructors
		/// <summary>
		/// Morpeko Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Morpeko(string nickname, int level)
		: base(
				MorpekoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morpeko Constructor only waiting for a Level
		/// </summary>
		public Morpeko(int level)
		: this( "Morpeko", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Morpeko Constructor waiting for no params
		/// </summary>
		/*
		public Morpeko() : this( "Morpeko", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}