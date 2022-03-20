using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Thievul PokemonInstance Class
	#region Thievul
	public class Thievul : PokemonInstance
	{
		#region Thievul Constructors
		/// <summary>
		/// Thievul Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Thievul(string nickname, int level)
		: base(
				ThievulSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thievul Constructor only waiting for a Level
		/// </summary>
		public Thievul(int level)
		: this( "Thievul", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Thievul Constructor waiting for no params
		/// </summary>
		/*
		public Thievul() : this( "Thievul", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}