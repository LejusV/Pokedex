using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Buneary PokemonInstance Class
	#region Buneary
	public class Buneary : PokemonInstance
	{
		#region Buneary Constructors
		/// <summary>
		/// Buneary Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Buneary(string nickname, int level)
		: base(
				BunearySpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buneary Constructor only waiting for a Level
		/// </summary>
		public Buneary(int level)
		: this( "Buneary", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Buneary Constructor waiting for no params
		/// </summary>
		/*
		public Buneary() : this( "Buneary", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}