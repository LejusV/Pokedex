using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Seadra PokemonInstance Class
	#region Seadra
	public class Seadra : PokemonInstance
	{
		#region Seadra Constructors
		/// <summary>
		/// Seadra Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Seadra(string nickname, int level)
		: base(
				SeadraSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seadra Constructor only waiting for a Level
		/// </summary>
		public Seadra(int level)
		: this( "Seadra", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Seadra Constructor waiting for no params
		/// </summary>
		/*
		public Seadra() : this( "Seadra", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}