using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hoothoot PokemonInstance Class
	#region Hoothoot
	public class Hoothoot : PokemonInstance
	{
		#region Hoothoot Constructors
		/// <summary>
		/// Hoothoot Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hoothoot(string nickname, int level)
		: base(
				HoothootSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoothoot Constructor only waiting for a Level
		/// </summary>
		public Hoothoot(int level)
		: this( "Hoothoot", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hoothoot Constructor waiting for no params
		/// </summary>
		/*
		public Hoothoot() : this( "Hoothoot", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}