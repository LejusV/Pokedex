using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Flaaffy PokemonInstance Class
	#region Flaaffy
	public class Flaaffy : PokemonInstance
	{
		#region Flaaffy Constructors
		/// <summary>
		/// Flaaffy Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Flaaffy(string nickname, int level)
		: base(
				FlaaffySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flaaffy Constructor only waiting for a Level
		/// </summary>
		public Flaaffy(int level)
		: this( "Flaaffy", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Flaaffy Constructor waiting for no params
		/// </summary>
		/*
		public Flaaffy() : this( "Flaaffy", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}