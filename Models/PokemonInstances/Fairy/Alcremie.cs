using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Alcremie PokemonInstance Class
	#region Alcremie
	public class Alcremie : PokemonInstance
	{
		#region Alcremie Constructors
		/// <summary>
		/// Alcremie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Alcremie(string nickname, int level)
		: base(
				AlcremieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alcremie Constructor only waiting for a Level
		/// </summary>
		public Alcremie(int level)
		: this( "Alcremie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Alcremie Constructor waiting for no params
		/// </summary>
		/*
		public Alcremie() : this( "Alcremie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}