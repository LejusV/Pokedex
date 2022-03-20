using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Swablu PokemonInstance Class
	#region Swablu
	public class Swablu : PokemonInstance
	{
		#region Swablu Constructors
		/// <summary>
		/// Swablu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Swablu(string nickname, int level)
		: base(
				SwabluSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swablu Constructor only waiting for a Level
		/// </summary>
		public Swablu(int level)
		: this( "Swablu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Swablu Constructor waiting for no params
		/// </summary>
		/*
		public Swablu() : this( "Swablu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}