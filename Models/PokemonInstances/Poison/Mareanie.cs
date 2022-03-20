using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Mareanie PokemonInstance Class
	#region Mareanie
	public class Mareanie : PokemonInstance
	{
		#region Mareanie Constructors
		/// <summary>
		/// Mareanie Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Mareanie(string nickname, int level)
		: base(
				MareanieSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareanie Constructor only waiting for a Level
		/// </summary>
		public Mareanie(int level)
		: this( "Mareanie", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mareanie Constructor waiting for no params
		/// </summary>
		/*
		public Mareanie() : this( "Mareanie", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}