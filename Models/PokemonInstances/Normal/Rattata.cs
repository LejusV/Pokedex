using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rattata PokemonInstance Class
	#region Rattata
	public class Rattata : PokemonInstance
	{
		#region Rattata Constructors
		/// <summary>
		/// Rattata Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rattata(string nickname, int level)
		: base(
				RattataSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rattata Constructor only waiting for a Level
		/// </summary>
		public Rattata(int level)
		: this( "Rattata", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rattata Constructor waiting for no params
		/// </summary>
		/*
		public Rattata() : this( "Rattata", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}