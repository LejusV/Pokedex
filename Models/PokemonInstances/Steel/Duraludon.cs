using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Duraludon PokemonInstance Class
	#region Duraludon
	public class Duraludon : PokemonInstance
	{
		#region Duraludon Constructors
		/// <summary>
		/// Duraludon Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Duraludon(string nickname, int level)
		: base(
				DuraludonSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duraludon Constructor only waiting for a Level
		/// </summary>
		public Duraludon(int level)
		: this( "Duraludon", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Duraludon Constructor waiting for no params
		/// </summary>
		/*
		public Duraludon() : this( "Duraludon", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}