using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Chandelure PokemonInstance Class
	#region Chandelure
	public class Chandelure : PokemonInstance
	{
		#region Chandelure Constructors
		/// <summary>
		/// Chandelure Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Chandelure(string nickname, int level)
		: base(
				ChandelureSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chandelure Constructor only waiting for a Level
		/// </summary>
		public Chandelure(int level)
		: this( "Chandelure", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Chandelure Constructor waiting for no params
		/// </summary>
		/*
		public Chandelure() : this( "Chandelure", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}