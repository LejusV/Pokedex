using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Loudred PokemonInstance Class
	#region Loudred
	public class Loudred : PokemonInstance
	{
		#region Loudred Constructors
		/// <summary>
		/// Loudred Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Loudred(string nickname, int level)
		: base(
				LoudredSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Loudred Constructor only waiting for a Level
		/// </summary>
		public Loudred(int level)
		: this( "Loudred", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Loudred Constructor waiting for no params
		/// </summary>
		/*
		public Loudred() : this( "Loudred", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}