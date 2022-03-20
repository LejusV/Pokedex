using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Lanturn PokemonInstance Class
	#region Lanturn
	public class Lanturn : PokemonInstance
	{
		#region Lanturn Constructors
		/// <summary>
		/// Lanturn Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Lanturn(string nickname, int level)
		: base(
				LanturnSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lanturn Constructor only waiting for a Level
		/// </summary>
		public Lanturn(int level)
		: this( "Lanturn", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lanturn Constructor waiting for no params
		/// </summary>
		/*
		public Lanturn() : this( "Lanturn", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}