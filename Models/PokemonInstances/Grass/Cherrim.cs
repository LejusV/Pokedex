using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cherrim PokemonInstance Class
	#region Cherrim
	public class Cherrim : PokemonInstance
	{
		#region Cherrim Constructors
		/// <summary>
		/// Cherrim Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cherrim(string nickname, int level)
		: base(
				CherrimSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherrim Constructor only waiting for a Level
		/// </summary>
		public Cherrim(int level)
		: this( "Cherrim", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cherrim Constructor waiting for no params
		/// </summary>
		/*
		public Cherrim() : this( "Cherrim", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}