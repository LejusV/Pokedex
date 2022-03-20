using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Vivillon PokemonInstance Class
	#region Vivillon
	public class Vivillon : PokemonInstance
	{
		#region Vivillon Constructors
		/// <summary>
		/// Vivillon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Vivillon(string nickname, int level)
		: base(
				VivillonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vivillon Constructor only waiting for a Level
		/// </summary>
		public Vivillon(int level)
		: this( "Vivillon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Vivillon Constructor waiting for no params
		/// </summary>
		/*
		public Vivillon() : this( "Vivillon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}