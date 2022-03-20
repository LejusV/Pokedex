using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Smeargle PokemonInstance Class
	#region Smeargle
	public class Smeargle : PokemonInstance
	{
		#region Smeargle Constructors
		/// <summary>
		/// Smeargle Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Smeargle(string nickname, int level)
		: base(
				SmeargleSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smeargle Constructor only waiting for a Level
		/// </summary>
		public Smeargle(int level)
		: this( "Smeargle", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Smeargle Constructor waiting for no params
		/// </summary>
		/*
		public Smeargle() : this( "Smeargle", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}