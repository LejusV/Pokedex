using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Bunnelby PokemonInstance Class
	#region Bunnelby
	public class Bunnelby : PokemonInstance
	{
		#region Bunnelby Constructors
		/// <summary>
		/// Bunnelby Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Bunnelby(string nickname, int level)
		: base(
				BunnelbySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bunnelby Constructor only waiting for a Level
		/// </summary>
		public Bunnelby(int level)
		: this( "Bunnelby", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Bunnelby Constructor waiting for no params
		/// </summary>
		/*
		public Bunnelby() : this( "Bunnelby", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}