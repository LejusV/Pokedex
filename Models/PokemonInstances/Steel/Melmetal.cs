using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Melmetal PokemonInstance Class
	#region Melmetal
	public class Melmetal : PokemonInstance
	{
		#region Melmetal Constructors
		/// <summary>
		/// Melmetal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Melmetal(string nickname, int level)
		: base(
				MelmetalSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Melmetal Constructor only waiting for a Level
		/// </summary>
		public Melmetal(int level)
		: this( "Melmetal", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Melmetal Constructor waiting for no params
		/// </summary>
		/*
		public Melmetal() : this( "Melmetal", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}