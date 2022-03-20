using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.Pokemons.Species;

namespace Pokedex.Models.Pokemons.Instances
{
	//Marshtomp PokemonInstance Class
	#region Marshtomp
	public class Marshtomp : PokemonInstance
	{
		#region Marshtomp Constructors
		/// <summary>
		/// Marshtomp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public Marshtomp(string nickname, int level)
		: base(
				MarshtompSpecies.Instance, // Pokemon Species
				nickname, level		
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshtomp Constructor only waiting for a Level
		/// </summary>
		public Marshtomp(int level)
		: this( "Marshtomp", level	)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Marshtomp Constructor waiting for no params
		/// </summary>
		/*
		public Marshtomp() : this( "Marshtomp", 1 )
		{}
		*/
		#endregion
	}
	#endregion
}