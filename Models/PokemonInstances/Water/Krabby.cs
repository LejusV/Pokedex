using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Krabby PokemonInstance Class
	#region Krabby
	public class Krabby : PokemonInstance
	{
		#region Krabby Constructors
		/// <summary>
		/// Krabby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Krabby(string nickname, int level)
		: base(
				KrabbySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krabby Constructor only waiting for a Level
		/// </summary>
		public Krabby(int level)
		: this( "Krabby", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Krabby Constructor waiting for no params
		/// </summary>
		/*
		public Krabby() : this( "Krabby", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}