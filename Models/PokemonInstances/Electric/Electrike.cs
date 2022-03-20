using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Electrike PokemonInstance Class
	#region Electrike
	public class Electrike : PokemonInstance
	{
		#region Electrike Constructors
		/// <summary>
		/// Electrike Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Electrike(string nickname, int level)
		: base(
				ElectrikeSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrike Constructor only waiting for a Level
		/// </summary>
		public Electrike(int level)
		: this( "Electrike", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Electrike Constructor waiting for no params
		/// </summary>
		/*
		public Electrike() : this( "Electrike", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}