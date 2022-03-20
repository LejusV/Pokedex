using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Appletun PokemonInstance Class
	#region Appletun
	public class Appletun : PokemonInstance
	{
		#region Appletun Constructors
		/// <summary>
		/// Appletun Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Appletun(string nickname, int level)
		: base(
				AppletunSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Appletun Constructor only waiting for a Level
		/// </summary>
		public Appletun(int level)
		: this( "Appletun", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Appletun Constructor waiting for no params
		/// </summary>
		/*
		public Appletun() : this( "Appletun", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}