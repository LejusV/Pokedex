using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Beldum PokemonInstance Class
	#region Beldum
	public class Beldum : PokemonInstance
	{
		#region Beldum Constructors
		/// <summary>
		/// Beldum Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Beldum(string nickname, int level)
		: base(
				BeldumSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beldum Constructor only waiting for a Level
		/// </summary>
		public Beldum(int level)
		: this( "Beldum", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Beldum Constructor waiting for no params
		/// </summary>
		/*
		public Beldum() : this( "Beldum", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}