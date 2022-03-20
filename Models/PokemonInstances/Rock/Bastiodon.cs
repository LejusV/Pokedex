using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bastiodon PokemonInstance Class
	#region Bastiodon
	public class Bastiodon : PokemonInstance
	{
		#region Bastiodon Constructors
		/// <summary>
		/// Bastiodon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bastiodon(string nickname, int level)
		: base(
				BastiodonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bastiodon Constructor only waiting for a Level
		/// </summary>
		public Bastiodon(int level)
		: this( "Bastiodon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bastiodon Constructor waiting for no params
		/// </summary>
		/*
		public Bastiodon() : this( "Bastiodon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}