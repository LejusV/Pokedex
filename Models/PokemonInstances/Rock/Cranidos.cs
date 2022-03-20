using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Cranidos PokemonInstance Class
	#region Cranidos
	public class Cranidos : PokemonInstance
	{
		#region Cranidos Constructors
		/// <summary>
		/// Cranidos Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Cranidos(string nickname, int level)
		: base(
				CranidosSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cranidos Constructor only waiting for a Level
		/// </summary>
		public Cranidos(int level)
		: this( "Cranidos", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cranidos Constructor waiting for no params
		/// </summary>
		/*
		public Cranidos() : this( "Cranidos", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}