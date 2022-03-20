using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Primarina PokemonInstance Class
	#region Primarina
	public class Primarina : PokemonInstance
	{
		#region Primarina Constructors
		/// <summary>
		/// Primarina Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Primarina(string nickname, int level)
		: base(
				PrimarinaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primarina Constructor only waiting for a Level
		/// </summary>
		public Primarina(int level)
		: this( "Primarina", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Primarina Constructor waiting for no params
		/// </summary>
		/*
		public Primarina() : this( "Primarina", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}