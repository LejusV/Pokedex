using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Ninetales PokemonInstance Class
	#region Ninetales
	public class Ninetales : PokemonInstance
	{
		#region Ninetales Constructors
		/// <summary>
		/// Ninetales Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Ninetales(string nickname, int level)
		: base(
				NinetalesSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninetales Constructor only waiting for a Level
		/// </summary>
		public Ninetales(int level)
		: this( "Ninetales", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ninetales Constructor waiting for no params
		/// </summary>
		/*
		public Ninetales() : this( "Ninetales", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}