using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Stoutland PokemonInstance Class
	#region Stoutland
	public class Stoutland : PokemonInstance
	{
		#region Stoutland Constructors
		/// <summary>
		/// Stoutland Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Stoutland(string nickname, int level)
		: base(
				StoutlandSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stoutland Constructor only waiting for a Level
		/// </summary>
		public Stoutland(int level)
		: this( "Stoutland", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Stoutland Constructor waiting for no params
		/// </summary>
		/*
		public Stoutland() : this( "Stoutland", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}