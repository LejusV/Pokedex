using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Leavanny PokemonInstance Class
	#region Leavanny
	public class Leavanny : PokemonInstance
	{
		#region Leavanny Constructors
		/// <summary>
		/// Leavanny Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Leavanny(string nickname, int level)
		: base(
				LeavannySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leavanny Constructor only waiting for a Level
		/// </summary>
		public Leavanny(int level)
		: this( "Leavanny", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Leavanny Constructor waiting for no params
		/// </summary>
		/*
		public Leavanny() : this( "Leavanny", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}