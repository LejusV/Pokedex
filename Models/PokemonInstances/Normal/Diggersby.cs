using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Diggersby PokemonInstance Class
	#region Diggersby
	public class Diggersby : PokemonInstance
	{
		#region Diggersby Constructors
		/// <summary>
		/// Diggersby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Diggersby(string nickname, int level)
		: base(
				DiggersbySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diggersby Constructor only waiting for a Level
		/// </summary>
		public Diggersby(int level)
		: this( "Diggersby", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diggersby Constructor waiting for no params
		/// </summary>
		/*
		public Diggersby() : this( "Diggersby", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}