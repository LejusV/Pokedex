using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dewpider PokemonInstance Class
	#region Dewpider
	public class Dewpider : PokemonInstance
	{
		#region Dewpider Constructors
		/// <summary>
		/// Dewpider Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dewpider(string nickname, int level)
		: base(
				DewpiderSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewpider Constructor only waiting for a Level
		/// </summary>
		public Dewpider(int level)
		: this( "Dewpider", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewpider Constructor waiting for no params
		/// </summary>
		/*
		public Dewpider() : this( "Dewpider", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}