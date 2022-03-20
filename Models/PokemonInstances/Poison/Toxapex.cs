using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Toxapex PokemonInstance Class
	#region Toxapex
	public class Toxapex : PokemonInstance
	{
		#region Toxapex Constructors
		/// <summary>
		/// Toxapex Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Toxapex(string nickname, int level)
		: base(
				ToxapexSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxapex Constructor only waiting for a Level
		/// </summary>
		public Toxapex(int level)
		: this( "Toxapex", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Toxapex Constructor waiting for no params
		/// </summary>
		/*
		public Toxapex() : this( "Toxapex", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}