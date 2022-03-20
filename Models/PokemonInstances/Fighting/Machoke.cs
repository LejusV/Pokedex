using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Machoke PokemonInstance Class
	#region Machoke
	public class Machoke : PokemonInstance
	{
		#region Machoke Constructors
		/// <summary>
		/// Machoke Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Machoke(string nickname, int level)
		: base(
				MachokeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machoke Constructor only waiting for a Level
		/// </summary>
		public Machoke(int level)
		: this( "Machoke", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Machoke Constructor waiting for no params
		/// </summary>
		/*
		public Machoke() : this( "Machoke", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}