using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Clamperl PokemonInstance Class
	#region Clamperl
	public class Clamperl : PokemonInstance
	{
		#region Clamperl Constructors
		/// <summary>
		/// Clamperl Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Clamperl(string nickname, int level)
		: base(
				ClamperlSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clamperl Constructor only waiting for a Level
		/// </summary>
		public Clamperl(int level)
		: this( "Clamperl", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Clamperl Constructor waiting for no params
		/// </summary>
		/*
		public Clamperl() : this( "Clamperl", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}