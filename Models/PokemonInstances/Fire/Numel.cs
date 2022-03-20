using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Numel PokemonInstance Class
	#region Numel
	public class Numel : PokemonInstance
	{
		#region Numel Constructors
		/// <summary>
		/// Numel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Numel(string nickname, int level)
		: base(
				NumelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Numel Constructor only waiting for a Level
		/// </summary>
		public Numel(int level)
		: this( "Numel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Numel Constructor waiting for no params
		/// </summary>
		/*
		public Numel() : this( "Numel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}