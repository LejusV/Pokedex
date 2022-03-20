using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dewgong PokemonInstance Class
	#region Dewgong
	public class Dewgong : PokemonInstance
	{
		#region Dewgong Constructors
		/// <summary>
		/// Dewgong Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dewgong(string nickname, int level)
		: base(
				DewgongSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewgong Constructor only waiting for a Level
		/// </summary>
		public Dewgong(int level)
		: this( "Dewgong", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dewgong Constructor waiting for no params
		/// </summary>
		/*
		public Dewgong() : this( "Dewgong", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}