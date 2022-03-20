using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Xatu PokemonInstance Class
	#region Xatu
	public class Xatu : PokemonInstance
	{
		#region Xatu Constructors
		/// <summary>
		/// Xatu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Xatu(string nickname, int level)
		: base(
				XatuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xatu Constructor only waiting for a Level
		/// </summary>
		public Xatu(int level)
		: this( "Xatu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xatu Constructor waiting for no params
		/// </summary>
		/*
		public Xatu() : this( "Xatu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}