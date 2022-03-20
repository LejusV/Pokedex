using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Natu PokemonInstance Class
	#region Natu
	public class Natu : PokemonInstance
	{
		#region Natu Constructors
		/// <summary>
		/// Natu Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Natu(string nickname, int level)
		: base(
				NatuSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Natu Constructor only waiting for a Level
		/// </summary>
		public Natu(int level)
		: this( "Natu", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Natu Constructor waiting for no params
		/// </summary>
		/*
		public Natu() : this( "Natu", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}