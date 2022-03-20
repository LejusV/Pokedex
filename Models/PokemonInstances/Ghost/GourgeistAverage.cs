using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Gourgeist-Average PokemonInstance Class
	#region Gourgeist-Average
	public class GourgeistAverage : PokemonInstance
	{
		#region Gourgeist-Average Constructors
		/// <summary>
		/// Gourgeist-Average Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GourgeistAverage(string nickname, int level)
		: base(
				GourgeistAverageSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gourgeist-Average Constructor only waiting for a Level
		/// </summary>
		public GourgeistAverage(int level)
		: this( "Gourgeist-Average", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gourgeist-Average Constructor waiting for no params
		/// </summary>
		/*
		public GourgeistAverage() : this( "Gourgeist-Average", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}