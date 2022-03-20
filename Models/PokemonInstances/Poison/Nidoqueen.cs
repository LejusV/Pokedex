using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Nidoqueen PokemonInstance Class
	#region Nidoqueen
	public class Nidoqueen : PokemonInstance
	{
		#region Nidoqueen Constructors
		/// <summary>
		/// Nidoqueen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Nidoqueen(string nickname, int level)
		: base(
				NidoqueenSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoqueen Constructor only waiting for a Level
		/// </summary>
		public Nidoqueen(int level)
		: this( "Nidoqueen", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Nidoqueen Constructor waiting for no params
		/// </summary>
		/*
		public Nidoqueen() : this( "Nidoqueen", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}