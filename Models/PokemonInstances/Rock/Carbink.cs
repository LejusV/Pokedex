using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Carbink PokemonInstance Class
	#region Carbink
	public class Carbink : PokemonInstance
	{
		#region Carbink Constructors
		/// <summary>
		/// Carbink Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Carbink(string nickname, int level)
		: base(
				CarbinkSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carbink Constructor only waiting for a Level
		/// </summary>
		public Carbink(int level)
		: this( "Carbink", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carbink Constructor waiting for no params
		/// </summary>
		/*
		public Carbink() : this( "Carbink", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}