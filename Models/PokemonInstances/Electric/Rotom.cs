using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Rotom PokemonInstance Class
	#region Rotom
	public class Rotom : PokemonInstance
	{
		#region Rotom Constructors
		/// <summary>
		/// Rotom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Rotom(string nickname, int level)
		: base(
				RotomSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rotom Constructor only waiting for a Level
		/// </summary>
		public Rotom(int level)
		: this( "Rotom", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Rotom Constructor waiting for no params
		/// </summary>
		/*
		public Rotom() : this( "Rotom", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}