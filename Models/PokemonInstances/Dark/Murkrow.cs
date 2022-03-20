using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Murkrow PokemonInstance Class
	#region Murkrow
	public class Murkrow : PokemonInstance
	{
		#region Murkrow Constructors
		/// <summary>
		/// Murkrow Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Murkrow(string nickname, int level)
		: base(
				MurkrowSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Murkrow Constructor only waiting for a Level
		/// </summary>
		public Murkrow(int level)
		: this( "Murkrow", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Murkrow Constructor waiting for no params
		/// </summary>
		/*
		public Murkrow() : this( "Murkrow", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}