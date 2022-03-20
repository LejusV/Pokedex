using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hakamo-O PokemonInstance Class
	#region Hakamo-O
	public class HakamoO : PokemonInstance
	{
		#region Hakamo-O Constructors
		/// <summary>
		/// Hakamo-O Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public HakamoO(string nickname, int level)
		: base(
				HakamoOSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hakamo-O Constructor only waiting for a Level
		/// </summary>
		public HakamoO(int level)
		: this( "Hakamo-O", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hakamo-O Constructor waiting for no params
		/// </summary>
		/*
		public HakamoO() : this( "Hakamo-O", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}