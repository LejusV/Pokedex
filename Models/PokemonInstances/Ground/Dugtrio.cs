using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Dugtrio PokemonInstance Class
	#region Dugtrio
	public class Dugtrio : PokemonInstance
	{
		#region Dugtrio Constructors
		/// <summary>
		/// Dugtrio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Dugtrio(string nickname, int level)
		: base(
				DugtrioSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dugtrio Constructor only waiting for a Level
		/// </summary>
		public Dugtrio(int level)
		: this( "Dugtrio", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dugtrio Constructor waiting for no params
		/// </summary>
		/*
		public Dugtrio() : this( "Dugtrio", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}