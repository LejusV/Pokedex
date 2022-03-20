using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Miltank PokemonInstance Class
	#region Miltank
	public class Miltank : PokemonInstance
	{
		#region Miltank Constructors
		/// <summary>
		/// Miltank Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Miltank(string nickname, int level)
		: base(
				MiltankSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Miltank Constructor only waiting for a Level
		/// </summary>
		public Miltank(int level)
		: this( "Miltank", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Miltank Constructor waiting for no params
		/// </summary>
		/*
		public Miltank() : this( "Miltank", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}