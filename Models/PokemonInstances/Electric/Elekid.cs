using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Elekid PokemonInstance Class
	#region Elekid
	public class Elekid : PokemonInstance
	{
		#region Elekid Constructors
		/// <summary>
		/// Elekid Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Elekid(string nickname, int level)
		: base(
				ElekidSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elekid Constructor only waiting for a Level
		/// </summary>
		public Elekid(int level)
		: this( "Elekid", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Elekid Constructor waiting for no params
		/// </summary>
		/*
		public Elekid() : this( "Elekid", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}