using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lycanroc-Midday PokemonInstance Class
	#region Lycanroc-Midday
	public class LycanrocMidday : PokemonInstance
	{
		#region Lycanroc-Midday Constructors
		/// <summary>
		/// Lycanroc-Midday Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LycanrocMidday(string nickname, int level)
		: base(
				LycanrocMiddaySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lycanroc-Midday Constructor only waiting for a Level
		/// </summary>
		public LycanrocMidday(int level)
		: this( "Lycanroc-Midday", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lycanroc-Midday Constructor waiting for no params
		/// </summary>
		/*
		public LycanrocMidday() : this( "Lycanroc-Midday", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}