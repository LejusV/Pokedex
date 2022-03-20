using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Croconaw PokemonInstance Class
	#region Croconaw
	public class Croconaw : PokemonInstance
	{
		#region Croconaw Constructors
		/// <summary>
		/// Croconaw Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Croconaw(string nickname, int level)
		: base(
				CroconawSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croconaw Constructor only waiting for a Level
		/// </summary>
		public Croconaw(int level)
		: this( "Croconaw", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Croconaw Constructor waiting for no params
		/// </summary>
		/*
		public Croconaw() : this( "Croconaw", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}