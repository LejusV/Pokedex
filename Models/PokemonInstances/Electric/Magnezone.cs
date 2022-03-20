using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Magnezone PokemonInstance Class
	#region Magnezone
	public class Magnezone : PokemonInstance
	{
		#region Magnezone Constructors
		/// <summary>
		/// Magnezone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Magnezone(string nickname, int level)
		: base(
				MagnezoneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnezone Constructor only waiting for a Level
		/// </summary>
		public Magnezone(int level)
		: this( "Magnezone", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Magnezone Constructor waiting for no params
		/// </summary>
		/*
		public Magnezone() : this( "Magnezone", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}