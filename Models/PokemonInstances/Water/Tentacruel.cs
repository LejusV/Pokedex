using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Tentacruel PokemonInstance Class
	#region Tentacruel
	public class Tentacruel : PokemonInstance
	{
		#region Tentacruel Constructors
		/// <summary>
		/// Tentacruel Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Tentacruel(string nickname, int level)
		: base(
				TentacruelSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacruel Constructor only waiting for a Level
		/// </summary>
		public Tentacruel(int level)
		: this( "Tentacruel", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Tentacruel Constructor waiting for no params
		/// </summary>
		/*
		public Tentacruel() : this( "Tentacruel", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}