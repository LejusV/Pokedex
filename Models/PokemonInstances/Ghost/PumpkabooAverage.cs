using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Pumpkaboo-Average PokemonInstance Class
	#region Pumpkaboo-Average
	public class PumpkabooAverage : PokemonInstance
	{
		#region Pumpkaboo-Average Constructors
		/// <summary>
		/// Pumpkaboo-Average Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PumpkabooAverage(string nickname, int level)
		: base(
				PumpkabooAverageSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pumpkaboo-Average Constructor only waiting for a Level
		/// </summary>
		public PumpkabooAverage(int level)
		: this( "Pumpkaboo-Average", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pumpkaboo-Average Constructor waiting for no params
		/// </summary>
		/*
		public PumpkabooAverage() : this( "Pumpkaboo-Average", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}