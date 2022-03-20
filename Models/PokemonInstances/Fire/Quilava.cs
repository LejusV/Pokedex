using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Quilava PokemonInstance Class
	#region Quilava
	public class Quilava : PokemonInstance
	{
		#region Quilava Constructors
		/// <summary>
		/// Quilava Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Quilava(string nickname, int level)
		: base(
				QuilavaSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilava Constructor only waiting for a Level
		/// </summary>
		public Quilava(int level)
		: this( "Quilava", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Quilava Constructor waiting for no params
		/// </summary>
		/*
		public Quilava() : this( "Quilava", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}