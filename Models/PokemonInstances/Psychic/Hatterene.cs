using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Hatterene PokemonInstance Class
	#region Hatterene
	public class Hatterene : PokemonInstance
	{
		#region Hatterene Constructors
		/// <summary>
		/// Hatterene Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Hatterene(string nickname, int level)
		: base(
				HattereneSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatterene Constructor only waiting for a Level
		/// </summary>
		public Hatterene(int level)
		: this( "Hatterene", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Hatterene Constructor waiting for no params
		/// </summary>
		/*
		public Hatterene() : this( "Hatterene", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}