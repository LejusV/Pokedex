using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Deino PokemonInstance Class
	#region Deino
	public class Deino : PokemonInstance
	{
		#region Deino Constructors
		/// <summary>
		/// Deino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Deino(string nickname, int level)
		: base(
				DeinoSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deino Constructor only waiting for a Level
		/// </summary>
		public Deino(int level)
		: this( "Deino", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Deino Constructor waiting for no params
		/// </summary>
		/*
		public Deino() : this( "Deino", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}